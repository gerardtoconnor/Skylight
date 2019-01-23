module CExpressions
open System
open System.Windows
open System.Windows.Controls
open System.Windows.Data
open System.Collections.Generic
open System.ComponentModel
open System.Windows.Threading
open System.Threading.Tasks
open System.Windows.Markup
open System.Windows.Input
open System.Windows.Media
open System.Windows.Media.Effects
open System.Threading
open System.Windows
open System.Collections
open Microsoft.FSharp.Quotations
open System.Collections.ObjectModel
open System.Windows.Shell
open Binding
type UIElementBuilder() =

    [<CustomOperation("uid")>]
    member __.Uid<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:string) = binder.Control.Uid <- v ; binder
    
    member __.Uid<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.UidProperty)
    member __.Uid<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.UidProperty)
    member __.Uid<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.UidProperty)
    member __.Uid<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.UidProperty)
    

    [<CustomOperation("visibility")>]
    member __.Visibility<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:Visibility) = binder.Control.Visibility <- v ; binder
    
    member __.Visibility<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.VisibilityProperty)
    member __.Visibility<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.VisibilityProperty)
    member __.Visibility<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.VisibilityProperty)
    member __.Visibility<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.VisibilityProperty)
    

    [<CustomOperation("clipToBounds")>]
    member __.ClipToBounds<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.ClipToBounds <- v ; binder
    
    member __.ClipToBounds<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.ClipToBoundsProperty)
    member __.ClipToBounds<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.ClipToBoundsProperty)
    member __.ClipToBounds<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.ClipToBoundsProperty)
    member __.ClipToBounds<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.ClipToBoundsProperty)
    

    [<CustomOperation("clip")>]
    member __.Clip<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:Geometry) = binder.Control.Clip <- v ; binder
    
    member __.Clip<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.ClipProperty)
    member __.Clip<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.ClipProperty)
    member __.Clip<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.ClipProperty)
    member __.Clip<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.ClipProperty)
    

    [<CustomOperation("snapsToDevicePixels")>]
    member __.SnapsToDevicePixels<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.SnapsToDevicePixels <- v ; binder
    
    member __.SnapsToDevicePixels<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.SnapsToDevicePixelsProperty)
    member __.SnapsToDevicePixels<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.SnapsToDevicePixelsProperty)
    member __.SnapsToDevicePixels<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.SnapsToDevicePixelsProperty)
    member __.SnapsToDevicePixels<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.SnapsToDevicePixelsProperty)
    

    [<CustomOperation("isFocused")>]
    member __.IsFocused<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsFocusedProperty)  
    member __.IsFocused<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsFocusedProperty)
    member __.IsFocused<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsFocusedProperty)
    member __.IsFocused<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsFocusedProperty)

    [<CustomOperation("isEnabled")>]
    member __.IsEnabled<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsEnabled <- v ; binder
    
    member __.IsEnabled<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.IsEnabledProperty)
    member __.IsEnabled<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.IsEnabledProperty)
    member __.IsEnabled<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.IsEnabledProperty)
    member __.IsEnabled<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.IsEnabledProperty)
    

    [<CustomOperation("isHitTestVisible")>]
    member __.IsHitTestVisible<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsHitTestVisible <- v ; binder
    
    member __.IsHitTestVisible<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.IsHitTestVisibleProperty)
    member __.IsHitTestVisible<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.IsHitTestVisibleProperty)
    member __.IsHitTestVisible<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.IsHitTestVisibleProperty)
    member __.IsHitTestVisible<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.IsHitTestVisibleProperty)
    

    [<CustomOperation("isVisible")>]
    member __.IsVisible<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsVisibleProperty)  
    member __.IsVisible<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsVisibleProperty)
    member __.IsVisible<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsVisibleProperty)
    member __.IsVisible<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsVisibleProperty)

    [<CustomOperation("areAnyTouchesCapturedWithin")>]
    member __.AreAnyTouchesCapturedWithin<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.AreAnyTouchesCapturedWithinProperty)  
    member __.AreAnyTouchesCapturedWithin<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.AreAnyTouchesCapturedWithinProperty)
    member __.AreAnyTouchesCapturedWithin<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.AreAnyTouchesCapturedWithinProperty)
    member __.AreAnyTouchesCapturedWithin<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.AreAnyTouchesCapturedWithinProperty)

    [<CustomOperation("isManipulationEnabled")>]
    member __.IsManipulationEnabled<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsManipulationEnabled <- v ; binder
    
    member __.IsManipulationEnabled<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.IsManipulationEnabledProperty)
    member __.IsManipulationEnabled<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.IsManipulationEnabledProperty)
    member __.IsManipulationEnabled<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.IsManipulationEnabledProperty)
    member __.IsManipulationEnabled<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.IsManipulationEnabledProperty)
    

    [<CustomOperation("areAnyTouchesOver")>]
    member __.AreAnyTouchesOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.AreAnyTouchesOverProperty)  
    member __.AreAnyTouchesOver<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.AreAnyTouchesOverProperty)
    member __.AreAnyTouchesOver<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.AreAnyTouchesOverProperty)
    member __.AreAnyTouchesOver<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.AreAnyTouchesOverProperty)

    [<CustomOperation("areAnyTouchesDirectlyOver")>]
    member __.AreAnyTouchesDirectlyOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.AreAnyTouchesDirectlyOverProperty)  
    member __.AreAnyTouchesDirectlyOver<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.AreAnyTouchesDirectlyOverProperty)
    member __.AreAnyTouchesDirectlyOver<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.AreAnyTouchesDirectlyOverProperty)
    member __.AreAnyTouchesDirectlyOver<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.AreAnyTouchesDirectlyOverProperty)

    [<CustomOperation("areAnyTouchesCaptured")>]
    member __.AreAnyTouchesCaptured<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.AreAnyTouchesCapturedProperty)  
    member __.AreAnyTouchesCaptured<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.AreAnyTouchesCapturedProperty)
    member __.AreAnyTouchesCaptured<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.AreAnyTouchesCapturedProperty)
    member __.AreAnyTouchesCaptured<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.AreAnyTouchesCapturedProperty)

    [<CustomOperation("cacheMode")>]
    member __.CacheMode<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:CacheMode) = binder.Control.CacheMode <- v ; binder
    
    member __.CacheMode<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.CacheModeProperty)
    member __.CacheMode<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.CacheModeProperty)
    member __.CacheMode<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.CacheModeProperty)
    member __.CacheMode<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.CacheModeProperty)
    

    [<CustomOperation("focusable")>]
    member __.Focusable<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.Focusable <- v ; binder
    
    member __.Focusable<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.FocusableProperty)
    member __.Focusable<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.FocusableProperty)
    member __.Focusable<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.FocusableProperty)
    member __.Focusable<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.FocusableProperty)
    

    [<CustomOperation("bitmapEffectInput")>]
    member __.BitmapEffectInput<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:BitmapEffectInput) = binder.Control.BitmapEffectInput <- v ; binder
    
    member __.BitmapEffectInput<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.BitmapEffectInputProperty)
    member __.BitmapEffectInput<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.BitmapEffectInputProperty)
    member __.BitmapEffectInput<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.BitmapEffectInputProperty)
    member __.BitmapEffectInput<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.BitmapEffectInputProperty)
    

    [<CustomOperation("isMouseDirectlyOver")>]
    member __.IsMouseDirectlyOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsMouseDirectlyOverProperty)  
    member __.IsMouseDirectlyOver<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsMouseDirectlyOverProperty)
    member __.IsMouseDirectlyOver<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsMouseDirectlyOverProperty)
    member __.IsMouseDirectlyOver<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsMouseDirectlyOverProperty)

    [<CustomOperation("bitmapEffect")>]
    member __.BitmapEffect<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:BitmapEffect) = binder.Control.BitmapEffect <- v ; binder
    
    member __.BitmapEffect<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.BitmapEffectProperty)
    member __.BitmapEffect<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.BitmapEffectProperty)
    member __.BitmapEffect<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.BitmapEffectProperty)
    member __.BitmapEffect<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.BitmapEffectProperty)
    

    [<CustomOperation("renderSize")>]
    member __.RenderSize<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:Size) = binder.Control.RenderSize <- v ; binder

    [<CustomOperation("allowDrop")>]
    member __.AllowDrop<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.AllowDrop <- v ; binder
    
    member __.AllowDrop<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.AllowDropProperty)
    member __.AllowDrop<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.AllowDropProperty)
    member __.AllowDrop<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.AllowDropProperty)
    member __.AllowDrop<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.AllowDropProperty)
    

    [<CustomOperation("isMouseOver")>]
    member __.IsMouseOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsMouseOverProperty)  
    member __.IsMouseOver<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsMouseOverProperty)
    member __.IsMouseOver<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsMouseOverProperty)
    member __.IsMouseOver<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsMouseOverProperty)

    [<CustomOperation("effect")>]
    member __.Effect<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:Effect) = binder.Control.Effect <- v ; binder
    
    member __.Effect<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.EffectProperty)
    member __.Effect<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.EffectProperty)
    member __.Effect<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.EffectProperty)
    member __.Effect<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.EffectProperty)
    

    [<CustomOperation("isStylusOver")>]
    member __.IsStylusOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsStylusOverProperty)  
    member __.IsStylusOver<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsStylusOverProperty)
    member __.IsStylusOver<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsStylusOverProperty)
    member __.IsStylusOver<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsStylusOverProperty)

    [<CustomOperation("isMouseCaptured")>]
    member __.IsMouseCaptured<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsMouseCapturedProperty)  
    member __.IsMouseCaptured<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsMouseCapturedProperty)
    member __.IsMouseCaptured<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsMouseCapturedProperty)
    member __.IsMouseCaptured<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsMouseCapturedProperty)

    [<CustomOperation("isMouseCaptureWithin")>]
    member __.IsMouseCaptureWithin<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsMouseCaptureWithinProperty)  
    member __.IsMouseCaptureWithin<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsMouseCaptureWithinProperty)
    member __.IsMouseCaptureWithin<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsMouseCaptureWithinProperty)
    member __.IsMouseCaptureWithin<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsMouseCaptureWithinProperty)

    [<CustomOperation("isStylusDirectlyOver")>]
    member __.IsStylusDirectlyOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsStylusDirectlyOverProperty)  
    member __.IsStylusDirectlyOver<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsStylusDirectlyOverProperty)
    member __.IsStylusDirectlyOver<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsStylusDirectlyOverProperty)
    member __.IsStylusDirectlyOver<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsStylusDirectlyOverProperty)

    [<CustomOperation("isStylusCaptured")>]
    member __.IsStylusCaptured<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsStylusCapturedProperty)  
    member __.IsStylusCaptured<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsStylusCapturedProperty)
    member __.IsStylusCaptured<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsStylusCapturedProperty)
    member __.IsStylusCaptured<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsStylusCapturedProperty)

    [<CustomOperation("isStylusCaptureWithin")>]
    member __.IsStylusCaptureWithin<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsStylusCaptureWithinProperty)  
    member __.IsStylusCaptureWithin<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsStylusCaptureWithinProperty)
    member __.IsStylusCaptureWithin<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsStylusCaptureWithinProperty)
    member __.IsStylusCaptureWithin<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsStylusCaptureWithinProperty)

    [<CustomOperation("isKeyboardFocused")>]
    member __.IsKeyboardFocused<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsKeyboardFocusedProperty)  
    member __.IsKeyboardFocused<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsKeyboardFocusedProperty)
    member __.IsKeyboardFocused<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsKeyboardFocusedProperty)
    member __.IsKeyboardFocused<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsKeyboardFocusedProperty)

    [<CustomOperation("opacity")>]
    member __.Opacity<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:double) = binder.Control.Opacity <- v ; binder
    
    member __.Opacity<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.OpacityProperty)
    member __.Opacity<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.OpacityProperty)
    member __.Opacity<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.OpacityProperty)
    member __.Opacity<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.OpacityProperty)
    

    [<CustomOperation("opacityMask")>]
    member __.OpacityMask<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:Brush) = binder.Control.OpacityMask <- v ; binder
    
    member __.OpacityMask<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.OpacityMaskProperty)
    member __.OpacityMask<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.OpacityMaskProperty)
    member __.OpacityMask<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.OpacityMaskProperty)
    member __.OpacityMask<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.OpacityMaskProperty)
    

    [<CustomOperation("isKeyboardFocusWithin")>]
    member __.IsKeyboardFocusWithin<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr UIElement.IsKeyboardFocusWithinProperty)  
    member __.IsKeyboardFocusWithin<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap UIElement.IsKeyboardFocusWithinProperty)
    member __.IsKeyboardFocusWithin<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap UIElement.IsKeyboardFocusWithinProperty)
    member __.IsKeyboardFocusWithin<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap UIElement.IsKeyboardFocusWithinProperty)

    [<CustomOperation("renderTransformOrigin")>]
    member __.RenderTransformOrigin<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:Point) = binder.Control.RenderTransformOrigin <- v ; binder
    
    member __.RenderTransformOrigin<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.RenderTransformOriginProperty)
    member __.RenderTransformOrigin<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.RenderTransformOriginProperty)
    member __.RenderTransformOrigin<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.RenderTransformOriginProperty)
    member __.RenderTransformOrigin<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.RenderTransformOriginProperty)
    

    [<CustomOperation("renderTransform")>]
    member __.RenderTransform<'C when 'C :> UIElement>(binder:ControlBinder<'C>,v:Transform) = binder.Control.RenderTransform <- v ; binder
    
    member __.RenderTransform<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr UIElement.RenderTransformProperty)
    member __.RenderTransform<'C,'TP,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap UIElement.RenderTransformProperty)
    member __.RenderTransform<'C,'T1,'T2,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap UIElement.RenderTransformProperty)
    member __.RenderTransform<'C,'T1,'T2,'T3,'TC when 'C :> UIElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap UIElement.RenderTransformProperty)
    

    [<CustomOperation("onKeyUp")>]  
    member x.KeyUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyEventHandler(fn),binder.Control.KeyUp))
    member x.KeyUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.KeyUp))
    member x.KeyUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.KeyUp))
    member x.KeyUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.KeyUp))

    member x.KeyUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyEventHandler(h)),fn,binder.Control.KeyUp))
    member x.KeyUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyEventHandler(h)),fn,binder.Control.KeyUp))
    member x.KeyUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyEventHandler(h)),fn,binder.Control.KeyUp))
    



    [<CustomOperation("onTouchMove")>]  
    member x.TouchMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.TouchMove))
    member x.TouchMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.TouchMove))
    member x.TouchMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.TouchMove))
    member x.TouchMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.TouchMove))

    member x.TouchMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchMove))
    member x.TouchMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchMove))
    member x.TouchMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchMove))
    



    [<CustomOperation("onPreviewTouchMove")>]  
    member x.PreviewTouchMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.PreviewTouchMove))
    member x.PreviewTouchMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewTouchMove))
    member x.PreviewTouchMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewTouchMove))
    member x.PreviewTouchMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewTouchMove))

    member x.PreviewTouchMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchMove))
    member x.PreviewTouchMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchMove))
    member x.PreviewTouchMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchMove))
    



    [<CustomOperation("onTouchDown")>]  
    member x.TouchDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.TouchDown))
    member x.TouchDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.TouchDown))
    member x.TouchDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.TouchDown))
    member x.TouchDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.TouchDown))

    member x.TouchDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchDown))
    member x.TouchDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchDown))
    member x.TouchDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchDown))
    



    [<CustomOperation("onPreviewTouchDown")>]  
    member x.PreviewTouchDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.PreviewTouchDown))
    member x.PreviewTouchDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewTouchDown))
    member x.PreviewTouchDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewTouchDown))
    member x.PreviewTouchDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewTouchDown))

    member x.PreviewTouchDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchDown))
    member x.PreviewTouchDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchDown))
    member x.PreviewTouchDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchDown))
    



    [<CustomOperation("onDrop")>]  
    member x.Drop<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.Drop))
    member x.Drop<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.Drop))
    member x.Drop<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.Drop))
    member x.Drop<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.Drop))

    member x.Drop<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.Drop))
    member x.Drop<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.Drop))
    member x.Drop<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.Drop))
    



    [<CustomOperation("onPreviewDrop")>]  
    member x.PreviewDrop<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.PreviewDrop))
    member x.PreviewDrop<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewDrop))
    member x.PreviewDrop<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewDrop))
    member x.PreviewDrop<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewDrop))

    member x.PreviewDrop<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDrop))
    member x.PreviewDrop<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDrop))
    member x.PreviewDrop<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDrop))
    



    [<CustomOperation("onDragLeave")>]  
    member x.DragLeave<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.DragLeave))
    member x.DragLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.DragLeave))
    member x.DragLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.DragLeave))
    member x.DragLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.DragLeave))

    member x.DragLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.DragLeave))
    member x.DragLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.DragLeave))
    member x.DragLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.DragLeave))
    



    [<CustomOperation("onPreviewDragLeave")>]  
    member x.PreviewDragLeave<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.PreviewDragLeave))
    member x.PreviewDragLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewDragLeave))
    member x.PreviewDragLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewDragLeave))
    member x.PreviewDragLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewDragLeave))

    member x.PreviewDragLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragLeave))
    member x.PreviewDragLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragLeave))
    member x.PreviewDragLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragLeave))
    



    [<CustomOperation("onDragOver")>]  
    member x.DragOver<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.DragOver))
    member x.DragOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.DragOver))
    member x.DragOver<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.DragOver))
    member x.DragOver<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.DragOver))

    member x.DragOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.DragOver))
    member x.DragOver<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.DragOver))
    member x.DragOver<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.DragOver))
    



    [<CustomOperation("onPreviewDragOver")>]  
    member x.PreviewDragOver<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.PreviewDragOver))
    member x.PreviewDragOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewDragOver))
    member x.PreviewDragOver<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewDragOver))
    member x.PreviewDragOver<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewDragOver))

    member x.PreviewDragOver<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragOver))
    member x.PreviewDragOver<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragOver))
    member x.PreviewDragOver<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragOver))
    



    [<CustomOperation("onDragEnter")>]  
    member x.DragEnter<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.DragEnter))
    member x.DragEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.DragEnter))
    member x.DragEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.DragEnter))
    member x.DragEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.DragEnter))

    member x.DragEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.DragEnter))
    member x.DragEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.DragEnter))
    member x.DragEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.DragEnter))
    



    [<CustomOperation("onPreviewDragEnter")>]  
    member x.PreviewDragEnter<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(DragEventHandler(fn),binder.Control.PreviewDragEnter))
    member x.PreviewDragEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> DragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewDragEnter))
    member x.PreviewDragEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> DragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewDragEnter))
    member x.PreviewDragEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> DragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewDragEnter))

    member x.PreviewDragEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragEnter))
    member x.PreviewDragEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragEnter))
    member x.PreviewDragEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> DragEventHandler(h)),fn,binder.Control.PreviewDragEnter))
    



    [<CustomOperation("onGiveFeedback")>]  
    member x.GiveFeedback<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(GiveFeedbackEventHandler(fn),binder.Control.GiveFeedback))
    member x.GiveFeedback<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> GiveFeedbackEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.GiveFeedback))
    member x.GiveFeedback<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> GiveFeedbackEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.GiveFeedback))
    member x.GiveFeedback<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> GiveFeedbackEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.GiveFeedback))

    member x.GiveFeedback<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> GiveFeedbackEventHandler(h)),fn,binder.Control.GiveFeedback))
    member x.GiveFeedback<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> GiveFeedbackEventHandler(h)),fn,binder.Control.GiveFeedback))
    member x.GiveFeedback<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> GiveFeedbackEventHandler(h)),fn,binder.Control.GiveFeedback))
    



    [<CustomOperation("onPreviewGiveFeedback")>]  
    member x.PreviewGiveFeedback<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(GiveFeedbackEventHandler(fn),binder.Control.PreviewGiveFeedback))
    member x.PreviewGiveFeedback<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> GiveFeedbackEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewGiveFeedback))
    member x.PreviewGiveFeedback<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> GiveFeedbackEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewGiveFeedback))
    member x.PreviewGiveFeedback<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> GiveFeedbackEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewGiveFeedback))

    member x.PreviewGiveFeedback<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> GiveFeedbackEventHandler(h)),fn,binder.Control.PreviewGiveFeedback))
    member x.PreviewGiveFeedback<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> GiveFeedbackEventHandler(h)),fn,binder.Control.PreviewGiveFeedback))
    member x.PreviewGiveFeedback<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> GiveFeedbackEventHandler(h)),fn,binder.Control.PreviewGiveFeedback))
    



    [<CustomOperation("onQueryContinueDrag")>]  
    member x.QueryContinueDrag<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(QueryContinueDragEventHandler(fn),binder.Control.QueryContinueDrag))
    member x.QueryContinueDrag<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> QueryContinueDragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.QueryContinueDrag))
    member x.QueryContinueDrag<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> QueryContinueDragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.QueryContinueDrag))
    member x.QueryContinueDrag<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> QueryContinueDragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.QueryContinueDrag))

    member x.QueryContinueDrag<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> QueryContinueDragEventHandler(h)),fn,binder.Control.QueryContinueDrag))
    member x.QueryContinueDrag<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> QueryContinueDragEventHandler(h)),fn,binder.Control.QueryContinueDrag))
    member x.QueryContinueDrag<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> QueryContinueDragEventHandler(h)),fn,binder.Control.QueryContinueDrag))
    



    [<CustomOperation("onPreviewQueryContinueDrag")>]  
    member x.PreviewQueryContinueDrag<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(QueryContinueDragEventHandler(fn),binder.Control.PreviewQueryContinueDrag))
    member x.PreviewQueryContinueDrag<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> QueryContinueDragEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewQueryContinueDrag))
    member x.PreviewQueryContinueDrag<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> QueryContinueDragEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewQueryContinueDrag))
    member x.PreviewQueryContinueDrag<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> QueryContinueDragEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewQueryContinueDrag))

    member x.PreviewQueryContinueDrag<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> QueryContinueDragEventHandler(h)),fn,binder.Control.PreviewQueryContinueDrag))
    member x.PreviewQueryContinueDrag<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> QueryContinueDragEventHandler(h)),fn,binder.Control.PreviewQueryContinueDrag))
    member x.PreviewQueryContinueDrag<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> QueryContinueDragEventHandler(h)),fn,binder.Control.PreviewQueryContinueDrag))
    



    [<CustomOperation("onTextInput")>]  
    member x.TextInput<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(TextCompositionEventHandler(fn),binder.Control.TextInput))
    member x.TextInput<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> TextCompositionEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.TextInput))
    member x.TextInput<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> TextCompositionEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.TextInput))
    member x.TextInput<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> TextCompositionEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.TextInput))

    member x.TextInput<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> TextCompositionEventHandler(h)),fn,binder.Control.TextInput))
    member x.TextInput<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> TextCompositionEventHandler(h)),fn,binder.Control.TextInput))
    member x.TextInput<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> TextCompositionEventHandler(h)),fn,binder.Control.TextInput))
    



    [<CustomOperation("onPreviewTouchUp")>]  
    member x.PreviewTouchUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.PreviewTouchUp))
    member x.PreviewTouchUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewTouchUp))
    member x.PreviewTouchUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewTouchUp))
    member x.PreviewTouchUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewTouchUp))

    member x.PreviewTouchUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchUp))
    member x.PreviewTouchUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchUp))
    member x.PreviewTouchUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.PreviewTouchUp))
    



    [<CustomOperation("onTouchUp")>]  
    member x.TouchUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.TouchUp))
    member x.TouchUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.TouchUp))
    member x.TouchUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.TouchUp))
    member x.TouchUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.TouchUp))

    member x.TouchUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchUp))
    member x.TouchUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchUp))
    member x.TouchUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchUp))
    



    [<CustomOperation("onLostTouchCapture")>]  
    member x.LostTouchCapture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.LostTouchCapture))
    member x.LostTouchCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.LostTouchCapture))
    member x.LostTouchCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.LostTouchCapture))
    member x.LostTouchCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.LostTouchCapture))

    member x.LostTouchCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.LostTouchCapture))
    member x.LostTouchCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.LostTouchCapture))
    member x.LostTouchCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.LostTouchCapture))
    



    [<CustomOperation("onPreviewTextInput")>]  
    member x.PreviewTextInput<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(TextCompositionEventHandler(fn),binder.Control.PreviewTextInput))
    member x.PreviewTextInput<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> TextCompositionEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewTextInput))
    member x.PreviewTextInput<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> TextCompositionEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewTextInput))
    member x.PreviewTextInput<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> TextCompositionEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewTextInput))

    member x.PreviewTextInput<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> TextCompositionEventHandler(h)),fn,binder.Control.PreviewTextInput))
    member x.PreviewTextInput<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> TextCompositionEventHandler(h)),fn,binder.Control.PreviewTextInput))
    member x.PreviewTextInput<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> TextCompositionEventHandler(h)),fn,binder.Control.PreviewTextInput))
    



    [<CustomOperation("onManipulationInertiaStarting")>]  
    member x.ManipulationInertiaStarting<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<ManipulationInertiaStartingEventArgs>(fn),binder.Control.ManipulationInertiaStarting))
    member x.ManipulationInertiaStarting<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<ManipulationInertiaStartingEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.ManipulationInertiaStarting))
    member x.ManipulationInertiaStarting<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<ManipulationInertiaStartingEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ManipulationInertiaStarting))
    member x.ManipulationInertiaStarting<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<ManipulationInertiaStartingEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ManipulationInertiaStarting))

    member x.ManipulationInertiaStarting<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<ManipulationInertiaStartingEventArgs>(h)),fn,binder.Control.ManipulationInertiaStarting))
    member x.ManipulationInertiaStarting<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<ManipulationInertiaStartingEventArgs>(h)),fn,binder.Control.ManipulationInertiaStarting))
    member x.ManipulationInertiaStarting<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<ManipulationInertiaStartingEventArgs>(h)),fn,binder.Control.ManipulationInertiaStarting))
    



    [<CustomOperation("onManipulationDelta")>]  
    member x.ManipulationDelta<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<ManipulationDeltaEventArgs>(fn),binder.Control.ManipulationDelta))
    member x.ManipulationDelta<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<ManipulationDeltaEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.ManipulationDelta))
    member x.ManipulationDelta<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<ManipulationDeltaEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ManipulationDelta))
    member x.ManipulationDelta<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<ManipulationDeltaEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ManipulationDelta))

    member x.ManipulationDelta<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<ManipulationDeltaEventArgs>(h)),fn,binder.Control.ManipulationDelta))
    member x.ManipulationDelta<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<ManipulationDeltaEventArgs>(h)),fn,binder.Control.ManipulationDelta))
    member x.ManipulationDelta<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<ManipulationDeltaEventArgs>(h)),fn,binder.Control.ManipulationDelta))
    



    [<CustomOperation("onManipulationStarted")>]  
    member x.ManipulationStarted<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<ManipulationStartedEventArgs>(fn),binder.Control.ManipulationStarted))
    member x.ManipulationStarted<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<ManipulationStartedEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.ManipulationStarted))
    member x.ManipulationStarted<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<ManipulationStartedEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ManipulationStarted))
    member x.ManipulationStarted<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<ManipulationStartedEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ManipulationStarted))

    member x.ManipulationStarted<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<ManipulationStartedEventArgs>(h)),fn,binder.Control.ManipulationStarted))
    member x.ManipulationStarted<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<ManipulationStartedEventArgs>(h)),fn,binder.Control.ManipulationStarted))
    member x.ManipulationStarted<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<ManipulationStartedEventArgs>(h)),fn,binder.Control.ManipulationStarted))
    



    [<CustomOperation("onManipulationStarting")>]  
    member x.ManipulationStarting<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<ManipulationStartingEventArgs>(fn),binder.Control.ManipulationStarting))
    member x.ManipulationStarting<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<ManipulationStartingEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.ManipulationStarting))
    member x.ManipulationStarting<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<ManipulationStartingEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ManipulationStarting))
    member x.ManipulationStarting<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<ManipulationStartingEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ManipulationStarting))

    member x.ManipulationStarting<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<ManipulationStartingEventArgs>(h)),fn,binder.Control.ManipulationStarting))
    member x.ManipulationStarting<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<ManipulationStartingEventArgs>(h)),fn,binder.Control.ManipulationStarting))
    member x.ManipulationStarting<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<ManipulationStartingEventArgs>(h)),fn,binder.Control.ManipulationStarting))
    



    [<CustomOperation("onLostFocus")>]  
    member x.LostFocus<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.LostFocus))
    member x.LostFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.LostFocus))
    member x.LostFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.LostFocus))
    member x.LostFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.LostFocus))

    member x.LostFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.LostFocus))
    member x.LostFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.LostFocus))
    member x.LostFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.LostFocus))
    



    [<CustomOperation("onGotTouchCapture")>]  
    member x.GotTouchCapture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.GotTouchCapture))
    member x.GotTouchCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.GotTouchCapture))
    member x.GotTouchCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.GotTouchCapture))
    member x.GotTouchCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.GotTouchCapture))

    member x.GotTouchCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.GotTouchCapture))
    member x.GotTouchCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.GotTouchCapture))
    member x.GotTouchCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.GotTouchCapture))
    



    [<CustomOperation("onGotFocus")>]  
    member x.GotFocus<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.GotFocus))
    member x.GotFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.GotFocus))
    member x.GotFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.GotFocus))
    member x.GotFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.GotFocus))

    member x.GotFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.GotFocus))
    member x.GotFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.GotFocus))
    member x.GotFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.GotFocus))
    



    [<CustomOperation("onTouchLeave")>]  
    member x.TouchLeave<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.TouchLeave))
    member x.TouchLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.TouchLeave))
    member x.TouchLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.TouchLeave))
    member x.TouchLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.TouchLeave))

    member x.TouchLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchLeave))
    member x.TouchLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchLeave))
    member x.TouchLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchLeave))
    



    [<CustomOperation("onTouchEnter")>]  
    member x.TouchEnter<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<TouchEventArgs>(fn),binder.Control.TouchEnter))
    member x.TouchEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<TouchEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.TouchEnter))
    member x.TouchEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.TouchEnter))
    member x.TouchEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<TouchEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.TouchEnter))

    member x.TouchEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchEnter))
    member x.TouchEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchEnter))
    member x.TouchEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<TouchEventArgs>(h)),fn,binder.Control.TouchEnter))
    



    [<CustomOperation("onLostKeyboardFocus")>]  
    member x.LostKeyboardFocus<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyboardFocusChangedEventHandler(fn),binder.Control.LostKeyboardFocus))
    member x.LostKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyboardFocusChangedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.LostKeyboardFocus))
    member x.LostKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.LostKeyboardFocus))
    member x.LostKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.LostKeyboardFocus))

    member x.LostKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.LostKeyboardFocus))
    member x.LostKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.LostKeyboardFocus))
    member x.LostKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.LostKeyboardFocus))
    



    [<CustomOperation("onPreviewLostKeyboardFocus")>]  
    member x.PreviewLostKeyboardFocus<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyboardFocusChangedEventHandler(fn),binder.Control.PreviewLostKeyboardFocus))
    member x.PreviewLostKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyboardFocusChangedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewLostKeyboardFocus))
    member x.PreviewLostKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewLostKeyboardFocus))
    member x.PreviewLostKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewLostKeyboardFocus))

    member x.PreviewLostKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.PreviewLostKeyboardFocus))
    member x.PreviewLostKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.PreviewLostKeyboardFocus))
    member x.PreviewLostKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.PreviewLostKeyboardFocus))
    



    [<CustomOperation("onGotKeyboardFocus")>]  
    member x.GotKeyboardFocus<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyboardFocusChangedEventHandler(fn),binder.Control.GotKeyboardFocus))
    member x.GotKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyboardFocusChangedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.GotKeyboardFocus))
    member x.GotKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.GotKeyboardFocus))
    member x.GotKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.GotKeyboardFocus))

    member x.GotKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.GotKeyboardFocus))
    member x.GotKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.GotKeyboardFocus))
    member x.GotKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.GotKeyboardFocus))
    



    [<CustomOperation("onPreviewStylusMove")>]  
    member x.PreviewStylusMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.PreviewStylusMove))
    member x.PreviewStylusMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusMove))
    member x.PreviewStylusMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusMove))
    member x.PreviewStylusMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusMove))

    member x.PreviewStylusMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusMove))
    member x.PreviewStylusMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusMove))
    member x.PreviewStylusMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusMove))
    



    [<CustomOperation("onStylusMove")>]  
    member x.StylusMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.StylusMove))
    member x.StylusMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusMove))
    member x.StylusMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusMove))
    member x.StylusMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusMove))

    member x.StylusMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusMove))
    member x.StylusMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusMove))
    member x.StylusMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusMove))
    



    [<CustomOperation("onPreviewStylusInAirMove")>]  
    member x.PreviewStylusInAirMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.PreviewStylusInAirMove))
    member x.PreviewStylusInAirMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusInAirMove))
    member x.PreviewStylusInAirMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusInAirMove))
    member x.PreviewStylusInAirMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusInAirMove))

    member x.PreviewStylusInAirMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusInAirMove))
    member x.PreviewStylusInAirMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusInAirMove))
    member x.PreviewStylusInAirMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusInAirMove))
    



    [<CustomOperation("onStylusInAirMove")>]  
    member x.StylusInAirMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.StylusInAirMove))
    member x.StylusInAirMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusInAirMove))
    member x.StylusInAirMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusInAirMove))
    member x.StylusInAirMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusInAirMove))

    member x.StylusInAirMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusInAirMove))
    member x.StylusInAirMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusInAirMove))
    member x.StylusInAirMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusInAirMove))
    



    [<CustomOperation("onStylusEnter")>]  
    member x.StylusEnter<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.StylusEnter))
    member x.StylusEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusEnter))
    member x.StylusEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusEnter))
    member x.StylusEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusEnter))

    member x.StylusEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusEnter))
    member x.StylusEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusEnter))
    member x.StylusEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusEnter))
    



    [<CustomOperation("onStylusLeave")>]  
    member x.StylusLeave<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.StylusLeave))
    member x.StylusLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusLeave))
    member x.StylusLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusLeave))
    member x.StylusLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusLeave))

    member x.StylusLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusLeave))
    member x.StylusLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusLeave))
    member x.StylusLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusLeave))
    



    [<CustomOperation("onPreviewStylusInRange")>]  
    member x.PreviewStylusInRange<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.PreviewStylusInRange))
    member x.PreviewStylusInRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusInRange))
    member x.PreviewStylusInRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusInRange))
    member x.PreviewStylusInRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusInRange))

    member x.PreviewStylusInRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusInRange))
    member x.PreviewStylusInRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusInRange))
    member x.PreviewStylusInRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusInRange))
    



    [<CustomOperation("onStylusInRange")>]  
    member x.StylusInRange<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.StylusInRange))
    member x.StylusInRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusInRange))
    member x.StylusInRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusInRange))
    member x.StylusInRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusInRange))

    member x.StylusInRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusInRange))
    member x.StylusInRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusInRange))
    member x.StylusInRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusInRange))
    



    [<CustomOperation("onPreviewStylusOutOfRange")>]  
    member x.PreviewStylusOutOfRange<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.PreviewStylusOutOfRange))
    member x.PreviewStylusOutOfRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusOutOfRange))
    member x.PreviewStylusOutOfRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusOutOfRange))
    member x.PreviewStylusOutOfRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusOutOfRange))

    member x.PreviewStylusOutOfRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusOutOfRange))
    member x.PreviewStylusOutOfRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusOutOfRange))
    member x.PreviewStylusOutOfRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusOutOfRange))
    



    [<CustomOperation("onStylusOutOfRange")>]  
    member x.StylusOutOfRange<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.StylusOutOfRange))
    member x.StylusOutOfRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusOutOfRange))
    member x.StylusOutOfRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusOutOfRange))
    member x.StylusOutOfRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusOutOfRange))

    member x.StylusOutOfRange<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusOutOfRange))
    member x.StylusOutOfRange<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusOutOfRange))
    member x.StylusOutOfRange<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusOutOfRange))
    



    [<CustomOperation("onPreviewStylusSystemGesture")>]  
    member x.PreviewStylusSystemGesture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusSystemGestureEventHandler(fn),binder.Control.PreviewStylusSystemGesture))
    member x.PreviewStylusSystemGesture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusSystemGestureEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusSystemGesture))
    member x.PreviewStylusSystemGesture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusSystemGestureEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusSystemGesture))
    member x.PreviewStylusSystemGesture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusSystemGestureEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusSystemGesture))

    member x.PreviewStylusSystemGesture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusSystemGestureEventHandler(h)),fn,binder.Control.PreviewStylusSystemGesture))
    member x.PreviewStylusSystemGesture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusSystemGestureEventHandler(h)),fn,binder.Control.PreviewStylusSystemGesture))
    member x.PreviewStylusSystemGesture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusSystemGestureEventHandler(h)),fn,binder.Control.PreviewStylusSystemGesture))
    



    [<CustomOperation("onStylusSystemGesture")>]  
    member x.StylusSystemGesture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusSystemGestureEventHandler(fn),binder.Control.StylusSystemGesture))
    member x.StylusSystemGesture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusSystemGestureEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusSystemGesture))
    member x.StylusSystemGesture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusSystemGestureEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusSystemGesture))
    member x.StylusSystemGesture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusSystemGestureEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusSystemGesture))

    member x.StylusSystemGesture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusSystemGestureEventHandler(h)),fn,binder.Control.StylusSystemGesture))
    member x.StylusSystemGesture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusSystemGestureEventHandler(h)),fn,binder.Control.StylusSystemGesture))
    member x.StylusSystemGesture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusSystemGestureEventHandler(h)),fn,binder.Control.StylusSystemGesture))
    



    [<CustomOperation("onGotStylusCapture")>]  
    member x.GotStylusCapture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.GotStylusCapture))
    member x.GotStylusCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.GotStylusCapture))
    member x.GotStylusCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.GotStylusCapture))
    member x.GotStylusCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.GotStylusCapture))

    member x.GotStylusCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.GotStylusCapture))
    member x.GotStylusCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.GotStylusCapture))
    member x.GotStylusCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.GotStylusCapture))
    



    [<CustomOperation("onLostStylusCapture")>]  
    member x.LostStylusCapture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.LostStylusCapture))
    member x.LostStylusCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.LostStylusCapture))
    member x.LostStylusCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.LostStylusCapture))
    member x.LostStylusCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.LostStylusCapture))

    member x.LostStylusCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.LostStylusCapture))
    member x.LostStylusCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.LostStylusCapture))
    member x.LostStylusCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.LostStylusCapture))
    



    [<CustomOperation("onStylusButtonDown")>]  
    member x.StylusButtonDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusButtonEventHandler(fn),binder.Control.StylusButtonDown))
    member x.StylusButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusButtonDown))
    member x.StylusButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusButtonDown))
    member x.StylusButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusButtonDown))

    member x.StylusButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.StylusButtonDown))
    member x.StylusButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.StylusButtonDown))
    member x.StylusButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.StylusButtonDown))
    



    [<CustomOperation("onStylusButtonUp")>]  
    member x.StylusButtonUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusButtonEventHandler(fn),binder.Control.StylusButtonUp))
    member x.StylusButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusButtonUp))
    member x.StylusButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusButtonUp))
    member x.StylusButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusButtonUp))

    member x.StylusButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.StylusButtonUp))
    member x.StylusButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.StylusButtonUp))
    member x.StylusButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.StylusButtonUp))
    



    [<CustomOperation("onPreviewStylusButtonDown")>]  
    member x.PreviewStylusButtonDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusButtonEventHandler(fn),binder.Control.PreviewStylusButtonDown))
    member x.PreviewStylusButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusButtonDown))
    member x.PreviewStylusButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusButtonDown))
    member x.PreviewStylusButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusButtonDown))

    member x.PreviewStylusButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.PreviewStylusButtonDown))
    member x.PreviewStylusButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.PreviewStylusButtonDown))
    member x.PreviewStylusButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.PreviewStylusButtonDown))
    



    [<CustomOperation("onPreviewStylusButtonUp")>]  
    member x.PreviewStylusButtonUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusButtonEventHandler(fn),binder.Control.PreviewStylusButtonUp))
    member x.PreviewStylusButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusButtonUp))
    member x.PreviewStylusButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusButtonUp))
    member x.PreviewStylusButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusButtonUp))

    member x.PreviewStylusButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.PreviewStylusButtonUp))
    member x.PreviewStylusButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.PreviewStylusButtonUp))
    member x.PreviewStylusButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusButtonEventHandler(h)),fn,binder.Control.PreviewStylusButtonUp))
    



    [<CustomOperation("onPreviewKeyDown")>]  
    member x.PreviewKeyDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyEventHandler(fn),binder.Control.PreviewKeyDown))
    member x.PreviewKeyDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewKeyDown))
    member x.PreviewKeyDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewKeyDown))
    member x.PreviewKeyDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewKeyDown))

    member x.PreviewKeyDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyEventHandler(h)),fn,binder.Control.PreviewKeyDown))
    member x.PreviewKeyDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyEventHandler(h)),fn,binder.Control.PreviewKeyDown))
    member x.PreviewKeyDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyEventHandler(h)),fn,binder.Control.PreviewKeyDown))
    



    [<CustomOperation("onKeyDown")>]  
    member x.KeyDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyEventHandler(fn),binder.Control.KeyDown))
    member x.KeyDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.KeyDown))
    member x.KeyDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.KeyDown))
    member x.KeyDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.KeyDown))

    member x.KeyDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyEventHandler(h)),fn,binder.Control.KeyDown))
    member x.KeyDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyEventHandler(h)),fn,binder.Control.KeyDown))
    member x.KeyDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyEventHandler(h)),fn,binder.Control.KeyDown))
    



    [<CustomOperation("onPreviewKeyUp")>]  
    member x.PreviewKeyUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyEventHandler(fn),binder.Control.PreviewKeyUp))
    member x.PreviewKeyUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewKeyUp))
    member x.PreviewKeyUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewKeyUp))
    member x.PreviewKeyUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewKeyUp))

    member x.PreviewKeyUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyEventHandler(h)),fn,binder.Control.PreviewKeyUp))
    member x.PreviewKeyUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyEventHandler(h)),fn,binder.Control.PreviewKeyUp))
    member x.PreviewKeyUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyEventHandler(h)),fn,binder.Control.PreviewKeyUp))
    



    [<CustomOperation("onStylusUp")>]  
    member x.StylusUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.StylusUp))
    member x.StylusUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusUp))
    member x.StylusUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusUp))
    member x.StylusUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusUp))

    member x.StylusUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusUp))
    member x.StylusUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusUp))
    member x.StylusUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.StylusUp))
    



    [<CustomOperation("onPreviewGotKeyboardFocus")>]  
    member x.PreviewGotKeyboardFocus<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(KeyboardFocusChangedEventHandler(fn),binder.Control.PreviewGotKeyboardFocus))
    member x.PreviewGotKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> KeyboardFocusChangedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewGotKeyboardFocus))
    member x.PreviewGotKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewGotKeyboardFocus))
    member x.PreviewGotKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> KeyboardFocusChangedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewGotKeyboardFocus))

    member x.PreviewGotKeyboardFocus<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.PreviewGotKeyboardFocus))
    member x.PreviewGotKeyboardFocus<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.PreviewGotKeyboardFocus))
    member x.PreviewGotKeyboardFocus<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> KeyboardFocusChangedEventHandler(h)),fn,binder.Control.PreviewGotKeyboardFocus))
    



    [<CustomOperation("onPreviewStylusUp")>]  
    member x.PreviewStylusUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusEventHandler(fn),binder.Control.PreviewStylusUp))
    member x.PreviewStylusUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusUp))
    member x.PreviewStylusUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusUp))
    member x.PreviewStylusUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusUp))

    member x.PreviewStylusUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusUp))
    member x.PreviewStylusUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusUp))
    member x.PreviewStylusUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusEventHandler(h)),fn,binder.Control.PreviewStylusUp))
    



    [<CustomOperation("onPreviewStylusDown")>]  
    member x.PreviewStylusDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusDownEventHandler(fn),binder.Control.PreviewStylusDown))
    member x.PreviewStylusDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusDownEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewStylusDown))
    member x.PreviewStylusDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusDownEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewStylusDown))
    member x.PreviewStylusDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusDownEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewStylusDown))

    member x.PreviewStylusDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusDownEventHandler(h)),fn,binder.Control.PreviewStylusDown))
    member x.PreviewStylusDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusDownEventHandler(h)),fn,binder.Control.PreviewStylusDown))
    member x.PreviewStylusDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusDownEventHandler(h)),fn,binder.Control.PreviewStylusDown))
    



    [<CustomOperation("onPreviewMouseDown")>]  
    member x.PreviewMouseDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.PreviewMouseDown))
    member x.PreviewMouseDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseDown))
    member x.PreviewMouseDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseDown))
    member x.PreviewMouseDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseDown))

    member x.PreviewMouseDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseDown))
    member x.PreviewMouseDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseDown))
    member x.PreviewMouseDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseDown))
    



    [<CustomOperation("onMouseDown")>]  
    member x.MouseDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.MouseDown))
    member x.MouseDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseDown))
    member x.MouseDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseDown))
    member x.MouseDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseDown))

    member x.MouseDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseDown))
    member x.MouseDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseDown))
    member x.MouseDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseDown))
    



    [<CustomOperation("onPreviewMouseUp")>]  
    member x.PreviewMouseUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.PreviewMouseUp))
    member x.PreviewMouseUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseUp))
    member x.PreviewMouseUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseUp))
    member x.PreviewMouseUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseUp))

    member x.PreviewMouseUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseUp))
    member x.PreviewMouseUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseUp))
    member x.PreviewMouseUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseUp))
    



    [<CustomOperation("onMouseUp")>]  
    member x.MouseUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.MouseUp))
    member x.MouseUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseUp))
    member x.MouseUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseUp))
    member x.MouseUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseUp))

    member x.MouseUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseUp))
    member x.MouseUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseUp))
    member x.MouseUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseUp))
    



    [<CustomOperation("onPreviewMouseLeftButtonDown")>]  
    member x.PreviewMouseLeftButtonDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.PreviewMouseLeftButtonDown))
    member x.PreviewMouseLeftButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseLeftButtonDown))
    member x.PreviewMouseLeftButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseLeftButtonDown))
    member x.PreviewMouseLeftButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseLeftButtonDown))

    member x.PreviewMouseLeftButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseLeftButtonDown))
    member x.PreviewMouseLeftButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseLeftButtonDown))
    member x.PreviewMouseLeftButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseLeftButtonDown))
    



    [<CustomOperation("onMouseLeftButtonDown")>]  
    member x.MouseLeftButtonDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.MouseLeftButtonDown))
    member x.MouseLeftButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseLeftButtonDown))
    member x.MouseLeftButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseLeftButtonDown))
    member x.MouseLeftButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseLeftButtonDown))

    member x.MouseLeftButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseLeftButtonDown))
    member x.MouseLeftButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseLeftButtonDown))
    member x.MouseLeftButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseLeftButtonDown))
    



    [<CustomOperation("onPreviewMouseLeftButtonUp")>]  
    member x.PreviewMouseLeftButtonUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.PreviewMouseLeftButtonUp))
    member x.PreviewMouseLeftButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseLeftButtonUp))
    member x.PreviewMouseLeftButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseLeftButtonUp))
    member x.PreviewMouseLeftButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseLeftButtonUp))

    member x.PreviewMouseLeftButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseLeftButtonUp))
    member x.PreviewMouseLeftButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseLeftButtonUp))
    member x.PreviewMouseLeftButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseLeftButtonUp))
    



    [<CustomOperation("onMouseLeftButtonUp")>]  
    member x.MouseLeftButtonUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.MouseLeftButtonUp))
    member x.MouseLeftButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseLeftButtonUp))
    member x.MouseLeftButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseLeftButtonUp))
    member x.MouseLeftButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseLeftButtonUp))

    member x.MouseLeftButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseLeftButtonUp))
    member x.MouseLeftButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseLeftButtonUp))
    member x.MouseLeftButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseLeftButtonUp))
    



    [<CustomOperation("onPreviewMouseRightButtonDown")>]  
    member x.PreviewMouseRightButtonDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.PreviewMouseRightButtonDown))
    member x.PreviewMouseRightButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseRightButtonDown))
    member x.PreviewMouseRightButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseRightButtonDown))
    member x.PreviewMouseRightButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseRightButtonDown))

    member x.PreviewMouseRightButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseRightButtonDown))
    member x.PreviewMouseRightButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseRightButtonDown))
    member x.PreviewMouseRightButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseRightButtonDown))
    



    [<CustomOperation("onMouseRightButtonDown")>]  
    member x.MouseRightButtonDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.MouseRightButtonDown))
    member x.MouseRightButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseRightButtonDown))
    member x.MouseRightButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseRightButtonDown))
    member x.MouseRightButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseRightButtonDown))

    member x.MouseRightButtonDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseRightButtonDown))
    member x.MouseRightButtonDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseRightButtonDown))
    member x.MouseRightButtonDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseRightButtonDown))
    



    [<CustomOperation("onPreviewMouseRightButtonUp")>]  
    member x.PreviewMouseRightButtonUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.PreviewMouseRightButtonUp))
    member x.PreviewMouseRightButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseRightButtonUp))
    member x.PreviewMouseRightButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseRightButtonUp))
    member x.PreviewMouseRightButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseRightButtonUp))

    member x.PreviewMouseRightButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseRightButtonUp))
    member x.PreviewMouseRightButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseRightButtonUp))
    member x.PreviewMouseRightButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseRightButtonUp))
    



    [<CustomOperation("onMouseRightButtonUp")>]  
    member x.MouseRightButtonUp<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.MouseRightButtonUp))
    member x.MouseRightButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseRightButtonUp))
    member x.MouseRightButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseRightButtonUp))
    member x.MouseRightButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseRightButtonUp))

    member x.MouseRightButtonUp<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseRightButtonUp))
    member x.MouseRightButtonUp<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseRightButtonUp))
    member x.MouseRightButtonUp<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseRightButtonUp))
    



    [<CustomOperation("onPreviewMouseMove")>]  
    member x.PreviewMouseMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseEventHandler(fn),binder.Control.PreviewMouseMove))
    member x.PreviewMouseMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseMove))
    member x.PreviewMouseMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseMove))
    member x.PreviewMouseMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseMove))

    member x.PreviewMouseMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseEventHandler(h)),fn,binder.Control.PreviewMouseMove))
    member x.PreviewMouseMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseEventHandler(h)),fn,binder.Control.PreviewMouseMove))
    member x.PreviewMouseMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseEventHandler(h)),fn,binder.Control.PreviewMouseMove))
    



    [<CustomOperation("onMouseMove")>]  
    member x.MouseMove<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseEventHandler(fn),binder.Control.MouseMove))
    member x.MouseMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseMove))
    member x.MouseMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseMove))
    member x.MouseMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseMove))

    member x.MouseMove<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseMove))
    member x.MouseMove<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseMove))
    member x.MouseMove<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseMove))
    



    [<CustomOperation("onPreviewMouseWheel")>]  
    member x.PreviewMouseWheel<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseWheelEventHandler(fn),binder.Control.PreviewMouseWheel))
    member x.PreviewMouseWheel<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseWheelEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseWheel))
    member x.PreviewMouseWheel<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseWheelEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseWheel))
    member x.PreviewMouseWheel<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseWheelEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseWheel))

    member x.PreviewMouseWheel<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseWheelEventHandler(h)),fn,binder.Control.PreviewMouseWheel))
    member x.PreviewMouseWheel<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseWheelEventHandler(h)),fn,binder.Control.PreviewMouseWheel))
    member x.PreviewMouseWheel<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseWheelEventHandler(h)),fn,binder.Control.PreviewMouseWheel))
    



    [<CustomOperation("onMouseWheel")>]  
    member x.MouseWheel<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseWheelEventHandler(fn),binder.Control.MouseWheel))
    member x.MouseWheel<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseWheelEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseWheel))
    member x.MouseWheel<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseWheelEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseWheel))
    member x.MouseWheel<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseWheelEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseWheel))

    member x.MouseWheel<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseWheelEventHandler(h)),fn,binder.Control.MouseWheel))
    member x.MouseWheel<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseWheelEventHandler(h)),fn,binder.Control.MouseWheel))
    member x.MouseWheel<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseWheelEventHandler(h)),fn,binder.Control.MouseWheel))
    



    [<CustomOperation("onMouseEnter")>]  
    member x.MouseEnter<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseEventHandler(fn),binder.Control.MouseEnter))
    member x.MouseEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseEnter))
    member x.MouseEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseEnter))
    member x.MouseEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseEnter))

    member x.MouseEnter<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseEnter))
    member x.MouseEnter<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseEnter))
    member x.MouseEnter<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseEnter))
    



    [<CustomOperation("onMouseLeave")>]  
    member x.MouseLeave<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseEventHandler(fn),binder.Control.MouseLeave))
    member x.MouseLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseLeave))
    member x.MouseLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseLeave))
    member x.MouseLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseLeave))

    member x.MouseLeave<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseLeave))
    member x.MouseLeave<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseLeave))
    member x.MouseLeave<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseEventHandler(h)),fn,binder.Control.MouseLeave))
    



    [<CustomOperation("onGotMouseCapture")>]  
    member x.GotMouseCapture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseEventHandler(fn),binder.Control.GotMouseCapture))
    member x.GotMouseCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.GotMouseCapture))
    member x.GotMouseCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.GotMouseCapture))
    member x.GotMouseCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.GotMouseCapture))

    member x.GotMouseCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseEventHandler(h)),fn,binder.Control.GotMouseCapture))
    member x.GotMouseCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseEventHandler(h)),fn,binder.Control.GotMouseCapture))
    member x.GotMouseCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseEventHandler(h)),fn,binder.Control.GotMouseCapture))
    



    [<CustomOperation("onLostMouseCapture")>]  
    member x.LostMouseCapture<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseEventHandler(fn),binder.Control.LostMouseCapture))
    member x.LostMouseCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.LostMouseCapture))
    member x.LostMouseCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.LostMouseCapture))
    member x.LostMouseCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.LostMouseCapture))

    member x.LostMouseCapture<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseEventHandler(h)),fn,binder.Control.LostMouseCapture))
    member x.LostMouseCapture<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseEventHandler(h)),fn,binder.Control.LostMouseCapture))
    member x.LostMouseCapture<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseEventHandler(h)),fn,binder.Control.LostMouseCapture))
    



    [<CustomOperation("onQueryCursor")>]  
    member x.QueryCursor<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(QueryCursorEventHandler(fn),binder.Control.QueryCursor))
    member x.QueryCursor<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> QueryCursorEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.QueryCursor))
    member x.QueryCursor<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> QueryCursorEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.QueryCursor))
    member x.QueryCursor<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> QueryCursorEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.QueryCursor))

    member x.QueryCursor<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> QueryCursorEventHandler(h)),fn,binder.Control.QueryCursor))
    member x.QueryCursor<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> QueryCursorEventHandler(h)),fn,binder.Control.QueryCursor))
    member x.QueryCursor<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> QueryCursorEventHandler(h)),fn,binder.Control.QueryCursor))
    



    [<CustomOperation("onStylusDown")>]  
    member x.StylusDown<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(StylusDownEventHandler(fn),binder.Control.StylusDown))
    member x.StylusDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> StylusDownEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.StylusDown))
    member x.StylusDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> StylusDownEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.StylusDown))
    member x.StylusDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> StylusDownEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.StylusDown))

    member x.StylusDown<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> StylusDownEventHandler(h)),fn,binder.Control.StylusDown))
    member x.StylusDown<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> StylusDownEventHandler(h)),fn,binder.Control.StylusDown))
    member x.StylusDown<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> StylusDownEventHandler(h)),fn,binder.Control.StylusDown))
    



    [<CustomOperation("onManipulationCompleted")>]  
    member x.ManipulationCompleted<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<ManipulationCompletedEventArgs>(fn),binder.Control.ManipulationCompleted))
    member x.ManipulationCompleted<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<ManipulationCompletedEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.ManipulationCompleted))
    member x.ManipulationCompleted<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<ManipulationCompletedEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ManipulationCompleted))
    member x.ManipulationCompleted<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<ManipulationCompletedEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ManipulationCompleted))

    member x.ManipulationCompleted<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<ManipulationCompletedEventArgs>(h)),fn,binder.Control.ManipulationCompleted))
    member x.ManipulationCompleted<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<ManipulationCompletedEventArgs>(h)),fn,binder.Control.ManipulationCompleted))
    member x.ManipulationCompleted<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<ManipulationCompletedEventArgs>(h)),fn,binder.Control.ManipulationCompleted))
    



    [<CustomOperation("onManipulationBoundaryFeedback")>]  
    member x.ManipulationBoundaryFeedback<'C when 'C :> UIElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<ManipulationBoundaryFeedbackEventArgs>(fn),binder.Control.ManipulationBoundaryFeedback))
    member x.ManipulationBoundaryFeedback<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<ManipulationBoundaryFeedbackEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.ManipulationBoundaryFeedback))
    member x.ManipulationBoundaryFeedback<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<ManipulationBoundaryFeedbackEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ManipulationBoundaryFeedback))
    member x.ManipulationBoundaryFeedback<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<ManipulationBoundaryFeedbackEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ManipulationBoundaryFeedback))

    member x.ManipulationBoundaryFeedback<'C,'T when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<ManipulationBoundaryFeedbackEventArgs>(h)),fn,binder.Control.ManipulationBoundaryFeedback))
    member x.ManipulationBoundaryFeedback<'C,'T1,'T2 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<ManipulationBoundaryFeedbackEventArgs>(h)),fn,binder.Control.ManipulationBoundaryFeedback))
    member x.ManipulationBoundaryFeedback<'C,'T1,'T2,'T3 when 'C :> UIElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<ManipulationBoundaryFeedbackEventArgs>(h)),fn,binder.Control.ManipulationBoundaryFeedback))
    


