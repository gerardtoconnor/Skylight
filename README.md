# Skylight
A composable high level window library for F# and WPF to explore using Computation Expression UI, rather then Xaml.

![](./icon.png)

## Contents
- [Summary](#Summary)
- [The Model](#The-Model)
- [Property Setting](#Property-Setting)
- [Property Binding](#Property-Binding)
- [Event Binding](#Event-Binding)
- [Collections](#Collections)
- [Binding Child Views](#Binding-Child-Views)
- [Resources/Styling](#Resources/Styling)
- [Hacky Demo Application](#Hacky-Demo-Application)
- [Next Steps / Todo](#Next-Steps-/-Todo)


## Summary
Skylight is a basic, proof of concept library built on top of WPF and F# Computation Expressions to allow building of composable UI for windows. It will only provide basic functionality for basic UI.

__!! Skylight is not even an alpha, just a jumping off point and not intended for production as much functionality is missing / flakey !!__

The model is a hybrid of both MVVM and Elmish MVU, where a model is mapped into a view like MVU, but it is only done once on the initial render, with all subsequent updates propegating through targeted bindings. The targeted updates of model properties requires the model to be mutable as UI updates automatically propegate through to model, and the targets are defined using FSharp Quotations eg `<@ model.Property @>`.

In order to an update properties, and ensure they pass through the binding infrastrucutre, properties are never set directly like `model.Property <- value` as this will only update the model, not propegate it through the UI. All binding/mapping functions will allow you to return a value, and this will set the target property given by a FSharp Quotation `(<@ model.Prop @>,fun _ _ -> "myValue")` to allow multiple updates, there are overloads for these funtions eg `<@ model.P1 @>,<@ model.P2 @>,fun _ _ -> "P1Value" , "P2Value")`.

All property bind operations are following a basic pattern of

## The Model
We define our model with F# records like:
```fsharp
type Person = {
    mutable Name : string
    mutable Age : int
    mutable Address : string
}
```
Note properties need to be mutable in order to enable the app to update them.

Now that we have a model, we can define our view:
```f#
let mainView model = // a render function
    stackPanel {
        children [
            // simple bind
            label { content <@ model.Name @> }   
            // bind with map (int -> string)
            label { content (<@ model.Age @>,fun i -> string i) }
            // another simple bind
            label { content <@ model.Address @> }
        ]
    }
```
UI elements are created with computation expression builders, and thier properties are set or bound using the builders operations.

The controls that have CE's so far are:
- Border
- Button
- Canvas
- CheckBox
- ComboBox
- Grid
- Image
- Label
- ListBox
- RadioButton
- StackPanel
- WrapPanel
- DockPanel
- TabControl
- TextBox

On these controls there are essentially two types of operations:
- Property Bindings
- Event Bindings

Property bindings will just get and set properties of controls and your model, mapping where needed, while the actions and functionality of the application will be driven by events. Multiple overloads on the various Property and Event Bindings will allow us to model differnt interactions with the UI and model.

## Property Setting
For one time property setting on a UI Control, that does not need to watch a model property, you can just pass a value into the operation
```fsharp
textbox { text "static text value" }
``` 

## Property Binding
The common pattern for property binding will be to provide model property targets, via FSharp Quotations, and then functions for mapping if needed. The quotation captures the model instance as well as building a lambda to get/set the property for the binding model. __The model is mutable to allow that updates to the control eg a Textbox's Text property, will be automatically pushed into the property when the control values changes from user input__, in MVU you need to manually attach events for every single control, to transmit a message, to update model... which I am not a fan of. Skylight binding is also binding to updates when ever the control property is updated externally.
```fsharp
label { content <@ model.Name @> } 

textBox { text (<@ model.Age @>,fun i -> string i,fun str -> Int32.Parse str) }
// or simply
textBox { text (<@ model.Age @>,string,Int32.Parse) }
```  
For properties with only a getter, only one map is required.

## Event Binding
You can bind to most of the events found on controls, for clarity, all the operation names are prepended with `on` so that the `Click` event is called with the `onClick` operation:
```fsharp
// basic action with no return or bind
button { onClick (fun sender args -> ())}
// binding return value of event fn to target
button { onClick (<@ model.Age @>,fun _ args -> model.Age + 1 )}
```
For normal event binds, the function will take the sender object and the event handler args as the inputs, same as if you were using the handler. To bind a result to a target property, just give the 1) quoted prop target, and 2) a handler that returns a value, the value the target will be set to.

Given there are often more then 1 property you want to update, we overload to allow multiple binds, a tuple being used to return and set  many results
```fsharp
// set two props
button { onClick (<@ model.Age @>,<@ model.Name @>,fun _ args -> model.Age + 1 , model.Name + "+1" )}

// set three props
button { onClick (<@ model.Age @>,<@ model.Name @>,<@ model.Address @>,fun _ args -> model.Age + 1 , model.Name + "+1", "old Town" )}
```
Events are often carring out or triggering `Task` based async work which you want to manage, so it makes sense to build in a native-ish handling of `Task`. I use a simple DU of:
```fsharp
type Work =
| Idle
| Working of CancellationTokenSource
```
Now event bindings that first target a binding expression of `Work` can manage the `Task`, providing a CancellationToken (in addition to sender & event args), and allowing binding returns when used with `TaskBuilder.fs` CE
```fsharp
let work = ref Idle //a scoped view-model ref variable
button { onClick (<@ work.Value @>,<@ model.Name @>,
    fun sender args ct -> task {
    use client = new System.Net.Http.HttpClient()
    let! res = client.GetAsync("https://name-url", ct) // passed cancellation token
    return! res.Content.ReadAsStringAsync()
    })
}
```

## Collections
Despite re-inventing the wheel everywhere else, I decided to use `ObservableCollection` for collections, with type abbreviation `OSeq`. `OSeq` will natively bind to `ItemsControls`, eg the `items` operation on items controls. Given we are mutating the collection, and not changing the reference, we do not need/use quotations. 
```fsharp
type Model = { Items:OSeq<string> ; Selected:obj }
let model = { Items = OSeq(["Jan";"Feb";"Mar"]) ; Selected = null }
listBox {
    items (model.Items,fun (v:string) -> label { content v } )
    selectedItem <@ model.Selected @>
}
```
The following will render a template of `label { content v }` for each value in the collection, and track the addition/removals to keep view in sync. The bindings for each child view are managed and disposed correctly by the operation binding.

`Panels` like `Grid`, `WrapPanel` and `StackPanel` can also bind `ObservableCollections` to thier children operation to allow
```fsharp
type Model = { Items:OSeq<string> }
let model = { Items = OSeq(["Jan";"Feb";"Mar"]) }
stackPanel {
    childern (model.Items,fun (v:string) -> label { content v } )
}
```

## Binding Child Views
An important critical feature of the applications composability and efficiency is that it's `Views` are created and disposed of correctly, where `Views` are scoped groupings of controls and bindings mapped to a specific model. Views can be bound to a VM property such that a child view can be spawned in the mapping, and dispose of the prior child as appropriate.
```fsharp
let childView1 model = ...
let childView2 model = ...
let view = ref (childView1 model)
stackPanel {
    add <@ view.Value @> // binding view allows swapping views
    add ( 
        button {
            content "set to child 2"
            onClick (<@ view.Value @>),fun _ _ -> childView2 model)
    }) 
}
```

## Resources/Styling
The application can load a resource dictionary with required styling if wanted, but for this initial release, I have left our styling and looked purely at functionality.

## Hacky Demo Application
If you look in Program.fs, you can see a very messy hacky UI I built to test the functionality and binding, I'm sure it's missing a ton of controls/operations but it works nicely as a proof of concept. To run you need to open sln in VS, and restore nuget packages before running.
```fsharp
let mainView model = ...

[<EntryPoint;STAThread>]
let main argv = 
    
    let model = { 
        Message = "Hello" 
        FontSize = 12.
        Items = OSeq(["January";"February";"March"])
        Selected = null
        VariableCount = 0 
        Submodel = { 
            Value1 = "SubModel Value1" 
            Counter = 0  
            MyRow = 0
            MyCol = 0
        }
    }
    
    window {
        title "Ger's App"
        height 720.
        width 520.
        content (mainView model)
    } |> Application().Run
```
## Next Steps / Todo
There are many things missing, including controls which I hope to impliment in the coming itterations
- Add additional missing controls
- Add optional overload to event operations to accept a dispatch function that will allow message passing to parent model
- Add control/pattern for adding in custom events, so sockets etc can integrate seemlessly.
- Investigate benefit of immutable model and how to automate the copying `with` properties for automated updating from events
  - Many think the immutable model is far better but given I want control properties to automatically propergate updates back into the model, I would need to find an efficient, performant way to do it progrmatically as I do not want to have users have to manually wire up events, for messages, just to update a property.
  - Being a staticly typed languge, with update patterns available at compile time, I would not look to do a traditional diff, but instead, a targeted, scoped diff, aided by compile time analysis of transforms.
