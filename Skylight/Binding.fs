module Binding
open System.Collections.Generic
open System.Windows
open System
open System.ComponentModel
open System.Threading
open Microsoft.FSharp.Quotations
open System.Reflection
open Microsoft.FSharp.Quotations.Patterns
open System.Linq.Expressions
open System.Windows.Threading
open System.Threading.Tasks

type Work =
| Idle
| Working of cts:CancellationTokenSource

type IPropTarget =
    abstract Get : obj
    abstract Set : obj -> unit
    abstract PropertyInfo : PropertyInfo
    abstract AddDisposable : IDisposable -> unit
    abstract Subscribe : (obj -> unit) -> unit
    abstract Dispose : unit -> unit

type PropTarget<'T>(propInfo:PropertyInfo,getter:Func<'T>,setter:Action<'T>) =
    let mutable disps = List<IDisposable>()
    let mutable subs = List<'T -> unit>()
    let mutable dirty = 0 //no interlock method for bool so use int representation
    let dispose () = 
        for disp in disps do disp.Dispose()
        disps.Clear()
        subs.Clear()
   
    member __.Get = getter.Invoke()
    member __.Set (o:'T) = 
        if Interlocked.CompareExchange(&dirty,1,0) = 0 then
            setter.Invoke(o)
            Application.Current.Dispatcher.Invoke(fun () -> for fn in subs do fn o )
            dirty <- 0
        
    member __.PropertyInfo = propInfo
    member __.AddDisposable (disp:IDisposable) = disps.Add disp
    member __.Subscribe (fn:'T -> unit) = 
        subs.Add fn
        
    interface IPropTarget with
        member __.Get = getter.Invoke() :> obj
        member x.Set (v:obj) = x.Set(v :?> 'T)
        member __.PropertyInfo = propInfo
        member __.AddDisposable (disp:IDisposable) = disps.Add disp
        member __.Subscribe (fn:obj -> unit) = subs.Add fn
        member x.Dispose () = dispose ()
    interface IDisposable with
        member __.Dispose() = dispose ()

let rec exprPath (expr:Expr) =
    match expr with
    | PropertyGet(expOpt,propertyInfo,_exprLs) -> 
        match expOpt with 
        | Some expr -> Expression.Call(exprPath expr, propertyInfo.GetGetMethod()) :> Expression
        | None -> failwithf "Cannot bind to static object with property: %s" propertyInfo.Name
    | Value(value, _typ)
    | ValueWithName(value, _typ,_) -> Expression.Constant(value) :> Expression
    | x ->  failwithf "Cannot bind to expression: %A" x

let quoteToExpressionCompile<'T>(propertyInfo:PropertyInfo,expr:Expr) =
    let childExpr = exprPath expr
                
    let call = Expression.Call(childExpr, propertyInfo.GetGetMethod())
    let mutable getter = Expression.Lambda<Func<'T>>(call)
    while getter.CanReduce do getter <- getter.Reduce() :?> Expression<Func<'T>> 
                
    let param = Expression.Parameter(typeof<'T>, propertyInfo.Name)
    let call = Expression.Call(childExpr, propertyInfo.GetSetMethod(), [| param :> Expression |])
    let mutable setter = Expression.Lambda<Action<'T>>(call, param)
    while setter.CanReduce do setter <- setter.Reduce() :?> Expression<Action<'T>> 

    (getter.Compile(),setter.Compile())

let exprTarget (expr:Expr<'T>) =
    match expr with
    | PropertyGet(expOpt,propertyInfo,_exprLs) ->
        if propertyInfo.CanWrite then 
            match expOpt with 
            | Some expr ->
                propertyInfo,expr
            | None -> failwithf "Cannot bind to static object with property: %s" propertyInfo.Name
        else failwithf  "target Property '%s' is readonly in expr: %A" propertyInfo.Name expr
    | x ->  failwithf "Cannot bind to expression: %A" x

type Env() =
    let props = Dictionary<PropertyInfo,IPropTarget>()
    let disps = List<IDisposable>()
    //member val Props = props with get,set
    member x.AddDisposable disp = disps.Add disp
    member x.AddExpr<'U>(target:Expr<'U>) =
        let propInfo, expr = exprTarget target
        if props.ContainsKey propInfo then 
            props.[propInfo] :?> PropTarget<'U>
        else
            let getter, setter = quoteToExpressionCompile<'U>(propInfo,expr)
            let lambda = new PropTarget<'U>(propInfo,getter,setter)
            props.Add(propInfo,lambda :> IPropTarget)
            lambda

    interface IDisposable with
        member x.Dispose() =
            for disp in disps do disp.Dispose()
            for kvp in props do kvp.Value.Dispose()

type IControlBinder =
    abstract ApplyEnv : Env -> unit
    abstract UIElement : UIElement
    
type ControlBinder<'C when 'C :> UIElement>(v:'C) =
    let mutable binds = []
    let mutable children = [] 
    member x.Control = v
    member x.Collect (bind:Env -> 'C -> unit) = binds <- bind :: binds ; x
    member x.AddChildBinder (child:IControlBinder) = children <- child :: children
    interface IControlBinder with
        member x.UIElement with get () = v :> UIElement
        member x.ApplyEnv (env:Env) = 
            while not binds.IsEmpty do binds.Head env v ; binds <- binds.Tail 
            while not children.IsEmpty do children.Head.ApplyEnv env ; children <- children.Tail

/// Property Binders
let propTargetBindX (target:Expr<'U>) (depProp:DependencyProperty) =
    fun (env:Env) (control:'C :> UIElement) ->
    let lambda = env.AddExpr(target)
    control.SetValue(depProp,lambda.Get)
    let eh = EventHandler(fun _ _ -> control.GetValue(depProp) :?> 'U |> lambda.Set)
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    let disposable = { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }
    env.AddDisposable disposable
    if not depProp.ReadOnly then
        printfn "Prop is Readable so subscribing"
        //lambda.Subscribe (fun v -> control.Dispatcher.Invoke(fun () -> control.SetValue(depProp,v)))
        lambda.Subscribe (fun v -> control.SetValue(depProp,v))
    
let propTargetGetX (target:Expr<'U>) (depProp:DependencyProperty) =
    fun (env:Env) (control:'C :> UIElement) ->
    let lambda = env.AddExpr(target)
    let eh = EventHandler(fun _ _ -> control.GetValue(depProp) :?> 'U |> lambda.Set)
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    let disposable = { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }
    env.AddDisposable disposable

let propMapTargetBindX (target:Expr<'U>) (getMap:'U->'V) (setMap:'V->'U) (depProp:DependencyProperty) =
    fun (env:Env) (control:UIElement) ->
    let lambda = env.AddExpr(target)
    control.SetValue(depProp,lambda.Get |> getMap)
    let eh = EventHandler(fun _ _ -> control.GetValue(depProp) :?> 'V |> setMap |> lambda.Set) // control.Dispatcher.Invoke(update))
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    let disposable = { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }
    env.AddDisposable disposable
    if not depProp.ReadOnly then lambda.Subscribe (fun v -> control.SetValue(depProp,getMap v))

let propMapTargetGetX (target:Expr<'U>) (setMap:'V->'U) (depProp:DependencyProperty) =
    fun (env:Env) (control:UIElement) ->
    let lambda = env.AddExpr(target)
    let eh = EventHandler(fun _ _ -> control.GetValue(depProp) :?> 'V |> setMap |> lambda.Set) // control.Dispatcher.Invoke(update))
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    env.AddDisposable { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }

let propMapTargetBind2X<'C,'U1,'U2,'V> (target1:Expr<'U1>) (target2:Expr<'U2>) (getMap:('U1*'U2)->'V) (setMap:'V->('U1*'U2)) (depProp:DependencyProperty) =
    fun (env:Env) (control:UIElement) ->
    let tp1 = env.AddExpr<'U1>(target1)
    let tp2 = env.AddExpr<'U2>(target2)
    let eh = EventHandler(fun _ _ -> let v1,v2 = control.GetValue(depProp) :?> 'V |> setMap in tp1.Set v1 ; tp2.Set v2)
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    let disposable = { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }
    env.AddDisposable disposable
    if not depProp.ReadOnly then
        tp1.Subscribe (fun v -> control.SetValue(depProp,getMap(v,tp2.Get)))
        tp2.Subscribe (fun v -> control.SetValue(depProp,getMap(tp1.Get,v)))

let propMapTargetGet2X<'C,'U1,'U2,'V> (target1:Expr<'U1>) (target2:Expr<'U2>) (setMap:'V->('U1*'U2)) (depProp:DependencyProperty) =
    fun (env:Env) (control:UIElement) ->
    let tp1 = env.AddExpr<'U1>(target1)
    let tp2 = env.AddExpr<'U2>(target2)
    let eh = EventHandler(fun _ _ -> let v1,v2 = control.GetValue(depProp) :?> 'V |> setMap in tp1.Set v1 ; tp2.Set v2)
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    let disposable = { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }
    env.AddDisposable disposable
    
let propMapTargetBind3X (target1:Expr<'U1>) (target2:Expr<'U2>) (target3:Expr<'U3>) (getMap:('U1*'U2*'U3)->'V) (setMap:'V->('U1*'U2*'U3)) (depProp:DependencyProperty) =
    fun (env:Env) (control:UIElement) ->
    let tp1 = env.AddExpr(target1)
    let tp2 = env.AddExpr(target2)
    let tp3 = env.AddExpr(target3)
    let eh = EventHandler(fun _ _ -> let v1,v2,v3 = control.GetValue(depProp) :?> 'V |> setMap in tp1.Set v1 ; tp2.Set v2 ; tp3.Set v3)
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    let disposable = { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }
    env.AddDisposable disposable
    if not depProp.ReadOnly then
        tp1.Subscribe (fun v -> control.SetValue(depProp,getMap(v,tp2.Get,tp3.Get)))
        tp2.Subscribe (fun v -> control.SetValue(depProp,getMap(tp1.Get,v,tp3.Get)))
        tp3.Subscribe (fun v -> control.SetValue(depProp,getMap(tp1.Get,tp2.Get,v)))

let propMapTargetGet3X (target1:Expr<'U1>) (target2:Expr<'U2>) (target3:Expr<'U3>) (setMap:'V->('U1*'U2*'U3)) (depProp:DependencyProperty) =
    fun (env:Env) (control:UIElement) ->
    let tp1 = env.AddExpr(target1)
    let tp2 = env.AddExpr(target2)
    let tp3 = env.AddExpr(target3)
    let eh = EventHandler(fun _ _ -> let v1,v2,v3 = control.GetValue(depProp) :?> 'V |> setMap in tp1.Set v1 ; tp2.Set v2 ; tp3.Set v3)
    let dpd = DependencyPropertyDescriptor.FromProperty(depProp, control.GetType())
    dpd.AddValueChanged(control, eh)
    let disposable = { new IDisposable with member __.Dispose() = dpd.RemoveValueChanged(control,eh) }
    env.AddDisposable disposable

// Event Binders
let callEvent<'C,'H,'A when 'H : delegate<'A,unit> and 'H :> Delegate>(handler:'H,evt:IEvent<'H,'A>) = 
    fun (env:Env) (_:'C) ->
    evt.AddHandler(handler) 
    env.AddDisposable { new IDisposable with member __.Dispose() = evt.RemoveHandler handler }

let bindEvent1<'C,'T,'H,'A when 'H : delegate<'A,unit> and 'H :> Delegate>(expr:Expr<'T>,handlerBuilder:PropTarget<'T> -> 'H,evt:IEvent<'H,'A>) =
    fun (env:Env) (_:'C) ->
    let pt = env.AddExpr<'T>(expr)
    let handler = handlerBuilder pt
    evt.AddHandler(handler) 
    env.AddDisposable { new IDisposable with member __.Dispose() = evt.RemoveHandler handler }

let bindEvent2<'C,'T1,'T2,'H,'A when 'H : delegate<'A,unit> and 'H :> Delegate>(expr1:Expr<'T1>,expr2:Expr<'T2>,handlerBuilder:(PropTarget<'T1> * PropTarget<'T2> ) -> 'H,evt:IEvent<'H,'A>) =
    fun (env:Env) (_:'C) ->
    let pt1 = env.AddExpr<'T1>(expr1)
    let pt2 = env.AddExpr<'T2>(expr2)
    let handler = handlerBuilder(pt1,pt2)
    evt.AddHandler(handler) 
    env.AddDisposable { new IDisposable with member __.Dispose() = evt.RemoveHandler handler }

let bindEvent3<'C,'T1,'T2,'T3,'H,'A when 'H : delegate<'A,unit> and 'H :> Delegate>(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,handlerBuilder:(PropTarget<'T1> * PropTarget<'T2> * PropTarget<'T3>) -> 'H,evt:IEvent<'H,'A>) =
    fun (env:Env) (_:'C) ->
    let pt1 = env.AddExpr<'T1>(expr1)
    let pt2 = env.AddExpr<'T2>(expr2)
    let pt3 = env.AddExpr<'T3>(expr3)
    let handler = handlerBuilder(pt1,pt2,pt3)
    evt.AddHandler(handler) 
    env.AddDisposable { new IDisposable with member __.Dispose() = evt.RemoveHandler handler }

let bindWorkEvent1<'C,'T,'H,'A when 'H : delegate<'A,unit> and 'H :> Delegate>(workExpr:Expr<Work>,expr:Expr<'T>,handlerBuilder:(obj -> 'A -> unit) -> 'H,fn:obj -> 'A -> CancellationToken -> Task<'T>,evt:IEvent<'H,'A>) =
    fun (env:Env) (_:'C) ->
    let work = env.AddExpr<Work>(workExpr)
    let pt = env.AddExpr<'T>(expr)
    let handler = handlerBuilder (fun sender args ->
        match work.Get with
        | Idle ->
            let cts = new CancellationTokenSource()
            let t = fn sender args cts.Token
            t.ContinueWith(fun (t:Task<'T>) -> pt.Set t.Result ; work.Set Idle, cts.Token) |> ignore
            work.Set (Working cts)
        | Working cts -> cts.Cancel() ; work.Set Idle)
    evt.AddHandler(handler) 
    env.AddDisposable { new IDisposable with member __.Dispose() = evt.RemoveHandler handler }

let bindWorkEvent2<'C,'T1,'T2,'H,'A when 'H : delegate<'A,unit> and 'H :> Delegate>(workExpr:Expr<Work>,expr1:Expr<'T1>,expr2:Expr<'T2>,handlerBuilder:(obj -> 'A -> unit) -> 'H,fn:obj -> 'A -> CancellationToken -> Task<'T1 * 'T2>,evt:IEvent<'H,'A>) =
    fun (env:Env) (_:'C) ->
    let work = env.AddExpr<Work>(workExpr)
    let pt1 = env.AddExpr<'T1>(expr1)
    let pt2 = env.AddExpr<'T2>(expr2)
    let handler = handlerBuilder (fun sender args -> 
        match work.Get with
        | Idle ->
            let cts = new CancellationTokenSource()
            let t = fn sender args cts.Token
            t.ContinueWith(fun (t:Task<'T1 * 'T2>) -> let v1,v2 = t.Result in pt1.Set v1 ; pt2.Set v2 ; work.Set Idle, cts.Token) |> ignore
            work.Set (Working cts)
        | Working cts -> cts.Cancel() ; work.Set Idle
    )
    evt.AddHandler(handler) 
    env.AddDisposable { new IDisposable with member __.Dispose() = evt.RemoveHandler handler }

let bindWorkEvent3<'C,'T1,'T2,'T3,'H,'A when 'H : delegate<'A,unit> and 'H :> Delegate>(workExpr:Expr<Work>,expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,handlerBuilder:(obj -> 'A -> unit) -> 'H,fn:obj -> 'A -> CancellationToken -> Task<'T1 * 'T2 * 'T3>,evt:IEvent<'H,'A>) =
    fun (env:Env) (_:'C) ->
    let work = env.AddExpr<Work>(workExpr)
    let pt1 = env.AddExpr<'T1>(expr1)
    let pt2 = env.AddExpr<'T2>(expr2)
    let pt3 = env.AddExpr<'T3>(expr3)
    let handler = handlerBuilder (fun sender args -> 
        match work.Get with
        | Idle ->
            let cts = new CancellationTokenSource()
            let t = fn sender args cts.Token
            t.ContinueWith(fun (t:Task<'T1 * 'T2 * 'T3>) -> let v1,v2,v3 = t.Result in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3 ; work.Set Idle, cts.Token) |> ignore
            work.Set (Working cts)
        | Working cts -> cts.Cancel() ; work.Set Idle
    )
    evt.AddHandler(handler) 
    env.AddDisposable { new IDisposable with member __.Dispose() = evt.RemoveHandler handler }