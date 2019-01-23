

open System
open System.Windows;
open System.Windows.Controls;
open System.Windows.Data;
open System.Collections.Generic
open System.ComponentModel
open System.Windows.Threading
open System.Threading.Tasks
open System.Threading
open System.Windows
open System.Windows.Markup
open System.Windows.Input
open System.Windows.Media
open System.Collections
open CExpressions
open Binding
open System.Collections.ObjectModel
open Microsoft.FSharp.Quotations
open System.Collections.Specialized


type OSeq<'T> = ObservableCollection<'T>
        
type SubModel = {
    mutable Value1:string
    mutable Counter:int
    mutable MyRow : int
    mutable MyCol : int
}

type MyModel = {
    mutable Message:string
    mutable FontSize:float
    mutable VariableCount : int
    mutable Items:OSeq<string>
    mutable Selected:obj
    Submodel :SubModel
}

let myGridTest (model:SubModel) = 
    border {
        borderThickness (Thickness 10.)
        borderBrush (Brushes.CadetBlue)
        child (
            stackPanel {
                children [
                    grid {
                        cell (0,2,label { content <@ model.Value1 @> } )
                        cell (1,4,textBox { text <@ model.Value1 @> })
                        cell (<@ model.MyRow @>,<@ model.MyCol @>,label { content "I Move around depending on MyRow/MyCol" })
                    }
                    grid {
                        cell (0,0,label { content "My Row:" })
                        cell (0,1,textBox { text (<@ model.MyRow @>,(fun str -> let mutable result = 0 in Int32.TryParse(str,&result) |> ignore ; result),string)})
                        cell (0,2,label { content "My Column:" })
                        cell (0,3,textBox { text (<@ model.MyCol @>,(fun str -> let mutable result = 0 in Int32.TryParse(str,&result) |> ignore ; result),string)})
                    }
                ]
            }
        )
    }    

let subView1 (model:MyModel) =  
    stackPanel {
        children [
            
            myGridTest model.Submodel
            
            label { content "SubView 1" ; fontSize 20.}
            border {
                borderThickness (Thickness 10.)
                borderBrush (Brushes.OrangeRed)
                child ( 
                    stackPanel {
                        children [
                            label { 
                                content ( stackPanel {  
                                    orientation Orientation.Horizontal
                                    children [
                                        label { content "FontSize is:" }
                                        label { content <@ model.FontSize @> }
                                    ]
                                })
                                fontSize <@ model.FontSize @> }
                            button {
                                content "Increase Font Size"
                                onClick (<@ model.FontSize @> ,fun _ _ -> model.FontSize + 2.) }
                            button {
                                content "decrease Font Size"
                                onClick (<@ model.FontSize @> ,fun _ _ -> model.FontSize - 2.) }
                        ]
                })
            }
            label { content "Message Binding Test:" }
            textBox { text <@ model.Message @> }
            label { content <@ model.Message @> }
        ]
    }

let subView2 (model:MyModel) =  
    stackPanel {
        children [
            label { content "SubView 2" ; fontSize 20. }
            stackPanel {
                children (model.Items,fun v -> label { content ("##" + v) })
            }
            label { content (model.Items,fun (v:OSeq<_>) -> sprintf "%A" v) }
        ]
    }

type VM = { 
    mutable View:IControlBinder
    mutable Title:string
    mutable Working: Work
    mutable NewName: string
}
open FSharp.Control.Tasks.V2


let mainView (model:MyModel) =  
    let vm = { View = subView1 model; Title = "view 1" ; Working = Idle ; NewName = ""}
    border {
        borderThickness (Thickness(10.))
        borderBrush (Brushes.Beige)
        child (
            stackPanel {
                children [
                    label { content (<@ vm.Title @>,sprintf "Selected View: '%s'") }
                    button {
                        content "Select View 1"
                        onClick (<@ vm.View @>,<@ vm.Title @> ,(fun _ _ -> subView1 { model with Message = "Welcome to View 1" },"view 1")) }
                    button {
                        content "Select View 2"
                        onClick (<@ vm.View @>,<@ vm.Title @> ,fun _ _ -> subView2 model ,"view 2") }
                    label { content (<@ vm.Working @>,function Idle -> "Ready" | Working _ -> "Processing") }
                    button { content (<@ vm.Working @>,function Idle -> "Wait 5 Seconds" | Working _ -> "Cancel?") 
                             onClick (<@ vm.Working @>,<@ model.Message @>,
                                fun _ _ ct -> Task.Delay(5000,ct).ContinueWith(fun _ -> "Delay Finished") )}
                    button { content "json request" ;
                            onClick (<@ vm.Working @>,<@ model.Message @>, fun _ _ (ct:CancellationToken) -> task {
                                 use client = new System.Net.Http.HttpClient()
                                 return! client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1")
                            })}
                ]
                add <@ vm.View @>
                children [
                    
                    textBox { text <@ model.Message @> }
                    listBox {
                        items (model.Items,fun v -> label { content v })
                        selectedItem <@ model.Selected @>
                        onMouseDoubleClick (fun _ _ -> model.Items.Remove ((model.Selected :?> Label).Content :?> string ) |> ignore)
                    }
                    comboBox {
                        items (model.Items,fun v -> label { content v })
                        selectedItem <@ model.Selected @>
                    }
                    textBox { text <@ vm.NewName @> ; onKeyDown (fun _ args -> if args.Key = Key.Enter then model.Items.Add vm.NewName ) }
                    button { content "Add New Name" ; onClick (fun _ _ -> model.Items.Add vm.NewName ) }
                    button { content "Remove Selected" ; onClick (fun _ _ -> model.Items.Remove ((model.Selected :?> Label).Content :?> string ) |> ignore ) }
            
                ]
                children [for i in 0 .. 10 -> stackPanel {
                            orientation Orientation.Horizontal
                            children [
                                label { content ("#" + i.ToString()) }
                                label { content <@ model.Message @> }
                            ]}]
            }
        )
    }
    

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
    


