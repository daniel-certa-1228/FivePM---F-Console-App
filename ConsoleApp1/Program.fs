// Learn more about F# at http://fsharp.org

open System
open Suave
open Suave.Operators
open Suave.Filters
open Suave.Successful


[<EntryPoint>]
let main argv =
    //printfn "Hello World from F#!"
    //0 // return an integer exit code

    // Define the port where you want to serve. We'll hardcode this for now.
    let port = 8080
    // create an app config with the port
    let cfg = {defaultConfig with bindings = [ HttpBinding.createSimple HTTP "0.0.0.0" port]}
    // We'll define a single GET route at the / endpoint that returns "Hello World"
    let app = choose [GET >=> choose [path "/" >=> request (fun _ -> OK "Hello World!")]]

    startWebServer cfg app

    0