type FrameworkElementBuilder() =

    inherit UIElementBuilder()
                

    [<CustomOperation("row")>]
    member __.Row<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:int) = binder.Control.SetValue(Grid.RowProperty,v) ; binder

    [<CustomOperation("column")>]
    member __.Column<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:int) = binder.Control.SetValue(Grid.ColumnProperty,v) ; binder
             

    [<CustomOperation("layoutTransform")>]
    member __.LayoutTransform<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:Transform) = binder.Control.LayoutTransform <- v ; binder
    
    member __.LayoutTransform<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.LayoutTransformProperty)
    member __.LayoutTransform<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.LayoutTransformProperty)
    member __.LayoutTransform<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.LayoutTransformProperty)
    member __.LayoutTransform<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.LayoutTransformProperty)
    

    [<CustomOperation("width")>]
    member __.Width<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:double) = binder.Control.Width <- v ; binder
    
    member __.Width<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.WidthProperty)
    member __.Width<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.WidthProperty)
    member __.Width<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.WidthProperty)
    member __.Width<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.WidthProperty)
    

    [<CustomOperation("minWidth")>]
    member __.MinWidth<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:double) = binder.Control.MinWidth <- v ; binder
    
    member __.MinWidth<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.MinWidthProperty)
    member __.MinWidth<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.MinWidthProperty)
    member __.MinWidth<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.MinWidthProperty)
    member __.MinWidth<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.MinWidthProperty)
    

    [<CustomOperation("maxHeight")>]
    member __.MaxHeight<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:double) = binder.Control.MaxHeight <- v ; binder
    
    member __.MaxHeight<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.MaxHeightProperty)
    member __.MaxHeight<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.MaxHeightProperty)
    member __.MaxHeight<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.MaxHeightProperty)
    member __.MaxHeight<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.MaxHeightProperty)
    

    [<CustomOperation("height")>]
    member __.Height<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:double) = binder.Control.Height <- v ; binder
    
    member __.Height<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.HeightProperty)
    member __.Height<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.HeightProperty)
    member __.Height<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.HeightProperty)
    member __.Height<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.HeightProperty)
    

    [<CustomOperation("minHeight")>]
    member __.MinHeight<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:double) = binder.Control.MinHeight <- v ; binder
    
    member __.MinHeight<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.MinHeightProperty)
    member __.MinHeight<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.MinHeightProperty)
    member __.MinHeight<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.MinHeightProperty)
    member __.MinHeight<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.MinHeightProperty)
    

    [<CustomOperation("actualHeight")>]
    member __.ActualHeight<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr FrameworkElement.ActualHeightProperty)  
    member __.ActualHeight<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap FrameworkElement.ActualHeightProperty)
    member __.ActualHeight<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap FrameworkElement.ActualHeightProperty)
    member __.ActualHeight<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap FrameworkElement.ActualHeightProperty)

    [<CustomOperation("maxWidth")>]
    member __.MaxWidth<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:double) = binder.Control.MaxWidth <- v ; binder
    
    member __.MaxWidth<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.MaxWidthProperty)
    member __.MaxWidth<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.MaxWidthProperty)
    member __.MaxWidth<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.MaxWidthProperty)
    member __.MaxWidth<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.MaxWidthProperty)
    

    [<CustomOperation("actualWidth")>]
    member __.ActualWidth<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr FrameworkElement.ActualWidthProperty)  
    member __.ActualWidth<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap FrameworkElement.ActualWidthProperty)
    member __.ActualWidth<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap FrameworkElement.ActualWidthProperty)
    member __.ActualWidth<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap FrameworkElement.ActualWidthProperty)

    [<CustomOperation("tag")>]
    member __.Tag<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:obj) = binder.Control.Tag <- v ; binder
    
    member __.Tag<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.TagProperty)
    member __.Tag<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.TagProperty)
    member __.Tag<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.TagProperty)
    member __.Tag<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.TagProperty)
    

    [<CustomOperation("name")>]
    member __.Name<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:string) = binder.Control.Name <- v ; binder
    
    member __.Name<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.NameProperty)
    member __.Name<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.NameProperty)
    member __.Name<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.NameProperty)
    member __.Name<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.NameProperty)
    

    [<CustomOperation("language")>]
    member __.Language<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:XmlLanguage) = binder.Control.Language <- v ; binder
    
    member __.Language<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.LanguageProperty)
    member __.Language<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.LanguageProperty)
    member __.Language<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.LanguageProperty)
    member __.Language<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.LanguageProperty)
    

    [<CustomOperation("bindingGroup")>]
    member __.BindingGroup<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:BindingGroup) = binder.Control.BindingGroup <- v ; binder
    
    member __.BindingGroup<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.BindingGroupProperty)
    member __.BindingGroup<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.BindingGroupProperty)
    member __.BindingGroup<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.BindingGroupProperty)
    member __.BindingGroup<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.BindingGroupProperty)
    

    [<CustomOperation("dataContext")>]
    member __.DataContext<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:obj) = binder.Control.DataContext <- v ; binder
    
    member __.DataContext<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.DataContextProperty)
    member __.DataContext<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.DataContextProperty)
    member __.DataContext<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.DataContextProperty)
    member __.DataContext<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.DataContextProperty)
    

    [<CustomOperation("resources")>]
    member __.Resources<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:ResourceDictionary) = binder.Control.Resources <- v ; binder

    [<CustomOperation("useLayoutRounding")>]
    member __.UseLayoutRounding<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.UseLayoutRounding <- v ; binder
    
    member __.UseLayoutRounding<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.UseLayoutRoundingProperty)
    member __.UseLayoutRounding<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.UseLayoutRoundingProperty)
    member __.UseLayoutRounding<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.UseLayoutRoundingProperty)
    member __.UseLayoutRounding<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.UseLayoutRoundingProperty)
    

    [<CustomOperation("flowDirection")>]
    member __.FlowDirection<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:FlowDirection) = binder.Control.FlowDirection <- v ; binder
    
    member __.FlowDirection<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.FlowDirectionProperty)
    member __.FlowDirection<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.FlowDirectionProperty)
    member __.FlowDirection<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.FlowDirectionProperty)
    member __.FlowDirection<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.FlowDirectionProperty)
    

    [<CustomOperation("inputScope")>]
    member __.InputScope<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:InputScope) = binder.Control.InputScope <- v ; binder
    
    member __.InputScope<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.InputScopeProperty)
    member __.InputScope<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.InputScopeProperty)
    member __.InputScope<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.InputScopeProperty)
    member __.InputScope<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.InputScopeProperty)
    

    [<CustomOperation("margin")>]
    member __.Margin<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:Thickness) = binder.Control.Margin <- v ; binder
    
    member __.Margin<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.MarginProperty)
    member __.Margin<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.MarginProperty)
    member __.Margin<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.MarginProperty)
    member __.Margin<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.MarginProperty)
    

    [<CustomOperation("style")>]
    member __.Style<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:Style) = binder.Control.Style <- v ; binder
    
    member __.Style<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.StyleProperty)
    member __.Style<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.StyleProperty)
    member __.Style<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.StyleProperty)
    member __.Style<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.StyleProperty)
    

    [<CustomOperation("verticalAlignment")>]
    member __.VerticalAlignment<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:VerticalAlignment) = binder.Control.VerticalAlignment <- v ; binder
    
    member __.VerticalAlignment<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.VerticalAlignmentProperty)
    member __.VerticalAlignment<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.VerticalAlignmentProperty)
    member __.VerticalAlignment<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.VerticalAlignmentProperty)
    member __.VerticalAlignment<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.VerticalAlignmentProperty)
    

    [<CustomOperation("overridesDefaultStyle")>]
    member __.OverridesDefaultStyle<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.OverridesDefaultStyle <- v ; binder
    
    member __.OverridesDefaultStyle<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.OverridesDefaultStyleProperty)
    member __.OverridesDefaultStyle<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.OverridesDefaultStyleProperty)
    member __.OverridesDefaultStyle<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.OverridesDefaultStyleProperty)
    member __.OverridesDefaultStyle<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.OverridesDefaultStyleProperty)
    

    [<CustomOperation("horizontalAlignment")>]
    member __.HorizontalAlignment<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:HorizontalAlignment) = binder.Control.HorizontalAlignment <- v ; binder
    
    member __.HorizontalAlignment<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.HorizontalAlignmentProperty)
    member __.HorizontalAlignment<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.HorizontalAlignmentProperty)
    member __.HorizontalAlignment<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.HorizontalAlignmentProperty)
    member __.HorizontalAlignment<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.HorizontalAlignmentProperty)
    

    [<CustomOperation("contextMenu")>]
    member __.ContextMenu<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:ContextMenu) = binder.Control.ContextMenu <- v ; binder
    
    member __.ContextMenu<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.ContextMenuProperty)
    member __.ContextMenu<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.ContextMenuProperty)
    member __.ContextMenu<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.ContextMenuProperty)
    member __.ContextMenu<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.ContextMenuProperty)
    

    [<CustomOperation("toolTip")>]
    member __.ToolTip<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:obj) = binder.Control.ToolTip <- v ; binder
    
    member __.ToolTip<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.ToolTipProperty)
    member __.ToolTip<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.ToolTipProperty)
    member __.ToolTip<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.ToolTipProperty)
    member __.ToolTip<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.ToolTipProperty)
    

    [<CustomOperation("forceCursor")>]
    member __.ForceCursor<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:bool) = binder.Control.ForceCursor <- v ; binder
    
    member __.ForceCursor<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.ForceCursorProperty)
    member __.ForceCursor<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.ForceCursorProperty)
    member __.ForceCursor<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.ForceCursorProperty)
    member __.ForceCursor<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.ForceCursorProperty)
    

    [<CustomOperation("cursor")>]
    member __.Cursor<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:Cursor) = binder.Control.Cursor <- v ; binder
    
    member __.Cursor<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.CursorProperty)
    member __.Cursor<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.CursorProperty)
    member __.Cursor<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.CursorProperty)
    member __.Cursor<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.CursorProperty)
    

    [<CustomOperation("focusVisualStyle")>]
    member __.FocusVisualStyle<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,v:Style) = binder.Control.FocusVisualStyle <- v ; binder
    
    member __.FocusVisualStyle<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr FrameworkElement.FocusVisualStyleProperty)
    member __.FocusVisualStyle<'C,'TP,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap FrameworkElement.FocusVisualStyleProperty)
    member __.FocusVisualStyle<'C,'T1,'T2,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap FrameworkElement.FocusVisualStyleProperty)
    member __.FocusVisualStyle<'C,'T1,'T2,'T3,'TC when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap FrameworkElement.FocusVisualStyleProperty)
    

    [<CustomOperation("onToolTipClosing")>]  
    member x.ToolTipClosing<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(ToolTipEventHandler(fn),binder.Control.ToolTipClosing))
    member x.ToolTipClosing<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> ToolTipEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.ToolTipClosing))
    member x.ToolTipClosing<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> ToolTipEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ToolTipClosing))
    member x.ToolTipClosing<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> ToolTipEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ToolTipClosing))

    member x.ToolTipClosing<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> ToolTipEventHandler(h)),fn,binder.Control.ToolTipClosing))
    member x.ToolTipClosing<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> ToolTipEventHandler(h)),fn,binder.Control.ToolTipClosing))
    member x.ToolTipClosing<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> ToolTipEventHandler(h)),fn,binder.Control.ToolTipClosing))
    



    [<CustomOperation("onToolTipOpening")>]  
    member x.ToolTipOpening<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(ToolTipEventHandler(fn),binder.Control.ToolTipOpening))
    member x.ToolTipOpening<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> ToolTipEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.ToolTipOpening))
    member x.ToolTipOpening<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> ToolTipEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ToolTipOpening))
    member x.ToolTipOpening<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> ToolTipEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ToolTipOpening))

    member x.ToolTipOpening<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> ToolTipEventHandler(h)),fn,binder.Control.ToolTipOpening))
    member x.ToolTipOpening<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> ToolTipEventHandler(h)),fn,binder.Control.ToolTipOpening))
    member x.ToolTipOpening<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> ToolTipEventHandler(h)),fn,binder.Control.ToolTipOpening))
    



    [<CustomOperation("onUnloaded")>]  
    member x.Unloaded<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.Unloaded))
    member x.Unloaded<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.Unloaded))
    member x.Unloaded<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.Unloaded))
    member x.Unloaded<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.Unloaded))

    member x.Unloaded<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Unloaded))
    member x.Unloaded<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Unloaded))
    member x.Unloaded<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Unloaded))
    



    [<CustomOperation("onSizeChanged")>]  
    member x.SizeChanged<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(SizeChangedEventHandler(fn),binder.Control.SizeChanged))
    member x.SizeChanged<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> SizeChangedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.SizeChanged))
    member x.SizeChanged<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> SizeChangedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.SizeChanged))
    member x.SizeChanged<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> SizeChangedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.SizeChanged))

    member x.SizeChanged<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> SizeChangedEventHandler(h)),fn,binder.Control.SizeChanged))
    member x.SizeChanged<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> SizeChangedEventHandler(h)),fn,binder.Control.SizeChanged))
    member x.SizeChanged<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> SizeChangedEventHandler(h)),fn,binder.Control.SizeChanged))
    



    [<CustomOperation("onRequestBringIntoView")>]  
    member x.RequestBringIntoView<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RequestBringIntoViewEventHandler(fn),binder.Control.RequestBringIntoView))
    member x.RequestBringIntoView<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RequestBringIntoViewEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.RequestBringIntoView))
    member x.RequestBringIntoView<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RequestBringIntoViewEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.RequestBringIntoView))
    member x.RequestBringIntoView<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RequestBringIntoViewEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.RequestBringIntoView))

    member x.RequestBringIntoView<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RequestBringIntoViewEventHandler(h)),fn,binder.Control.RequestBringIntoView))
    member x.RequestBringIntoView<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RequestBringIntoViewEventHandler(h)),fn,binder.Control.RequestBringIntoView))
    member x.RequestBringIntoView<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RequestBringIntoViewEventHandler(h)),fn,binder.Control.RequestBringIntoView))
    



    [<CustomOperation("onLoaded")>]  
    member x.Loaded<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.Loaded))
    member x.Loaded<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.Loaded))
    member x.Loaded<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.Loaded))
    member x.Loaded<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.Loaded))

    member x.Loaded<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Loaded))
    member x.Loaded<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Loaded))
    member x.Loaded<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Loaded))
    



    [<CustomOperation("onContextMenuClosing")>]  
    member x.ContextMenuClosing<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(ContextMenuEventHandler(fn),binder.Control.ContextMenuClosing))
    member x.ContextMenuClosing<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> ContextMenuEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.ContextMenuClosing))
    member x.ContextMenuClosing<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> ContextMenuEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ContextMenuClosing))
    member x.ContextMenuClosing<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> ContextMenuEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ContextMenuClosing))

    member x.ContextMenuClosing<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> ContextMenuEventHandler(h)),fn,binder.Control.ContextMenuClosing))
    member x.ContextMenuClosing<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> ContextMenuEventHandler(h)),fn,binder.Control.ContextMenuClosing))
    member x.ContextMenuClosing<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> ContextMenuEventHandler(h)),fn,binder.Control.ContextMenuClosing))
    



    [<CustomOperation("onContextMenuOpening")>]  
    member x.ContextMenuOpening<'C when 'C :> FrameworkElement>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(ContextMenuEventHandler(fn),binder.Control.ContextMenuOpening))
    member x.ContextMenuOpening<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> ContextMenuEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.ContextMenuOpening))
    member x.ContextMenuOpening<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> ContextMenuEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ContextMenuOpening))
    member x.ContextMenuOpening<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> ContextMenuEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ContextMenuOpening))

    member x.ContextMenuOpening<'C,'T when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> ContextMenuEventHandler(h)),fn,binder.Control.ContextMenuOpening))
    member x.ContextMenuOpening<'C,'T1,'T2 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> ContextMenuEventHandler(h)),fn,binder.Control.ContextMenuOpening))
    member x.ContextMenuOpening<'C,'T1,'T2,'T3 when 'C :> FrameworkElement>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> ContextMenuEventHandler(h)),fn,binder.Control.ContextMenuOpening))
    


