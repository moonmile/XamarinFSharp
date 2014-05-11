namespace XamarinFSharp.iOS

open System
open MonoTouch.UIKit
open MonoTouch.Foundation

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit UIApplicationDelegate ()

    // make Window property 
    override val Window = null with get, set

    // let window = new UIWindow (UIScreen.MainScreen.Bounds)

    // This method is invoked when the application is ready to run.
    //override this.FinishedLaunching (app, options) =
    //    window.RootViewController <- new XamarinFSharp_iOSViewController ()
    //    window.MakeKeyAndVisible ()
    //    true

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main (args, null, "AppDelegate")
        0