type ControlBuilder() =

    inherit FrameworkElementBuilder()
                

    [<CustomOperation("fontStyle")>]
    member __.FontStyle<'C when 'C :> Control>(binder:ControlBinder<'C>,v:FontStyle) = binder.Control.FontStyle <- v ; binder
    
    member __.FontStyle<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.FontStyleProperty)
    member __.FontStyle<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.FontStyleProperty)
    member __.FontStyle<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.FontStyleProperty)
    member __.FontStyle<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.FontStyleProperty)
    

    [<CustomOperation("fontStretch")>]
    member __.FontStretch<'C when 'C :> Control>(binder:ControlBinder<'C>,v:FontStretch) = binder.Control.FontStretch <- v ; binder
    
    member __.FontStretch<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.FontStretchProperty)
    member __.FontStretch<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.FontStretchProperty)
    member __.FontStretch<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.FontStretchProperty)
    member __.FontStretch<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.FontStretchProperty)
    

    [<CustomOperation("fontSize")>]
    member __.FontSize<'C when 'C :> Control>(binder:ControlBinder<'C>,v:double) = binder.Control.FontSize <- v ; binder
    
    member __.FontSize<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.FontSizeProperty)
    member __.FontSize<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.FontSizeProperty)
    member __.FontSize<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.FontSizeProperty)
    member __.FontSize<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.FontSizeProperty)
    

    [<CustomOperation("fontFamily")>]
    member __.FontFamily<'C when 'C :> Control>(binder:ControlBinder<'C>,v:FontFamily) = binder.Control.FontFamily <- v ; binder
    
    member __.FontFamily<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.FontFamilyProperty)
    member __.FontFamily<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.FontFamilyProperty)
    member __.FontFamily<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.FontFamilyProperty)
    member __.FontFamily<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.FontFamilyProperty)
    

    [<CustomOperation("foreground")>]
    member __.Foreground<'C when 'C :> Control>(binder:ControlBinder<'C>,v:Brush) = binder.Control.Foreground <- v ; binder
    
    member __.Foreground<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.ForegroundProperty)
    member __.Foreground<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.ForegroundProperty)
    member __.Foreground<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.ForegroundProperty)
    member __.Foreground<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.ForegroundProperty)
    

    [<CustomOperation("background")>]
    member __.Background<'C when 'C :> Control>(binder:ControlBinder<'C>,v:Brush) = binder.Control.Background <- v ; binder
    
    member __.Background<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.BackgroundProperty)
    member __.Background<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.BackgroundProperty)
    member __.Background<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.BackgroundProperty)
    member __.Background<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.BackgroundProperty)
    

    [<CustomOperation("borderThickness")>]
    member __.BorderThickness<'C when 'C :> Control>(binder:ControlBinder<'C>,v:Thickness) = binder.Control.BorderThickness <- v ; binder
    
    member __.BorderThickness<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.BorderThicknessProperty)
    member __.BorderThickness<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.BorderThicknessProperty)
    member __.BorderThickness<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.BorderThicknessProperty)
    member __.BorderThickness<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.BorderThicknessProperty)
    

    [<CustomOperation("isTabStop")>]
    member __.IsTabStop<'C when 'C :> Control>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsTabStop <- v ; binder
    
    member __.IsTabStop<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.IsTabStopProperty)
    member __.IsTabStop<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.IsTabStopProperty)
    member __.IsTabStop<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.IsTabStopProperty)
    member __.IsTabStop<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.IsTabStopProperty)
    

    [<CustomOperation("verticalContentAlignment")>]
    member __.VerticalContentAlignment<'C when 'C :> Control>(binder:ControlBinder<'C>,v:VerticalAlignment) = binder.Control.VerticalContentAlignment <- v ; binder
    
    member __.VerticalContentAlignment<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.VerticalContentAlignmentProperty)
    member __.VerticalContentAlignment<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.VerticalContentAlignmentProperty)
    member __.VerticalContentAlignment<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.VerticalContentAlignmentProperty)
    member __.VerticalContentAlignment<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.VerticalContentAlignmentProperty)
    

    [<CustomOperation("tabIndex")>]
    member __.TabIndex<'C when 'C :> Control>(binder:ControlBinder<'C>,v:int) = binder.Control.TabIndex <- v ; binder
    
    member __.TabIndex<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.TabIndexProperty)
    member __.TabIndex<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.TabIndexProperty)
    member __.TabIndex<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.TabIndexProperty)
    member __.TabIndex<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.TabIndexProperty)
    

    [<CustomOperation("padding")>]
    member __.Padding<'C when 'C :> Control>(binder:ControlBinder<'C>,v:Thickness) = binder.Control.Padding <- v ; binder
    
    member __.Padding<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.PaddingProperty)
    member __.Padding<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.PaddingProperty)
    member __.Padding<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.PaddingProperty)
    member __.Padding<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.PaddingProperty)
    

    [<CustomOperation("template")>]
    member __.Template<'C when 'C :> Control>(binder:ControlBinder<'C>,v:ControlTemplate) = binder.Control.Template <- v ; binder
    
    member __.Template<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.TemplateProperty)
    member __.Template<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.TemplateProperty)
    member __.Template<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.TemplateProperty)
    member __.Template<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.TemplateProperty)
    

    [<CustomOperation("fontWeight")>]
    member __.FontWeight<'C when 'C :> Control>(binder:ControlBinder<'C>,v:FontWeight) = binder.Control.FontWeight <- v ; binder
    
    member __.FontWeight<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.FontWeightProperty)
    member __.FontWeight<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.FontWeightProperty)
    member __.FontWeight<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.FontWeightProperty)
    member __.FontWeight<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.FontWeightProperty)
    

    [<CustomOperation("borderBrush")>]
    member __.BorderBrush<'C when 'C :> Control>(binder:ControlBinder<'C>,v:Brush) = binder.Control.BorderBrush <- v ; binder
    
    member __.BorderBrush<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.BorderBrushProperty)
    member __.BorderBrush<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.BorderBrushProperty)
    member __.BorderBrush<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.BorderBrushProperty)
    member __.BorderBrush<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.BorderBrushProperty)
    

    [<CustomOperation("horizontalContentAlignment")>]
    member __.HorizontalContentAlignment<'C when 'C :> Control>(binder:ControlBinder<'C>,v:HorizontalAlignment) = binder.Control.HorizontalContentAlignment <- v ; binder
    
    member __.HorizontalContentAlignment<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Control.HorizontalContentAlignmentProperty)
    member __.HorizontalContentAlignment<'C,'TP,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Control.HorizontalContentAlignmentProperty)
    member __.HorizontalContentAlignment<'C,'T1,'T2,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Control.HorizontalContentAlignmentProperty)
    member __.HorizontalContentAlignment<'C,'T1,'T2,'T3,'TC when 'C :> Control>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Control.HorizontalContentAlignmentProperty)
    

    [<CustomOperation("onMouseDoubleClick")>]  
    member x.MouseDoubleClick<'C when 'C :> Control>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.MouseDoubleClick))
    member x.MouseDoubleClick<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.MouseDoubleClick))
    member x.MouseDoubleClick<'C,'T1,'T2 when 'C :> Control>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.MouseDoubleClick))
    member x.MouseDoubleClick<'C,'T1,'T2,'T3 when 'C :> Control>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.MouseDoubleClick))

    member x.MouseDoubleClick<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseDoubleClick))
    member x.MouseDoubleClick<'C,'T1,'T2 when 'C :> Control>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseDoubleClick))
    member x.MouseDoubleClick<'C,'T1,'T2,'T3 when 'C :> Control>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.MouseDoubleClick))
    



    [<CustomOperation("onPreviewMouseDoubleClick")>]  
    member x.PreviewMouseDoubleClick<'C when 'C :> Control>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(MouseButtonEventHandler(fn),binder.Control.PreviewMouseDoubleClick))
    member x.PreviewMouseDoubleClick<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> MouseButtonEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.PreviewMouseDoubleClick))
    member x.PreviewMouseDoubleClick<'C,'T1,'T2 when 'C :> Control>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> MouseButtonEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.PreviewMouseDoubleClick))
    member x.PreviewMouseDoubleClick<'C,'T1,'T2,'T3 when 'C :> Control>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> MouseButtonEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.PreviewMouseDoubleClick))

    member x.PreviewMouseDoubleClick<'C,'T when 'C :> Control>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseDoubleClick))
    member x.PreviewMouseDoubleClick<'C,'T1,'T2 when 'C :> Control>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseDoubleClick))
    member x.PreviewMouseDoubleClick<'C,'T1,'T2,'T3 when 'C :> Control>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> MouseButtonEventHandler(h)),fn,binder.Control.PreviewMouseDoubleClick))
    


open System.Windows.Controls.Primitives
type TextBoxBaseBuilder() =

    inherit ControlBuilder()
                

    [<CustomOperation("verticalScrollBarVisibility")>]
    member __.VerticalScrollBarVisibility<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:ScrollBarVisibility) = binder.Control.VerticalScrollBarVisibility <- v ; binder
    
    member __.VerticalScrollBarVisibility<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.VerticalScrollBarVisibilityProperty)
    member __.VerticalScrollBarVisibility<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.VerticalScrollBarVisibilityProperty)
    member __.VerticalScrollBarVisibility<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.VerticalScrollBarVisibilityProperty)
    member __.VerticalScrollBarVisibility<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.VerticalScrollBarVisibilityProperty)
    

    [<CustomOperation("acceptsReturn")>]
    member __.AcceptsReturn<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:bool) = binder.Control.AcceptsReturn <- v ; binder
    
    member __.AcceptsReturn<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.AcceptsReturnProperty)
    member __.AcceptsReturn<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.AcceptsReturnProperty)
    member __.AcceptsReturn<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.AcceptsReturnProperty)
    member __.AcceptsReturn<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.AcceptsReturnProperty)
    

    [<CustomOperation("acceptsTab")>]
    member __.AcceptsTab<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:bool) = binder.Control.AcceptsTab <- v ; binder
    
    member __.AcceptsTab<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.AcceptsTabProperty)
    member __.AcceptsTab<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.AcceptsTabProperty)
    member __.AcceptsTab<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.AcceptsTabProperty)
    member __.AcceptsTab<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.AcceptsTabProperty)
    

    [<CustomOperation("isReadOnlyCaretVisible")>]
    member __.IsReadOnlyCaretVisible<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsReadOnlyCaretVisible <- v ; binder
    
    member __.IsReadOnlyCaretVisible<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.IsReadOnlyCaretVisibleProperty)
    member __.IsReadOnlyCaretVisible<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.IsReadOnlyCaretVisibleProperty)
    member __.IsReadOnlyCaretVisible<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.IsReadOnlyCaretVisibleProperty)
    member __.IsReadOnlyCaretVisible<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.IsReadOnlyCaretVisibleProperty)
    

    [<CustomOperation("horizontalScrollBarVisibility")>]
    member __.HorizontalScrollBarVisibility<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:ScrollBarVisibility) = binder.Control.HorizontalScrollBarVisibility <- v ; binder
    
    member __.HorizontalScrollBarVisibility<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.HorizontalScrollBarVisibilityProperty)
    member __.HorizontalScrollBarVisibility<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.HorizontalScrollBarVisibilityProperty)
    member __.HorizontalScrollBarVisibility<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.HorizontalScrollBarVisibilityProperty)
    member __.HorizontalScrollBarVisibility<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.HorizontalScrollBarVisibilityProperty)
    

    [<CustomOperation("selectionOpacity")>]
    member __.SelectionOpacity<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:double) = binder.Control.SelectionOpacity <- v ; binder
    
    member __.SelectionOpacity<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.SelectionOpacityProperty)
    member __.SelectionOpacity<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.SelectionOpacityProperty)
    member __.SelectionOpacity<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.SelectionOpacityProperty)
    member __.SelectionOpacity<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.SelectionOpacityProperty)
    

    [<CustomOperation("isUndoEnabled")>]
    member __.IsUndoEnabled<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsUndoEnabled <- v ; binder
    
    member __.IsUndoEnabled<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.IsUndoEnabledProperty)
    member __.IsUndoEnabled<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.IsUndoEnabledProperty)
    member __.IsUndoEnabled<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.IsUndoEnabledProperty)
    member __.IsUndoEnabled<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.IsUndoEnabledProperty)
    

    [<CustomOperation("undoLimit")>]
    member __.UndoLimit<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:int) = binder.Control.UndoLimit <- v ; binder
    
    member __.UndoLimit<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.UndoLimitProperty)
    member __.UndoLimit<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.UndoLimitProperty)
    member __.UndoLimit<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.UndoLimitProperty)
    member __.UndoLimit<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.UndoLimitProperty)
    

    [<CustomOperation("autoWordSelection")>]
    member __.AutoWordSelection<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:bool) = binder.Control.AutoWordSelection <- v ; binder
    
    member __.AutoWordSelection<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.AutoWordSelectionProperty)
    member __.AutoWordSelection<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.AutoWordSelectionProperty)
    member __.AutoWordSelection<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.AutoWordSelectionProperty)
    member __.AutoWordSelection<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.AutoWordSelectionProperty)
    

    [<CustomOperation("selectionBrush")>]
    member __.SelectionBrush<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:Brush) = binder.Control.SelectionBrush <- v ; binder
    
    member __.SelectionBrush<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.SelectionBrushProperty)
    member __.SelectionBrush<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.SelectionBrushProperty)
    member __.SelectionBrush<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.SelectionBrushProperty)
    member __.SelectionBrush<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.SelectionBrushProperty)
    

    [<CustomOperation("isReadOnly")>]
    member __.IsReadOnly<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsReadOnly <- v ; binder
    
    member __.IsReadOnly<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.IsReadOnlyProperty)
    member __.IsReadOnly<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.IsReadOnlyProperty)
    member __.IsReadOnly<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.IsReadOnlyProperty)
    member __.IsReadOnly<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.IsReadOnlyProperty)
    

    [<CustomOperation("caretBrush")>]
    member __.CaretBrush<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:Brush) = binder.Control.CaretBrush <- v ; binder
    
    member __.CaretBrush<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.CaretBrushProperty)
    member __.CaretBrush<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.CaretBrushProperty)
    member __.CaretBrush<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.CaretBrushProperty)
    member __.CaretBrush<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.CaretBrushProperty)
    

    [<CustomOperation("isSelectionActive")>]
    member __.IsSelectionActive<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr TextBoxBase.IsSelectionActiveProperty)  
    member __.IsSelectionActive<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap TextBoxBase.IsSelectionActiveProperty)
    member __.IsSelectionActive<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap TextBoxBase.IsSelectionActiveProperty)
    member __.IsSelectionActive<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap TextBoxBase.IsSelectionActiveProperty)

    [<CustomOperation("isInactiveSelectionHighlightEnabled")>]
    member __.IsInactiveSelectionHighlightEnabled<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsInactiveSelectionHighlightEnabled <- v ; binder
    
    member __.IsInactiveSelectionHighlightEnabled<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBoxBase.IsInactiveSelectionHighlightEnabledProperty)
    member __.IsInactiveSelectionHighlightEnabled<'C,'TP,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBoxBase.IsInactiveSelectionHighlightEnabledProperty)
    member __.IsInactiveSelectionHighlightEnabled<'C,'T1,'T2,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBoxBase.IsInactiveSelectionHighlightEnabledProperty)
    member __.IsInactiveSelectionHighlightEnabled<'C,'T1,'T2,'T3,'TC when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBoxBase.IsInactiveSelectionHighlightEnabledProperty)
    

    [<CustomOperation("onTextChanged")>]  
    member x.TextChanged<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(TextChangedEventHandler(fn),binder.Control.TextChanged))
    member x.TextChanged<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> TextChangedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.TextChanged))
    member x.TextChanged<'C,'T1,'T2 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> TextChangedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.TextChanged))
    member x.TextChanged<'C,'T1,'T2,'T3 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> TextChangedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.TextChanged))

    member x.TextChanged<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> TextChangedEventHandler(h)),fn,binder.Control.TextChanged))
    member x.TextChanged<'C,'T1,'T2 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> TextChangedEventHandler(h)),fn,binder.Control.TextChanged))
    member x.TextChanged<'C,'T1,'T2,'T3 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> TextChangedEventHandler(h)),fn,binder.Control.TextChanged))
    



    [<CustomOperation("onSelectionChanged")>]  
    member x.SelectionChanged<'C when 'C :> TextBoxBase>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2,'T3 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.SelectionChanged))

    member x.SelectionChanged<'C,'T when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2,'T3 when 'C :> TextBoxBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.SelectionChanged))
    


type ContentControlBuilder() =

    inherit ControlBuilder()
                

    [<CustomOperation("contentTemplate")>]
    member __.ContentTemplate<'C when 'C :> ContentControl>(binder:ControlBinder<'C>,v:DataTemplate) = binder.Control.ContentTemplate <- v ; binder
    
    member __.ContentTemplate<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ContentControl.ContentTemplateProperty)
    member __.ContentTemplate<'C,'TP,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ContentControl.ContentTemplateProperty)
    member __.ContentTemplate<'C,'T1,'T2,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ContentControl.ContentTemplateProperty)
    member __.ContentTemplate<'C,'T1,'T2,'T3,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ContentControl.ContentTemplateProperty)
    

    [<CustomOperation("hasContent")>]
    member __.HasContent<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr ContentControl.HasContentProperty)  
    member __.HasContent<'C,'TP,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap ContentControl.HasContentProperty)
    member __.HasContent<'C,'T1,'T2,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap ContentControl.HasContentProperty)
    member __.HasContent<'C,'T1,'T2,'T3,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap ContentControl.HasContentProperty)

    [<CustomOperation("content")>]
    //member __.Content<'C when 'C :> ContentControl>(binder:ControlBinder<'C>,v:obj) = binder.Control.Content <- v ; binder

    member __.Content<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,v:UIElement) = binder.Control.Content <- v ; binder
    
    member __.Content<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,text:string) = binder.Control.Content <- text ; binder

    member __.Content<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ContentControl.ContentProperty)
    
    member __.Content<'C,'TP when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,getMap:'TP->string)) =  
        binder.Collect(fun env control ->
        let lambda = env.AddExpr(expr)
        control.Content <- lambda.Get |> getMap
        lambda.Subscribe (fun v -> control.Content <- getMap v))

    member __.Content<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,child:IControlBinder) = 
        binder.AddChildBinder child
        binder.Control.Content <- child.UIElement
        binder
    
    member __.Content<'C,'T when 'C :> ContentControl and 'T :> UIElement>(binder:ControlBinder<'C>,(expr:Expr<IControlBinder>)) =
        let envRef = ref ( new Env())
        binder.Collect(fun env control ->
        let view = env.AddExpr<IControlBinder>(expr)
        view.Get.ApplyEnv envRef.Value
        control.Content <- view.Get.UIElement
        view.Subscribe(fun cbind -> 
            (envRef.Value :> IDisposable).Dispose()
            envRef.Value <- new Env() 
            cbind.ApplyEnv envRef.Value
            control.SetValue(ContentControl.ContentProperty,cbind.UIElement)
            )
        )
    
    member __.Content<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,(oseq:ObservableCollection<'T>,fn:ObservableCollection<'T> -> string)) =
        binder.Collect(fun env control ->
        // initial bind
        control.SetValue(ContentControl.ContentProperty,fn oseq)
        // create change handler capturing dict etc
        let handler = Specialized.NotifyCollectionChangedEventHandler(fun _ args -> control.SetValue(ContentControl.ContentProperty,fn oseq))
        oseq.CollectionChanged.AddHandler handler
        env.AddDisposable { new IDisposable with member __.Dispose() = oseq.CollectionChanged.RemoveHandler handler } )
                    

    [<CustomOperation("contentStringFormat")>]
    member __.ContentStringFormat<'C when 'C :> ContentControl>(binder:ControlBinder<'C>,v:string) = binder.Control.ContentStringFormat <- v ; binder
    
    member __.ContentStringFormat<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ContentControl.ContentStringFormatProperty)
    member __.ContentStringFormat<'C,'TP,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ContentControl.ContentStringFormatProperty)
    member __.ContentStringFormat<'C,'T1,'T2,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ContentControl.ContentStringFormatProperty)
    member __.ContentStringFormat<'C,'T1,'T2,'T3,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ContentControl.ContentStringFormatProperty)
    

    [<CustomOperation("contentTemplateSelector")>]
    member __.ContentTemplateSelector<'C when 'C :> ContentControl>(binder:ControlBinder<'C>,v:DataTemplateSelector) = binder.Control.ContentTemplateSelector <- v ; binder
    
    member __.ContentTemplateSelector<'C,'T when 'C :> ContentControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ContentControl.ContentTemplateSelectorProperty)
    member __.ContentTemplateSelector<'C,'TP,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ContentControl.ContentTemplateSelectorProperty)
    member __.ContentTemplateSelector<'C,'T1,'T2,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ContentControl.ContentTemplateSelectorProperty)
    member __.ContentTemplateSelector<'C,'T1,'T2,'T3,'TC when 'C :> ContentControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ContentControl.ContentTemplateSelectorProperty)
    
type TextBoxBuilder() =

    inherit TextBoxBaseBuilder()
                

    member x.Yield(_) = new ControlBinder<TextBox>(TextBox())
    member x.Run(w:ControlBinder<TextBox>) = w :> IControlBinder

    [<CustomOperation("minLines")>]
    member __.MinLines<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:int) = binder.Control.MinLines <- v ; binder
    
    member __.MinLines<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.MinLinesProperty)
    member __.MinLines<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.MinLinesProperty)
    member __.MinLines<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.MinLinesProperty)
    member __.MinLines<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.MinLinesProperty)
    

    [<CustomOperation("maxLines")>]
    member __.MaxLines<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:int) = binder.Control.MaxLines <- v ; binder
    
    member __.MaxLines<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.MaxLinesProperty)
    member __.MaxLines<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.MaxLinesProperty)
    member __.MaxLines<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.MaxLinesProperty)
    member __.MaxLines<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.MaxLinesProperty)
    

    [<CustomOperation("text")>]
    member __.Text<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:string) = binder.Control.Text <- v ; binder
    
    member __.Text<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.TextProperty)
    member __.Text<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.TextProperty)
    member __.Text<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.TextProperty)
    member __.Text<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.TextProperty)
    

    [<CustomOperation("characterCasing")>]
    member __.CharacterCasing<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:CharacterCasing) = binder.Control.CharacterCasing <- v ; binder
    
    member __.CharacterCasing<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.CharacterCasingProperty)
    member __.CharacterCasing<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.CharacterCasingProperty)
    member __.CharacterCasing<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.CharacterCasingProperty)
    member __.CharacterCasing<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.CharacterCasingProperty)
    

    [<CustomOperation("maxLength")>]
    member __.MaxLength<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:int) = binder.Control.MaxLength <- v ; binder
    
    member __.MaxLength<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.MaxLengthProperty)
    member __.MaxLength<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.MaxLengthProperty)
    member __.MaxLength<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.MaxLengthProperty)
    member __.MaxLength<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.MaxLengthProperty)
    

    [<CustomOperation("textAlignment")>]
    member __.TextAlignment<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:TextAlignment) = binder.Control.TextAlignment <- v ; binder
    
    member __.TextAlignment<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.TextAlignmentProperty)
    member __.TextAlignment<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.TextAlignmentProperty)
    member __.TextAlignment<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.TextAlignmentProperty)
    member __.TextAlignment<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.TextAlignmentProperty)
    

    [<CustomOperation("caretIndex")>]
    member __.CaretIndex<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:int) = binder.Control.CaretIndex <- v ; binder

    [<CustomOperation("selectionLength")>]
    member __.SelectionLength<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:int) = binder.Control.SelectionLength <- v ; binder

    [<CustomOperation("selectionStart")>]
    member __.SelectionStart<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:int) = binder.Control.SelectionStart <- v ; binder

    [<CustomOperation("textDecorations")>]
    member __.TextDecorations<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:TextDecorationCollection) = binder.Control.TextDecorations <- v ; binder
    
    member __.TextDecorations<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.TextDecorationsProperty)
    member __.TextDecorations<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.TextDecorationsProperty)
    member __.TextDecorations<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.TextDecorationsProperty)
    member __.TextDecorations<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.TextDecorationsProperty)
    

    [<CustomOperation("selectedText")>]
    member __.SelectedText<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:string) = binder.Control.SelectedText <- v ; binder

    [<CustomOperation("textWrapping")>]
    member __.TextWrapping<'C when 'C :> TextBox>(binder:ControlBinder<'C>,v:TextWrapping) = binder.Control.TextWrapping <- v ; binder
    
    member __.TextWrapping<'C,'T when 'C :> TextBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TextBox.TextWrappingProperty)
    member __.TextWrapping<'C,'TP,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TextBox.TextWrappingProperty)
    member __.TextWrapping<'C,'T1,'T2,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TextBox.TextWrappingProperty)
    member __.TextWrapping<'C,'T1,'T2,'T3,'TC when 'C :> TextBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TextBox.TextWrappingProperty)
    

let textBox  = TextBoxBuilder()

type PanelBuilder() =

    inherit FrameworkElementBuilder()
                

    [<CustomOperation("children")>]
    member __.Children<'C,'T when 'C :> StackPanel and 'T :> UIElement>(binder:ControlBinder<'C>,childern:seq<IControlBinder>) = 
        for child in childern do
            binder.Control.Children.Add child.UIElement |> ignore
            binder.AddChildBinder child
        binder

    member __.Children<'C,'T when 'C :> StackPanel>(binder:ControlBinder<'C>,(oseq:ObservableCollection<'T>,render:'T -> IControlBinder)) = 
        let envs = List<Env * UIElement>(oseq.Count)
        binder.Collect(fun env control ->
        for i in 0 .. oseq.Count - 1 do
            let childBinder = render oseq.[i]
            let cEnv = new Env()
            childBinder.ApplyEnv cEnv
            control.Children.Add childBinder.UIElement |> ignore
            envs.Add(cEnv,childBinder.UIElement)
        // create change handler capturing dict etc
        let handler = Specialized.NotifyCollectionChangedEventHandler(fun _ args -> 
            match args.Action with
            | Specialized.NotifyCollectionChangedAction.Add ->
                if args.NewStartingIndex = envs.Count then
                    for i in 0 .. args.NewItems.Count - 1 do 
                        let cbind = args.NewItems.[i] :?> 'T |> render
                        let cEnv = new Env()
                        cbind.ApplyEnv cEnv
                        control.Children.Add cbind.UIElement |> ignore
                        envs.Add(cEnv,cbind.UIElement)
                else failwithf "new items added to coll len %i but starting index of added items %i?" envs.Count args.NewStartingIndex
            | Specialized.NotifyCollectionChangedAction.Remove ->
                for i in args.OldStartingIndex .. args.OldStartingIndex + args.OldItems.Count - 1 do
                    let remEnv,remUI = envs.[i] 
                    (remEnv :> IDisposable).Dispose()
                    envs.RemoveAt(i)
                    control.Children.Remove remUI
            | _ -> ()   
        )
        oseq.CollectionChanged.AddHandler handler
        env.AddDisposable { 
            new IDisposable with 
                member __.Dispose() = 
                    oseq.CollectionChanged.RemoveHandler handler
                    for (env,_) in envs do (env :> IDisposable).Dispose()
                    envs.Clear()
            }
        )
    [<CustomOperation("add")>]
    member __.Add<'C,'T when 'C :> StackPanel>(binder:ControlBinder<'C>,child:IControlBinder) =
        binder.Control.Children.Add child.UIElement |> ignore
        binder.AddChildBinder(child)
        binder

    member __.Add<'C,'T when 'C :> StackPanel>(binder:ControlBinder<'C>,target:Expr<IControlBinder>) =
        let stub = ContentControl()
        binder.Control.Children.Add stub |> ignore
        let envRef = ref (new Env())
        binder.Collect(fun env _ ->
        let view = env.AddExpr(target)
        view.Get.ApplyEnv envRef.Value
        stub.SetValue(ContentControl.ContentProperty,view.Get.UIElement)
        env.AddDisposable { new IDisposable with member __.Dispose() = (envRef.Value :> IDisposable).Dispose() ; envRef.Value <- Unchecked.defaultof<_> }
        view.Subscribe (fun v -> 
            (envRef.Value :> IDisposable).Dispose()
            let newEnv = new Env()
            envRef.Value <- newEnv
            v.ApplyEnv newEnv
            stub.SetValue(ContentControl.ContentProperty,v.UIElement)
        ))
            

    [<CustomOperation("isItemsHost")>]
    member __.IsItemsHost<'C when 'C :> Panel>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsItemsHost <- v ; binder
    
    member __.IsItemsHost<'C,'T when 'C :> Panel>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Panel.IsItemsHostProperty)
    member __.IsItemsHost<'C,'TP,'TC when 'C :> Panel>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Panel.IsItemsHostProperty)
    member __.IsItemsHost<'C,'T1,'T2,'TC when 'C :> Panel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Panel.IsItemsHostProperty)
    member __.IsItemsHost<'C,'T1,'T2,'T3,'TC when 'C :> Panel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Panel.IsItemsHostProperty)
    

    [<CustomOperation("background")>]
    member __.Background<'C when 'C :> Panel>(binder:ControlBinder<'C>,v:Brush) = binder.Control.Background <- v ; binder
    
    member __.Background<'C,'T when 'C :> Panel>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Panel.BackgroundProperty)
    member __.Background<'C,'TP,'TC when 'C :> Panel>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Panel.BackgroundProperty)
    member __.Background<'C,'T1,'T2,'TC when 'C :> Panel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Panel.BackgroundProperty)
    member __.Background<'C,'T1,'T2,'T3,'TC when 'C :> Panel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Panel.BackgroundProperty)
    
type StackPanelBuilder() =

    inherit PanelBuilder()
                

    member x.Yield(_) = new ControlBinder<StackPanel>(StackPanel())
    member x.Run(w:ControlBinder<StackPanel>) = w :> IControlBinder

    [<CustomOperation("canVerticallyScroll")>]
    member __.CanVerticallyScroll<'C when 'C :> StackPanel>(binder:ControlBinder<'C>,v:bool) = binder.Control.CanVerticallyScroll <- v ; binder

    [<CustomOperation("canHorizontallyScroll")>]
    member __.CanHorizontallyScroll<'C when 'C :> StackPanel>(binder:ControlBinder<'C>,v:bool) = binder.Control.CanHorizontallyScroll <- v ; binder

    [<CustomOperation("orientation")>]
    member __.Orientation<'C when 'C :> StackPanel>(binder:ControlBinder<'C>,v:Orientation) = binder.Control.Orientation <- v ; binder
    
    member __.Orientation<'C,'T when 'C :> StackPanel>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr StackPanel.OrientationProperty)
    member __.Orientation<'C,'TP,'TC when 'C :> StackPanel>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap StackPanel.OrientationProperty)
    member __.Orientation<'C,'T1,'T2,'TC when 'C :> StackPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap StackPanel.OrientationProperty)
    member __.Orientation<'C,'T1,'T2,'T3,'TC when 'C :> StackPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap StackPanel.OrientationProperty)
    

    [<CustomOperation("scrollOwner")>]
    member __.ScrollOwner<'C when 'C :> StackPanel>(binder:ControlBinder<'C>,v:ScrollViewer) = binder.Control.ScrollOwner <- v ; binder

let stackPanel  = StackPanelBuilder()

type LabelBuilder() =

    inherit ContentControlBuilder()
                

    member x.Yield(_) = new ControlBinder<Label>(Label())
    member x.Run(w:ControlBinder<Label>) = w :> IControlBinder

    [<CustomOperation("target")>]
    member __.Target<'C when 'C :> Label>(binder:ControlBinder<'C>,v:UIElement) = binder.Control.Target <- v ; binder
    
    member __.Target<'C,'T when 'C :> Label>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Label.TargetProperty)
    member __.Target<'C,'TP,'TC when 'C :> Label>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Label.TargetProperty)
    member __.Target<'C,'T1,'T2,'TC when 'C :> Label>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Label.TargetProperty)
    member __.Target<'C,'T1,'T2,'T3,'TC when 'C :> Label>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Label.TargetProperty)
    

let label  = LabelBuilder()

type ButtonBaseBuilder() =

    inherit ContentControlBuilder()
                

    [<CustomOperation("commandTarget")>]
    member __.CommandTarget<'C when 'C :> ButtonBase>(binder:ControlBinder<'C>,v:IInputElement) = binder.Control.CommandTarget <- v ; binder
    
    member __.CommandTarget<'C,'T when 'C :> ButtonBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ButtonBase.CommandTargetProperty)
    member __.CommandTarget<'C,'TP,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ButtonBase.CommandTargetProperty)
    member __.CommandTarget<'C,'T1,'T2,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ButtonBase.CommandTargetProperty)
    member __.CommandTarget<'C,'T1,'T2,'T3,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ButtonBase.CommandTargetProperty)
    

    [<CustomOperation("commandParameter")>]
    member __.CommandParameter<'C when 'C :> ButtonBase>(binder:ControlBinder<'C>,v:obj) = binder.Control.CommandParameter <- v ; binder
    
    member __.CommandParameter<'C,'T when 'C :> ButtonBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ButtonBase.CommandParameterProperty)
    member __.CommandParameter<'C,'TP,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ButtonBase.CommandParameterProperty)
    member __.CommandParameter<'C,'T1,'T2,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ButtonBase.CommandParameterProperty)
    member __.CommandParameter<'C,'T1,'T2,'T3,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ButtonBase.CommandParameterProperty)
    

    [<CustomOperation("command")>]
    member __.Command<'C when 'C :> ButtonBase>(binder:ControlBinder<'C>,v:ICommand) = binder.Control.Command <- v ; binder
    
    member __.Command<'C,'T when 'C :> ButtonBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ButtonBase.CommandProperty)
    member __.Command<'C,'TP,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ButtonBase.CommandProperty)
    member __.Command<'C,'T1,'T2,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ButtonBase.CommandProperty)
    member __.Command<'C,'T1,'T2,'T3,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ButtonBase.CommandProperty)
    

    [<CustomOperation("clickMode")>]
    member __.ClickMode<'C when 'C :> ButtonBase>(binder:ControlBinder<'C>,v:ClickMode) = binder.Control.ClickMode <- v ; binder
    
    member __.ClickMode<'C,'T when 'C :> ButtonBase>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ButtonBase.ClickModeProperty)
    member __.ClickMode<'C,'TP,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ButtonBase.ClickModeProperty)
    member __.ClickMode<'C,'T1,'T2,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ButtonBase.ClickModeProperty)
    member __.ClickMode<'C,'T1,'T2,'T3,'TC when 'C :> ButtonBase>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ButtonBase.ClickModeProperty)
    

    [<CustomOperation("onClick")>]  
    member x.Click<'C when 'C :> ButtonBase>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.Click))
    member x.Click<'C,'T when 'C :> ButtonBase>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.Click))
    member x.Click<'C,'T1,'T2 when 'C :> ButtonBase>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.Click))
    member x.Click<'C,'T1,'T2,'T3 when 'C :> ButtonBase>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.Click))

    member x.Click<'C,'T when 'C :> ButtonBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Click))
    member x.Click<'C,'T1,'T2 when 'C :> ButtonBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Click))
    member x.Click<'C,'T1,'T2,'T3 when 'C :> ButtonBase>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Click))
    


type ButtonBuilder() =

    inherit ButtonBaseBuilder()
                

    member x.Yield(_) = new ControlBinder<Button>(Button())
    member x.Run(w:ControlBinder<Button>) = w :> IControlBinder

    [<CustomOperation("isDefault")>]
    member __.IsDefault<'C when 'C :> Button>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsDefault <- v ; binder
    
    member __.IsDefault<'C,'T when 'C :> Button>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Button.IsDefaultProperty)
    member __.IsDefault<'C,'TP,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Button.IsDefaultProperty)
    member __.IsDefault<'C,'T1,'T2,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Button.IsDefaultProperty)
    member __.IsDefault<'C,'T1,'T2,'T3,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Button.IsDefaultProperty)
    

    [<CustomOperation("isCancel")>]
    member __.IsCancel<'C when 'C :> Button>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsCancel <- v ; binder
    
    member __.IsCancel<'C,'T when 'C :> Button>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Button.IsCancelProperty)
    member __.IsCancel<'C,'TP,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Button.IsCancelProperty)
    member __.IsCancel<'C,'T1,'T2,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Button.IsCancelProperty)
    member __.IsCancel<'C,'T1,'T2,'T3,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Button.IsCancelProperty)
    

    [<CustomOperation("isDefaulted")>]
    member __.IsDefaulted<'C,'T when 'C :> Button>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr Button.IsDefaultedProperty)  
    member __.IsDefaulted<'C,'TP,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap Button.IsDefaultedProperty)
    member __.IsDefaulted<'C,'T1,'T2,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap Button.IsDefaultedProperty)
    member __.IsDefaulted<'C,'T1,'T2,'T3,'TC when 'C :> Button>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap Button.IsDefaultedProperty)

let button  = ButtonBuilder()

type ItemsControlBuilder() =

    inherit ControlBuilder()
                

    [<CustomOperation("items")>]
    member __.Items<'C,'T when 'C :> ItemsControl and 'T : equality>(binder:ControlBinder<'C>,(oseq:ObservableCollection<'T>,render:'T-> IControlBinder)) = 
        let envs = List<Env * UIElement>(oseq.Count)
        binder.Collect(fun env control ->
        for i in 0 .. oseq.Count - 1 do
            let childBinder = render oseq.[i]
            let cEnv = new Env()
            childBinder.ApplyEnv cEnv
            control.Items.Add childBinder.UIElement |> ignore
            envs.Add(cEnv,childBinder.UIElement)

        let handler = Specialized.NotifyCollectionChangedEventHandler(fun _ args -> 
            match args.Action with
            | Specialized.NotifyCollectionChangedAction.Add ->
                if args.NewStartingIndex = envs.Count then
                    for i in 0 .. args.NewItems.Count - 1 do 
                        let cbind = args.NewItems.[i] :?> 'T |> render
                        let cEnv = new Env()
                        cbind.ApplyEnv cEnv
                        control.Items.Add cbind.UIElement |> ignore
                        envs.Add(cEnv,cbind.UIElement)
                else failwithf "new items added to coll len %i but starting index of added items %i?" envs.Count args.NewStartingIndex
            | Specialized.NotifyCollectionChangedAction.Remove ->
                for i in args.OldStartingIndex .. args.OldStartingIndex + args.OldItems.Count - 1 do
                    let remEnv,remUI = envs.[i] 
                    (remEnv :> IDisposable).Dispose()
                    envs.RemoveAt(i)
                    control.Items.Remove remUI
            | _ -> ()   
        )
        oseq.CollectionChanged.AddHandler handler
        env.AddDisposable { 
            new IDisposable with 
                member __.Dispose() = 
                    oseq.CollectionChanged.RemoveHandler handler
                    for (env,_) in envs do (env :> IDisposable).Dispose()
                    envs.Clear()
            }
        )
            

    [<CustomOperation("alternationCount")>]
    member __.AlternationCount<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:int) = binder.Control.AlternationCount <- v ; binder
    
    member __.AlternationCount<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.AlternationCountProperty)
    member __.AlternationCount<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.AlternationCountProperty)
    member __.AlternationCount<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.AlternationCountProperty)
    member __.AlternationCount<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.AlternationCountProperty)
    

    [<CustomOperation("groupStyleSelector")>]
    member __.GroupStyleSelector<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:GroupStyleSelector) = binder.Control.GroupStyleSelector <- v ; binder
    
    member __.GroupStyleSelector<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.GroupStyleSelectorProperty)
    member __.GroupStyleSelector<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.GroupStyleSelectorProperty)
    member __.GroupStyleSelector<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.GroupStyleSelectorProperty)
    member __.GroupStyleSelector<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.GroupStyleSelectorProperty)
    

    [<CustomOperation("isGrouping")>]
    member __.IsGrouping<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr ItemsControl.IsGroupingProperty)  
    member __.IsGrouping<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap ItemsControl.IsGroupingProperty)
    member __.IsGrouping<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap ItemsControl.IsGroupingProperty)
    member __.IsGrouping<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap ItemsControl.IsGroupingProperty)

    [<CustomOperation("itemsPanel")>]
    member __.ItemsPanel<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:ItemsPanelTemplate) = binder.Control.ItemsPanel <- v ; binder
    
    member __.ItemsPanel<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemsPanelProperty)
    member __.ItemsPanel<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemsPanelProperty)
    member __.ItemsPanel<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemsPanelProperty)
    member __.ItemsPanel<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemsPanelProperty)
    

    [<CustomOperation("itemContainerStyleSelector")>]
    member __.ItemContainerStyleSelector<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:StyleSelector) = binder.Control.ItemContainerStyleSelector <- v ; binder
    
    member __.ItemContainerStyleSelector<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemContainerStyleSelectorProperty)
    member __.ItemContainerStyleSelector<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemContainerStyleSelectorProperty)
    member __.ItemContainerStyleSelector<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemContainerStyleSelectorProperty)
    member __.ItemContainerStyleSelector<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemContainerStyleSelectorProperty)
    

    [<CustomOperation("itemContainerStyle")>]
    member __.ItemContainerStyle<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:Style) = binder.Control.ItemContainerStyle <- v ; binder
    
    member __.ItemContainerStyle<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemContainerStyleProperty)
    member __.ItemContainerStyle<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemContainerStyleProperty)
    member __.ItemContainerStyle<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemContainerStyleProperty)
    member __.ItemContainerStyle<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemContainerStyleProperty)
    

    [<CustomOperation("itemBindingGroup")>]
    member __.ItemBindingGroup<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:BindingGroup) = binder.Control.ItemBindingGroup <- v ; binder
    
    member __.ItemBindingGroup<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemBindingGroupProperty)
    member __.ItemBindingGroup<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemBindingGroupProperty)
    member __.ItemBindingGroup<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemBindingGroupProperty)
    member __.ItemBindingGroup<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemBindingGroupProperty)
    

    [<CustomOperation("itemStringFormat")>]
    member __.ItemStringFormat<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:string) = binder.Control.ItemStringFormat <- v ; binder
    
    member __.ItemStringFormat<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemStringFormatProperty)
    member __.ItemStringFormat<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemStringFormatProperty)
    member __.ItemStringFormat<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemStringFormatProperty)
    member __.ItemStringFormat<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemStringFormatProperty)
    

    [<CustomOperation("itemTemplateSelector")>]
    member __.ItemTemplateSelector<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:DataTemplateSelector) = binder.Control.ItemTemplateSelector <- v ; binder
    
    member __.ItemTemplateSelector<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemTemplateSelectorProperty)
    member __.ItemTemplateSelector<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemTemplateSelectorProperty)
    member __.ItemTemplateSelector<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemTemplateSelectorProperty)
    member __.ItemTemplateSelector<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemTemplateSelectorProperty)
    

    [<CustomOperation("itemTemplate")>]
    member __.ItemTemplate<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:DataTemplate) = binder.Control.ItemTemplate <- v ; binder
    
    member __.ItemTemplate<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemTemplateProperty)
    member __.ItemTemplate<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemTemplateProperty)
    member __.ItemTemplate<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemTemplateProperty)
    member __.ItemTemplate<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemTemplateProperty)
    

    [<CustomOperation("displayMemberPath")>]
    member __.DisplayMemberPath<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:string) = binder.Control.DisplayMemberPath <- v ; binder
    
    member __.DisplayMemberPath<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.DisplayMemberPathProperty)
    member __.DisplayMemberPath<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.DisplayMemberPathProperty)
    member __.DisplayMemberPath<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.DisplayMemberPathProperty)
    member __.DisplayMemberPath<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.DisplayMemberPathProperty)
    

    [<CustomOperation("hasItems")>]
    member __.HasItems<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr ItemsControl.HasItemsProperty)  
    member __.HasItems<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap ItemsControl.HasItemsProperty)
    member __.HasItems<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap ItemsControl.HasItemsProperty)
    member __.HasItems<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap ItemsControl.HasItemsProperty)

    [<CustomOperation("itemsSource")>]
    member __.ItemsSource<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:IEnumerable) = binder.Control.ItemsSource <- v ; binder
    
    member __.ItemsSource<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.ItemsSourceProperty)
    member __.ItemsSource<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.ItemsSourceProperty)
    member __.ItemsSource<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.ItemsSourceProperty)
    member __.ItemsSource<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.ItemsSourceProperty)
    

    [<CustomOperation("isTextSearchCaseSensitive")>]
    member __.IsTextSearchCaseSensitive<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsTextSearchCaseSensitive <- v ; binder
    
    member __.IsTextSearchCaseSensitive<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.IsTextSearchCaseSensitiveProperty)
    member __.IsTextSearchCaseSensitive<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.IsTextSearchCaseSensitiveProperty)
    member __.IsTextSearchCaseSensitive<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.IsTextSearchCaseSensitiveProperty)
    member __.IsTextSearchCaseSensitive<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.IsTextSearchCaseSensitiveProperty)
    

    [<CustomOperation("isTextSearchEnabled")>]
    member __.IsTextSearchEnabled<'C when 'C :> ItemsControl>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsTextSearchEnabled <- v ; binder
    
    member __.IsTextSearchEnabled<'C,'T when 'C :> ItemsControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ItemsControl.IsTextSearchEnabledProperty)
    member __.IsTextSearchEnabled<'C,'TP,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ItemsControl.IsTextSearchEnabledProperty)
    member __.IsTextSearchEnabled<'C,'T1,'T2,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ItemsControl.IsTextSearchEnabledProperty)
    member __.IsTextSearchEnabled<'C,'T1,'T2,'T3,'TC when 'C :> ItemsControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ItemsControl.IsTextSearchEnabledProperty)
    
type SelectorBuilder() =

    inherit ItemsControlBuilder()
                

    [<CustomOperation("selectedValue")>]
    member __.SelectedValue<'C when 'C :> Selector>(binder:ControlBinder<'C>,v:obj) = binder.Control.SelectedValue <- v ; binder
    
    member __.SelectedValue<'C,'T when 'C :> Selector>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Selector.SelectedValueProperty)
    member __.SelectedValue<'C,'TP,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Selector.SelectedValueProperty)
    member __.SelectedValue<'C,'T1,'T2,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Selector.SelectedValueProperty)
    member __.SelectedValue<'C,'T1,'T2,'T3,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Selector.SelectedValueProperty)
    

    [<CustomOperation("selectedItem")>]
    member __.SelectedItem<'C when 'C :> Selector>(binder:ControlBinder<'C>,v:obj) = binder.Control.SelectedItem <- v ; binder
    
    member __.SelectedItem<'C,'T when 'C :> Selector>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Selector.SelectedItemProperty)
    member __.SelectedItem<'C,'TP,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Selector.SelectedItemProperty)
    member __.SelectedItem<'C,'T1,'T2,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Selector.SelectedItemProperty)
    member __.SelectedItem<'C,'T1,'T2,'T3,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Selector.SelectedItemProperty)
    

    [<CustomOperation("selectedIndex")>]
    member __.SelectedIndex<'C when 'C :> Selector>(binder:ControlBinder<'C>,v:int) = binder.Control.SelectedIndex <- v ; binder
    
    member __.SelectedIndex<'C,'T when 'C :> Selector>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Selector.SelectedIndexProperty)
    member __.SelectedIndex<'C,'TP,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Selector.SelectedIndexProperty)
    member __.SelectedIndex<'C,'T1,'T2,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Selector.SelectedIndexProperty)
    member __.SelectedIndex<'C,'T1,'T2,'T3,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Selector.SelectedIndexProperty)
    

    [<CustomOperation("isSynchronizedWithCurrentItem")>]
    member __.IsSynchronizedWithCurrentItem<'C when 'C :> Selector>(binder:ControlBinder<'C>,v:Nullable<bool>) = binder.Control.IsSynchronizedWithCurrentItem <- v ; binder
    
    member __.IsSynchronizedWithCurrentItem<'C,'T when 'C :> Selector>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Selector.IsSynchronizedWithCurrentItemProperty)
    member __.IsSynchronizedWithCurrentItem<'C,'TP,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Selector.IsSynchronizedWithCurrentItemProperty)
    member __.IsSynchronizedWithCurrentItem<'C,'T1,'T2,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Selector.IsSynchronizedWithCurrentItemProperty)
    member __.IsSynchronizedWithCurrentItem<'C,'T1,'T2,'T3,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Selector.IsSynchronizedWithCurrentItemProperty)
    

    [<CustomOperation("selectedValuePath")>]
    member __.SelectedValuePath<'C when 'C :> Selector>(binder:ControlBinder<'C>,v:string) = binder.Control.SelectedValuePath <- v ; binder
    
    member __.SelectedValuePath<'C,'T when 'C :> Selector>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Selector.SelectedValuePathProperty)
    member __.SelectedValuePath<'C,'TP,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Selector.SelectedValuePathProperty)
    member __.SelectedValuePath<'C,'T1,'T2,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Selector.SelectedValuePathProperty)
    member __.SelectedValuePath<'C,'T1,'T2,'T3,'TC when 'C :> Selector>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Selector.SelectedValuePathProperty)
    

    [<CustomOperation("onSelectionChanged")>]  
    member x.SelectionChanged<'C when 'C :> Selector>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(SelectionChangedEventHandler(fn),binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T when 'C :> Selector>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> SelectionChangedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2 when 'C :> Selector>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> SelectionChangedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2,'T3 when 'C :> Selector>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> SelectionChangedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.SelectionChanged))

    member x.SelectionChanged<'C,'T when 'C :> Selector>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> SelectionChangedEventHandler(h)),fn,binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2 when 'C :> Selector>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> SelectionChangedEventHandler(h)),fn,binder.Control.SelectionChanged))
    member x.SelectionChanged<'C,'T1,'T2,'T3 when 'C :> Selector>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> SelectionChangedEventHandler(h)),fn,binder.Control.SelectionChanged))
    


type ListBoxBuilder() =

    inherit SelectorBuilder()
                

    member x.Yield(_) = new ControlBinder<ListBox>(ListBox())
    member x.Run(w:ControlBinder<ListBox>) = w :> IControlBinder

    [<CustomOperation("selectedItems")>]
    member __.SelectedItems<'C,'T when 'C :> ListBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr ListBox.SelectedItemsProperty)  
    member __.SelectedItems<'C,'TP,'TC when 'C :> ListBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap ListBox.SelectedItemsProperty)
    member __.SelectedItems<'C,'T1,'T2,'TC when 'C :> ListBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap ListBox.SelectedItemsProperty)
    member __.SelectedItems<'C,'T1,'T2,'T3,'TC when 'C :> ListBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap ListBox.SelectedItemsProperty)

    [<CustomOperation("selectionMode")>]
    member __.SelectionMode<'C when 'C :> ListBox>(binder:ControlBinder<'C>,v:SelectionMode) = binder.Control.SelectionMode <- v ; binder
    
    member __.SelectionMode<'C,'T when 'C :> ListBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ListBox.SelectionModeProperty)
    member __.SelectionMode<'C,'TP,'TC when 'C :> ListBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ListBox.SelectionModeProperty)
    member __.SelectionMode<'C,'T1,'T2,'TC when 'C :> ListBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ListBox.SelectionModeProperty)
    member __.SelectionMode<'C,'T1,'T2,'T3,'TC when 'C :> ListBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ListBox.SelectionModeProperty)
    

let listBox  = ListBoxBuilder()

type ComboBoxBuilder() =

    inherit SelectorBuilder()
                

    member x.Yield(_) = new ControlBinder<ComboBox>(ComboBox())
    member x.Run(w:ControlBinder<ComboBox>) = w :> IControlBinder

    [<CustomOperation("shouldPreserveUserEnteredPrefix")>]
    member __.ShouldPreserveUserEnteredPrefix<'C when 'C :> ComboBox>(binder:ControlBinder<'C>,v:bool) = binder.Control.ShouldPreserveUserEnteredPrefix <- v ; binder
    
    member __.ShouldPreserveUserEnteredPrefix<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ComboBox.ShouldPreserveUserEnteredPrefixProperty)
    member __.ShouldPreserveUserEnteredPrefix<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ComboBox.ShouldPreserveUserEnteredPrefixProperty)
    member __.ShouldPreserveUserEnteredPrefix<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ComboBox.ShouldPreserveUserEnteredPrefixProperty)
    member __.ShouldPreserveUserEnteredPrefix<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ComboBox.ShouldPreserveUserEnteredPrefixProperty)
    

    [<CustomOperation("isEditable")>]
    member __.IsEditable<'C when 'C :> ComboBox>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsEditable <- v ; binder
    
    member __.IsEditable<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ComboBox.IsEditableProperty)
    member __.IsEditable<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ComboBox.IsEditableProperty)
    member __.IsEditable<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ComboBox.IsEditableProperty)
    member __.IsEditable<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ComboBox.IsEditableProperty)
    

    [<CustomOperation("text")>]
    member __.Text<'C when 'C :> ComboBox>(binder:ControlBinder<'C>,v:string) = binder.Control.Text <- v ; binder
    
    member __.Text<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ComboBox.TextProperty)
    member __.Text<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ComboBox.TextProperty)
    member __.Text<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ComboBox.TextProperty)
    member __.Text<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ComboBox.TextProperty)
    

    [<CustomOperation("isReadOnly")>]
    member __.IsReadOnly<'C when 'C :> ComboBox>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsReadOnly <- v ; binder
    
    member __.IsReadOnly<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ComboBox.IsReadOnlyProperty)
    member __.IsReadOnly<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ComboBox.IsReadOnlyProperty)
    member __.IsReadOnly<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ComboBox.IsReadOnlyProperty)
    member __.IsReadOnly<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ComboBox.IsReadOnlyProperty)
    

    [<CustomOperation("selectionBoxItem")>]
    member __.SelectionBoxItem<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr ComboBox.SelectionBoxItemProperty)  
    member __.SelectionBoxItem<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap ComboBox.SelectionBoxItemProperty)
    member __.SelectionBoxItem<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap ComboBox.SelectionBoxItemProperty)
    member __.SelectionBoxItem<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap ComboBox.SelectionBoxItemProperty)

    [<CustomOperation("maxDropDownHeight")>]
    member __.MaxDropDownHeight<'C when 'C :> ComboBox>(binder:ControlBinder<'C>,v:double) = binder.Control.MaxDropDownHeight <- v ; binder
    
    member __.MaxDropDownHeight<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ComboBox.MaxDropDownHeightProperty)
    member __.MaxDropDownHeight<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ComboBox.MaxDropDownHeightProperty)
    member __.MaxDropDownHeight<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ComboBox.MaxDropDownHeightProperty)
    member __.MaxDropDownHeight<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ComboBox.MaxDropDownHeightProperty)
    

    [<CustomOperation("selectionBoxItemStringFormat")>]
    member __.SelectionBoxItemStringFormat<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr ComboBox.SelectionBoxItemStringFormatProperty)  
    member __.SelectionBoxItemStringFormat<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap ComboBox.SelectionBoxItemStringFormatProperty)
    member __.SelectionBoxItemStringFormat<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap ComboBox.SelectionBoxItemStringFormatProperty)
    member __.SelectionBoxItemStringFormat<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap ComboBox.SelectionBoxItemStringFormatProperty)

    [<CustomOperation("staysOpenOnEdit")>]
    member __.StaysOpenOnEdit<'C when 'C :> ComboBox>(binder:ControlBinder<'C>,v:bool) = binder.Control.StaysOpenOnEdit <- v ; binder
    
    member __.StaysOpenOnEdit<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ComboBox.StaysOpenOnEditProperty)
    member __.StaysOpenOnEdit<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ComboBox.StaysOpenOnEditProperty)
    member __.StaysOpenOnEdit<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ComboBox.StaysOpenOnEditProperty)
    member __.StaysOpenOnEdit<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ComboBox.StaysOpenOnEditProperty)
    

    [<CustomOperation("isDropDownOpen")>]
    member __.IsDropDownOpen<'C when 'C :> ComboBox>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsDropDownOpen <- v ; binder
    
    member __.IsDropDownOpen<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ComboBox.IsDropDownOpenProperty)
    member __.IsDropDownOpen<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ComboBox.IsDropDownOpenProperty)
    member __.IsDropDownOpen<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ComboBox.IsDropDownOpenProperty)
    member __.IsDropDownOpen<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ComboBox.IsDropDownOpenProperty)
    

    [<CustomOperation("selectionBoxItemTemplate")>]
    member __.SelectionBoxItemTemplate<'C,'T when 'C :> ComboBox>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr ComboBox.SelectionBoxItemTemplateProperty)  
    member __.SelectionBoxItemTemplate<'C,'TP,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap ComboBox.SelectionBoxItemTemplateProperty)
    member __.SelectionBoxItemTemplate<'C,'T1,'T2,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap ComboBox.SelectionBoxItemTemplateProperty)
    member __.SelectionBoxItemTemplate<'C,'T1,'T2,'T3,'TC when 'C :> ComboBox>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap ComboBox.SelectionBoxItemTemplateProperty)

let comboBox  = ComboBoxBuilder()

type GridBuilder() =

    inherit PanelBuilder()
                

    member x.Yield(_) = new ControlBinder<Grid>(Grid())
    member x.Run(w:ControlBinder<Grid>) = w :> IControlBinder

    [<CustomOperation("cell")>]
    member __.Cell<'C,'T when 'C :> Grid>(binder:ControlBinder<'C>,(row:int,col:int,child:IControlBinder)) = 
        while binder.Control.RowDefinitions.Count <= row do binder.Control.RowDefinitions.Add(RowDefinition())
        while binder.Control.ColumnDefinitions.Count <= col do binder.Control.ColumnDefinitions.Add(ColumnDefinition())
        binder.Control.Children.Add child.UIElement |> ignore
        child.UIElement.SetValue(Grid.RowProperty,row)
        child.UIElement.SetValue(Grid.ColumnProperty,col)
        binder.AddChildBinder child
        binder

    member __.Cell<'C,'T when 'C :> Grid>(binder:ControlBinder<'C>,(rowExpr:Expr<int>,colExpr:Expr<int>,child:IControlBinder)) = 
        binder.Collect(fun env control ->
        binder.AddChildBinder child
        let row = env.AddExpr<int>(rowExpr)
        let col = env.AddExpr<int>(colExpr)
        while control.RowDefinitions.Count <= row.Get do control.RowDefinitions.Add(RowDefinition())
        while control.ColumnDefinitions.Count <= col.Get do control.ColumnDefinitions.Add(ColumnDefinition())
        let ui = child.UIElement
        control.Children.Add child.UIElement |> ignore
        ui.SetValue(Grid.RowProperty,row.Get)
        ui.SetValue(Grid.ColumnProperty,col.Get)
        row.Subscribe(fun r -> 
            while control.RowDefinitions.Count <= r do control.RowDefinitions.Add(RowDefinition())
            ui.SetValue(Grid.RowProperty,r))
        col.Subscribe(fun c ->
            while control.ColumnDefinitions.Count <= c do control.ColumnDefinitions.Add(ColumnDefinition())
            ui.SetValue(Grid.ColumnProperty,c))
            )

    [<CustomOperation("showGridLines")>]
    member __.ShowGridLines<'C when 'C :> Grid>(binder:ControlBinder<'C>,v:bool) = binder.Control.ShowGridLines <- v ; binder
    
    member __.ShowGridLines<'C,'T when 'C :> Grid>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Grid.ShowGridLinesProperty)
    member __.ShowGridLines<'C,'TP,'TC when 'C :> Grid>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Grid.ShowGridLinesProperty)
    member __.ShowGridLines<'C,'T1,'T2,'TC when 'C :> Grid>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Grid.ShowGridLinesProperty)
    member __.ShowGridLines<'C,'T1,'T2,'T3,'TC when 'C :> Grid>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Grid.ShowGridLinesProperty)
    

let grid  = GridBuilder()

type ToggleButtonBuilder() =

    inherit ButtonBaseBuilder()
                

    [<CustomOperation("isThreeState")>]
    member __.IsThreeState<'C when 'C :> ToggleButton>(binder:ControlBinder<'C>,v:bool) = binder.Control.IsThreeState <- v ; binder
    
    member __.IsThreeState<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ToggleButton.IsThreeStateProperty)
    member __.IsThreeState<'C,'TP,'TC when 'C :> ToggleButton>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ToggleButton.IsThreeStateProperty)
    member __.IsThreeState<'C,'T1,'T2,'TC when 'C :> ToggleButton>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ToggleButton.IsThreeStateProperty)
    member __.IsThreeState<'C,'T1,'T2,'T3,'TC when 'C :> ToggleButton>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ToggleButton.IsThreeStateProperty)
    

    [<CustomOperation("isChecked")>]
    member __.IsChecked<'C when 'C :> ToggleButton>(binder:ControlBinder<'C>,v:Nullable<bool>) = binder.Control.IsChecked <- v ; binder
    
    member __.IsChecked<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr ToggleButton.IsCheckedProperty)
    member __.IsChecked<'C,'TP,'TC when 'C :> ToggleButton>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap ToggleButton.IsCheckedProperty)
    member __.IsChecked<'C,'T1,'T2,'TC when 'C :> ToggleButton>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap ToggleButton.IsCheckedProperty)
    member __.IsChecked<'C,'T1,'T2,'T3,'TC when 'C :> ToggleButton>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap ToggleButton.IsCheckedProperty)
    

    [<CustomOperation("onChecked")>]  
    member x.Checked<'C when 'C :> ToggleButton>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.Checked))
    member x.Checked<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.Checked))
    member x.Checked<'C,'T1,'T2 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.Checked))
    member x.Checked<'C,'T1,'T2,'T3 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.Checked))

    member x.Checked<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Checked))
    member x.Checked<'C,'T1,'T2 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Checked))
    member x.Checked<'C,'T1,'T2,'T3 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Checked))
    



    [<CustomOperation("onIndeterminate")>]  
    member x.Indeterminate<'C when 'C :> ToggleButton>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.Indeterminate))
    member x.Indeterminate<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.Indeterminate))
    member x.Indeterminate<'C,'T1,'T2 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.Indeterminate))
    member x.Indeterminate<'C,'T1,'T2,'T3 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.Indeterminate))

    member x.Indeterminate<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Indeterminate))
    member x.Indeterminate<'C,'T1,'T2 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Indeterminate))
    member x.Indeterminate<'C,'T1,'T2,'T3 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Indeterminate))
    



    [<CustomOperation("onUnchecked")>]  
    member x.Unchecked<'C when 'C :> ToggleButton>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(RoutedEventHandler(fn),binder.Control.Unchecked))
    member x.Unchecked<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> RoutedEventHandler(fun s a -> fn s a |> pt.Set)),binder.Control.Unchecked))
    member x.Unchecked<'C,'T1,'T2 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> RoutedEventHandler(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.Unchecked))
    member x.Unchecked<'C,'T1,'T2,'T3 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> RoutedEventHandler(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.Unchecked))

    member x.Unchecked<'C,'T when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Unchecked))
    member x.Unchecked<'C,'T1,'T2 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Unchecked))
    member x.Unchecked<'C,'T1,'T2,'T3 when 'C :> ToggleButton>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> RoutedEventHandler(h)),fn,binder.Control.Unchecked))
    


type CheckBoxBuilder() =

    inherit ToggleButtonBuilder()
                

    member x.Yield(_) = new ControlBinder<CheckBox>(CheckBox())
    member x.Run(w:ControlBinder<CheckBox>) = w :> IControlBinder

let checkBox  = CheckBoxBuilder()

type DecoratorBuilder() =
    

    inherit FrameworkElementBuilder()
                
type BorderBuilder() =

    inherit DecoratorBuilder()
    
    [<CustomOperation("child")>]
    member __.Child<'C when 'C :> Decorator>(binder:ControlBinder<'C>,child:IControlBinder) = 
        binder.AddChildBinder child
        binder.Control.Child <- child.UIElement 
        binder
    
    member x.Yield(_) = new ControlBinder<Border>(Border())
    member x.Run(w:ControlBinder<Border>) = w :> IControlBinder

    [<CustomOperation("borderThickness")>]
    member __.BorderThickness<'C when 'C :> Border>(binder:ControlBinder<'C>,v:Thickness) = binder.Control.BorderThickness <- v ; binder
    
    member __.BorderThickness<'C,'T when 'C :> Border>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Border.BorderThicknessProperty)
    member __.BorderThickness<'C,'TP,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Border.BorderThicknessProperty)
    member __.BorderThickness<'C,'T1,'T2,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Border.BorderThicknessProperty)
    member __.BorderThickness<'C,'T1,'T2,'T3,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Border.BorderThicknessProperty)
    

    [<CustomOperation("padding")>]
    member __.Padding<'C when 'C :> Border>(binder:ControlBinder<'C>,v:Thickness) = binder.Control.Padding <- v ; binder
    
    member __.Padding<'C,'T when 'C :> Border>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Border.PaddingProperty)
    member __.Padding<'C,'TP,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Border.PaddingProperty)
    member __.Padding<'C,'T1,'T2,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Border.PaddingProperty)
    member __.Padding<'C,'T1,'T2,'T3,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Border.PaddingProperty)
    

    [<CustomOperation("cornerRadius")>]
    member __.CornerRadius<'C when 'C :> Border>(binder:ControlBinder<'C>,v:CornerRadius) = binder.Control.CornerRadius <- v ; binder
    
    member __.CornerRadius<'C,'T when 'C :> Border>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Border.CornerRadiusProperty)
    member __.CornerRadius<'C,'TP,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Border.CornerRadiusProperty)
    member __.CornerRadius<'C,'T1,'T2,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Border.CornerRadiusProperty)
    member __.CornerRadius<'C,'T1,'T2,'T3,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Border.CornerRadiusProperty)
    

    [<CustomOperation("borderBrush")>]
    member __.BorderBrush<'C when 'C :> Border>(binder:ControlBinder<'C>,v:Brush) = binder.Control.BorderBrush <- v ; binder
    
    member __.BorderBrush<'C,'T when 'C :> Border>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Border.BorderBrushProperty)
    member __.BorderBrush<'C,'TP,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Border.BorderBrushProperty)
    member __.BorderBrush<'C,'T1,'T2,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Border.BorderBrushProperty)
    member __.BorderBrush<'C,'T1,'T2,'T3,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Border.BorderBrushProperty)
    

    [<CustomOperation("background")>]
    member __.Background<'C when 'C :> Border>(binder:ControlBinder<'C>,v:Brush) = binder.Control.Background <- v ; binder
    
    member __.Background<'C,'T when 'C :> Border>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Border.BackgroundProperty)
    member __.Background<'C,'TP,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Border.BackgroundProperty)
    member __.Background<'C,'T1,'T2,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Border.BackgroundProperty)
    member __.Background<'C,'T1,'T2,'T3,'TC when 'C :> Border>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Border.BackgroundProperty)
    

let border  = BorderBuilder()

type ImageBuilder() =

    inherit FrameworkElementBuilder()
                

    member x.Yield(_) = new ControlBinder<Image>(Image())
    member x.Run(w:ControlBinder<Image>) = w :> IControlBinder

    [<CustomOperation("source")>]
    member __.Source<'C when 'C :> Image>(binder:ControlBinder<'C>,v:ImageSource) = binder.Control.Source <- v ; binder
    
    member __.Source<'C,'T when 'C :> Image>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Image.SourceProperty)
    member __.Source<'C,'TP,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Image.SourceProperty)
    member __.Source<'C,'T1,'T2,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Image.SourceProperty)
    member __.Source<'C,'T1,'T2,'T3,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Image.SourceProperty)
    

    [<CustomOperation("stretch")>]
    member __.Stretch<'C when 'C :> Image>(binder:ControlBinder<'C>,v:Stretch) = binder.Control.Stretch <- v ; binder
    
    member __.Stretch<'C,'T when 'C :> Image>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Image.StretchProperty)
    member __.Stretch<'C,'TP,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Image.StretchProperty)
    member __.Stretch<'C,'T1,'T2,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Image.StretchProperty)
    member __.Stretch<'C,'T1,'T2,'T3,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Image.StretchProperty)
    

    [<CustomOperation("stretchDirection")>]
    member __.StretchDirection<'C when 'C :> Image>(binder:ControlBinder<'C>,v:StretchDirection) = binder.Control.StretchDirection <- v ; binder
    
    member __.StretchDirection<'C,'T when 'C :> Image>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Image.StretchDirectionProperty)
    member __.StretchDirection<'C,'TP,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Image.StretchDirectionProperty)
    member __.StretchDirection<'C,'T1,'T2,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Image.StretchDirectionProperty)
    member __.StretchDirection<'C,'T1,'T2,'T3,'TC when 'C :> Image>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Image.StretchDirectionProperty)
    

    [<CustomOperation("onImageFailed")>]  
    member x.ImageFailed<'C when 'C :> Image>(binder:ControlBinder<'C>,fn:obj -> _ -> unit ) = binder.Collect(callEvent<_,_,_>(EventHandler<ExceptionRoutedEventArgs>(fn),binder.Control.ImageFailed))
    member x.ImageFailed<'C,'T when 'C :> Image>(binder:ControlBinder<'C>,(target:Expr<'T>,fn:obj -> _ -> 'T)) = binder.Collect(bindEvent1<_,_,_,_>(target,(fun pt -> EventHandler<ExceptionRoutedEventArgs>(fun s a -> fn s a |> pt.Set)),binder.Control.ImageFailed))
    member x.ImageFailed<'C,'T1,'T2 when 'C :> Image>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> 'T1 * 'T2 )) = binder.Collect(bindEvent2<_,_,_,_,_>(target1,target2,(fun (pt1,pt2) -> EventHandler<ExceptionRoutedEventArgs>(fun s a -> let v1,v2 = fn s a in pt1.Set v1 ; pt2.Set v2)),binder.Control.ImageFailed))
    member x.ImageFailed<'C,'T1,'T2,'T3 when 'C :> Image>(binder:ControlBinder<'C>,(target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> 'T1 * 'T2 * 'T3)) = binder.Collect(bindEvent3<_,_,_,_,_,_>(target1,target2,target3,(fun (pt1,pt2,pt3) -> EventHandler<ExceptionRoutedEventArgs>(fun s a -> let v1,v2,v3 = fn s a in pt1.Set v1 ; pt2.Set v2 ; pt3.Set v3)),binder.Control.ImageFailed))

    member x.ImageFailed<'C,'T when 'C :> Image>(binder:ControlBinder<'C>,(work:Expr<Work>,target:Expr<'T>,fn:obj -> _ -> CancellationToken -> Task<'T>)) = binder.Collect(bindWorkEvent1<_,_,_,_>(work,target,(fun h -> EventHandler<ExceptionRoutedEventArgs>(h)),fn,binder.Control.ImageFailed))
    member x.ImageFailed<'C,'T1,'T2 when 'C :> Image>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2>)) = binder.Collect(bindWorkEvent2<_,_,_,_,_>(work,target1,target2,(fun h -> EventHandler<ExceptionRoutedEventArgs>(h)),fn,binder.Control.ImageFailed))
    member x.ImageFailed<'C,'T1,'T2,'T3 when 'C :> Image>(binder:ControlBinder<'C>,(work:Expr<Work>,target1:Expr<'T1>,target2:Expr<'T2>,target3:Expr<'T3>,fn:obj -> _ -> CancellationToken -> Task<'T1 * 'T2 * 'T3>)) = binder.Collect(bindWorkEvent3<_,_,_,_,_,_>(work,target1,target2,target3,(fun h -> EventHandler<ExceptionRoutedEventArgs>(h)),fn,binder.Control.ImageFailed))
    



let image  = ImageBuilder()

type RadioButtonBuilder() =

    inherit ToggleButtonBuilder()
                

    member x.Yield(_) = new ControlBinder<RadioButton>(RadioButton())
    member x.Run(w:ControlBinder<RadioButton>) = w :> IControlBinder

    [<CustomOperation("groupName")>]
    member __.GroupName<'C when 'C :> RadioButton>(binder:ControlBinder<'C>,v:string) = binder.Control.GroupName <- v ; binder
    
    member __.GroupName<'C,'T when 'C :> RadioButton>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr RadioButton.GroupNameProperty)
    member __.GroupName<'C,'TP,'TC when 'C :> RadioButton>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap RadioButton.GroupNameProperty)
    member __.GroupName<'C,'T1,'T2,'TC when 'C :> RadioButton>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap RadioButton.GroupNameProperty)
    member __.GroupName<'C,'T1,'T2,'T3,'TC when 'C :> RadioButton>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap RadioButton.GroupNameProperty)
    

let radioButton  = RadioButtonBuilder()

type WrapPanelBuilder() =

    inherit PanelBuilder()
                

    member x.Yield(_) = new ControlBinder<WrapPanel>(WrapPanel())
    member x.Run(w:ControlBinder<WrapPanel>) = w :> IControlBinder

    [<CustomOperation("itemWidth")>]
    member __.ItemWidth<'C when 'C :> WrapPanel>(binder:ControlBinder<'C>,v:double) = binder.Control.ItemWidth <- v ; binder
    
    member __.ItemWidth<'C,'T when 'C :> WrapPanel>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr WrapPanel.ItemWidthProperty)
    member __.ItemWidth<'C,'TP,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap WrapPanel.ItemWidthProperty)
    member __.ItemWidth<'C,'T1,'T2,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap WrapPanel.ItemWidthProperty)
    member __.ItemWidth<'C,'T1,'T2,'T3,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap WrapPanel.ItemWidthProperty)
    

    [<CustomOperation("itemHeight")>]
    member __.ItemHeight<'C when 'C :> WrapPanel>(binder:ControlBinder<'C>,v:double) = binder.Control.ItemHeight <- v ; binder
    
    member __.ItemHeight<'C,'T when 'C :> WrapPanel>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr WrapPanel.ItemHeightProperty)
    member __.ItemHeight<'C,'TP,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap WrapPanel.ItemHeightProperty)
    member __.ItemHeight<'C,'T1,'T2,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap WrapPanel.ItemHeightProperty)
    member __.ItemHeight<'C,'T1,'T2,'T3,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap WrapPanel.ItemHeightProperty)
    

    [<CustomOperation("orientation")>]
    member __.Orientation<'C when 'C :> WrapPanel>(binder:ControlBinder<'C>,v:Orientation) = binder.Control.Orientation <- v ; binder
    
    member __.Orientation<'C,'T when 'C :> WrapPanel>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr WrapPanel.OrientationProperty)
    member __.Orientation<'C,'TP,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap WrapPanel.OrientationProperty)
    member __.Orientation<'C,'T1,'T2,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap WrapPanel.OrientationProperty)
    member __.Orientation<'C,'T1,'T2,'T3,'TC when 'C :> WrapPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap WrapPanel.OrientationProperty)
    

let wrapPanel  = WrapPanelBuilder()

type DockPanelBuilder() =

    inherit PanelBuilder()
                

    member x.Yield(_) = new ControlBinder<DockPanel>(DockPanel())
    member x.Run(w:ControlBinder<DockPanel>) = w :> IControlBinder

    [<CustomOperation("lastChildFill")>]
    member __.LastChildFill<'C when 'C :> DockPanel>(binder:ControlBinder<'C>,v:bool) = binder.Control.LastChildFill <- v ; binder
    
    member __.LastChildFill<'C,'T when 'C :> DockPanel>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr DockPanel.LastChildFillProperty)
    member __.LastChildFill<'C,'TP,'TC when 'C :> DockPanel>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap DockPanel.LastChildFillProperty)
    member __.LastChildFill<'C,'T1,'T2,'TC when 'C :> DockPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap DockPanel.LastChildFillProperty)
    member __.LastChildFill<'C,'T1,'T2,'T3,'TC when 'C :> DockPanel>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap DockPanel.LastChildFillProperty)
    

let dockPanel  = DockPanelBuilder()

type TabControlBuilder() =

    inherit SelectorBuilder()
                

    member x.Yield(_) = new ControlBinder<TabControl>(TabControl())
    member x.Run(w:ControlBinder<TabControl>) = w :> IControlBinder

    [<CustomOperation("contentTemplate")>]
    member __.ContentTemplate<'C when 'C :> TabControl>(binder:ControlBinder<'C>,v:DataTemplate) = binder.Control.ContentTemplate <- v ; binder
    
    member __.ContentTemplate<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TabControl.ContentTemplateProperty)
    member __.ContentTemplate<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TabControl.ContentTemplateProperty)
    member __.ContentTemplate<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TabControl.ContentTemplateProperty)
    member __.ContentTemplate<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TabControl.ContentTemplateProperty)
    

    [<CustomOperation("selectedContentStringFormat")>]
    member __.SelectedContentStringFormat<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr TabControl.SelectedContentStringFormatProperty)  
    member __.SelectedContentStringFormat<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap TabControl.SelectedContentStringFormatProperty)
    member __.SelectedContentStringFormat<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap TabControl.SelectedContentStringFormatProperty)
    member __.SelectedContentStringFormat<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap TabControl.SelectedContentStringFormatProperty)

    [<CustomOperation("selectedContentTemplateSelector")>]
    member __.SelectedContentTemplateSelector<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr TabControl.SelectedContentTemplateSelectorProperty)  
    member __.SelectedContentTemplateSelector<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap TabControl.SelectedContentTemplateSelectorProperty)
    member __.SelectedContentTemplateSelector<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap TabControl.SelectedContentTemplateSelectorProperty)
    member __.SelectedContentTemplateSelector<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap TabControl.SelectedContentTemplateSelectorProperty)

    [<CustomOperation("selectedContentTemplate")>]
    member __.SelectedContentTemplate<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr TabControl.SelectedContentTemplateProperty)  
    member __.SelectedContentTemplate<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap TabControl.SelectedContentTemplateProperty)
    member __.SelectedContentTemplate<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap TabControl.SelectedContentTemplateProperty)
    member __.SelectedContentTemplate<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap TabControl.SelectedContentTemplateProperty)

    [<CustomOperation("selectedContent")>]
    member __.SelectedContent<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr TabControl.SelectedContentProperty)  
    member __.SelectedContent<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap TabControl.SelectedContentProperty)
    member __.SelectedContent<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap TabControl.SelectedContentProperty)
    member __.SelectedContent<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap TabControl.SelectedContentProperty)

    [<CustomOperation("tabStripPlacement")>]
    member __.TabStripPlacement<'C when 'C :> TabControl>(binder:ControlBinder<'C>,v:Dock) = binder.Control.TabStripPlacement <- v ; binder
    
    member __.TabStripPlacement<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TabControl.TabStripPlacementProperty)
    member __.TabStripPlacement<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TabControl.TabStripPlacementProperty)
    member __.TabStripPlacement<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TabControl.TabStripPlacementProperty)
    member __.TabStripPlacement<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TabControl.TabStripPlacementProperty)
    

    [<CustomOperation("contentStringFormat")>]
    member __.ContentStringFormat<'C when 'C :> TabControl>(binder:ControlBinder<'C>,v:string) = binder.Control.ContentStringFormat <- v ; binder
    
    member __.ContentStringFormat<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TabControl.ContentStringFormatProperty)
    member __.ContentStringFormat<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TabControl.ContentStringFormatProperty)
    member __.ContentStringFormat<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TabControl.ContentStringFormatProperty)
    member __.ContentStringFormat<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TabControl.ContentStringFormatProperty)
    

    [<CustomOperation("contentTemplateSelector")>]
    member __.ContentTemplateSelector<'C when 'C :> TabControl>(binder:ControlBinder<'C>,v:DataTemplateSelector) = binder.Control.ContentTemplateSelector <- v ; binder
    
    member __.ContentTemplateSelector<'C,'T when 'C :> TabControl>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr TabControl.ContentTemplateSelectorProperty)
    member __.ContentTemplateSelector<'C,'TP,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap TabControl.ContentTemplateSelectorProperty)
    member __.ContentTemplateSelector<'C,'T1,'T2,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap TabControl.ContentTemplateSelectorProperty)
    member __.ContentTemplateSelector<'C,'T1,'T2,'T3,'TC when 'C :> TabControl>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap TabControl.ContentTemplateSelectorProperty)
    

let tabControl  = TabControlBuilder()

type CanvasBuilder() =

    inherit PanelBuilder()
                

    member x.Yield(_) = new ControlBinder<Canvas>(Canvas())
    member x.Run(w:ControlBinder<Canvas>) = w :> IControlBinder

let canvas  = CanvasBuilder()

type WindowBuilder() =

    inherit ContentControlBuilder()
                

    member x.Yield(_) = new ControlBinder<Window>(Window())
    member x.Run(binder:ControlBinder<Window>) = 
        let env = new Env()
        (binder :> IControlBinder).ApplyEnv env
        binder.Control.Unloaded.AddHandler (fun _ _ -> (env :> IDisposable).Dispose())
        binder.Control

    [<CustomOperation("isActive")>]
    member __.IsActive<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetGetX expr Window.IsActiveProperty)  
    member __.IsActive<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP)) = binder.Collect(propMapTargetGetX expr setMap Window.IsActiveProperty)
    member __.IsActive<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2))) = binder.Collect(propMapTargetGet2X expr1 expr2 setMap Window.IsActiveProperty)
    member __.IsActive<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3))) = binder.Collect(propMapTargetGet3X expr1 expr2 expr3 setMap Window.IsActiveProperty)

    [<CustomOperation("showInTaskbar")>]
    member __.ShowInTaskbar<'C when 'C :> Window>(binder:ControlBinder<'C>,v:bool) = binder.Control.ShowInTaskbar <- v ; binder
    
    member __.ShowInTaskbar<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.ShowInTaskbarProperty)
    member __.ShowInTaskbar<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.ShowInTaskbarProperty)
    member __.ShowInTaskbar<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.ShowInTaskbarProperty)
    member __.ShowInTaskbar<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.ShowInTaskbarProperty)
    

    [<CustomOperation("windowStartupLocation")>]
    member __.WindowStartupLocation<'C when 'C :> Window>(binder:ControlBinder<'C>,v:WindowStartupLocation) = binder.Control.WindowStartupLocation <- v ; binder

    [<CustomOperation("taskbarItemInfo")>]
    member __.TaskbarItemInfo<'C when 'C :> Window>(binder:ControlBinder<'C>,v:TaskbarItemInfo) = binder.Control.TaskbarItemInfo <- v ; binder
    
    member __.TaskbarItemInfo<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.TaskbarItemInfoProperty)
    member __.TaskbarItemInfo<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.TaskbarItemInfoProperty)
    member __.TaskbarItemInfo<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.TaskbarItemInfoProperty)
    member __.TaskbarItemInfo<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.TaskbarItemInfoProperty)
    

    [<CustomOperation("top")>]
    member __.Top<'C when 'C :> Window>(binder:ControlBinder<'C>,v:double) = binder.Control.Top <- v ; binder
    
    member __.Top<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.TopProperty)
    member __.Top<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.TopProperty)
    member __.Top<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.TopProperty)
    member __.Top<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.TopProperty)
    

    [<CustomOperation("sizeToContent")>]
    member __.SizeToContent<'C when 'C :> Window>(binder:ControlBinder<'C>,v:SizeToContent) = binder.Control.SizeToContent <- v ; binder
    
    member __.SizeToContent<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.SizeToContentProperty)
    member __.SizeToContent<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.SizeToContentProperty)
    member __.SizeToContent<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.SizeToContentProperty)
    member __.SizeToContent<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.SizeToContentProperty)
    

    [<CustomOperation("allowsTransparency")>]
    member __.AllowsTransparency<'C when 'C :> Window>(binder:ControlBinder<'C>,v:bool) = binder.Control.AllowsTransparency <- v ; binder
    
    member __.AllowsTransparency<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.AllowsTransparencyProperty)
    member __.AllowsTransparency<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.AllowsTransparencyProperty)
    member __.AllowsTransparency<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.AllowsTransparencyProperty)
    member __.AllowsTransparency<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.AllowsTransparencyProperty)
    

    [<CustomOperation("owner")>]
    member __.Owner<'C when 'C :> Window>(binder:ControlBinder<'C>,v:Window) = binder.Control.Owner <- v ; binder

    [<CustomOperation("left")>]
    member __.Left<'C when 'C :> Window>(binder:ControlBinder<'C>,v:double) = binder.Control.Left <- v ; binder
    
    member __.Left<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.LeftProperty)
    member __.Left<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.LeftProperty)
    member __.Left<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.LeftProperty)
    member __.Left<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.LeftProperty)
    

    [<CustomOperation("icon")>]
    member __.Icon<'C when 'C :> Window>(binder:ControlBinder<'C>,v:ImageSource) = binder.Control.Icon <- v ; binder
    
    member __.Icon<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.IconProperty)
    member __.Icon<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.IconProperty)
    member __.Icon<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.IconProperty)
    member __.Icon<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.IconProperty)
    

    [<CustomOperation("windowStyle")>]
    member __.WindowStyle<'C when 'C :> Window>(binder:ControlBinder<'C>,v:WindowStyle) = binder.Control.WindowStyle <- v ; binder
    
    member __.WindowStyle<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.WindowStyleProperty)
    member __.WindowStyle<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.WindowStyleProperty)
    member __.WindowStyle<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.WindowStyleProperty)
    member __.WindowStyle<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.WindowStyleProperty)
    

    [<CustomOperation("windowState")>]
    member __.WindowState<'C when 'C :> Window>(binder:ControlBinder<'C>,v:WindowState) = binder.Control.WindowState <- v ; binder
    
    member __.WindowState<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.WindowStateProperty)
    member __.WindowState<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.WindowStateProperty)
    member __.WindowState<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.WindowStateProperty)
    member __.WindowState<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.WindowStateProperty)
    

    [<CustomOperation("resizeMode")>]
    member __.ResizeMode<'C when 'C :> Window>(binder:ControlBinder<'C>,v:ResizeMode) = binder.Control.ResizeMode <- v ; binder
    
    member __.ResizeMode<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.ResizeModeProperty)
    member __.ResizeMode<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.ResizeModeProperty)
    member __.ResizeMode<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.ResizeModeProperty)
    member __.ResizeMode<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.ResizeModeProperty)
    

    [<CustomOperation("topmost")>]
    member __.Topmost<'C when 'C :> Window>(binder:ControlBinder<'C>,v:bool) = binder.Control.Topmost <- v ; binder
    
    member __.Topmost<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.TopmostProperty)
    member __.Topmost<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.TopmostProperty)
    member __.Topmost<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.TopmostProperty)
    member __.Topmost<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.TopmostProperty)
    

    [<CustomOperation("showActivated")>]
    member __.ShowActivated<'C when 'C :> Window>(binder:ControlBinder<'C>,v:bool) = binder.Control.ShowActivated <- v ; binder
    
    member __.ShowActivated<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.ShowActivatedProperty)
    member __.ShowActivated<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.ShowActivatedProperty)
    member __.ShowActivated<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.ShowActivatedProperty)
    member __.ShowActivated<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.ShowActivatedProperty)
    

    [<CustomOperation("title")>]
    member __.Title<'C when 'C :> Window>(binder:ControlBinder<'C>,v:string) = binder.Control.Title <- v ; binder
    
    member __.Title<'C,'T when 'C :> Window>(binder:ControlBinder<'C>,expr:Expr<'T>) = binder.Collect(propTargetBindX expr Window.TitleProperty)
    member __.Title<'C,'TP,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr:Expr<'TP>,setMap:'TC->'TP,getMap:'TP->'TC)) = binder.Collect(propMapTargetBindX expr getMap setMap Window.TitleProperty)
    member __.Title<'C,'T1,'T2,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,setMap:'TC -> ('T1 * 'T2),getMap:('T1 * 'T2) ->'TC)) = binder.Collect(propMapTargetBind2X expr1 expr2 getMap setMap Window.TitleProperty)
    member __.Title<'C,'T1,'T2,'T3,'TC when 'C :> Window>(binder:ControlBinder<'C>,(expr1:Expr<'T1>,expr2:Expr<'T2>,expr3:Expr<'T3>,setMap:'TC -> ('T1 * 'T2 * 'T3),getMap:('T1 * 'T2 * 'T3) ->'TC)) = binder.Collect(propMapTargetBind3X expr1 expr2 expr3 getMap setMap Window.TitleProperty)
    

    [<CustomOperation("dialogResult")>]
    member __.DialogResult<'C when 'C :> Window>(binder:ControlBinder<'C>,v:Nullable<bool>) = binder.Control.DialogResult <- v ; binder

let window  = WindowBuilder()

