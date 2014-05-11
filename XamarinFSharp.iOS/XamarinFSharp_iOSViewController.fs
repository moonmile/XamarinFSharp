namespace XamarinFSharp.iOS

open System
open System.Drawing

open MonoTouch.UIKit
open MonoTouch.Foundation
open System.CodeDom.Compiler

// STEP for Xamrin Studio 5.0 alpha version 
// 1. Add 'empty iphone/ipad storyboard.
// 2. Make UI. and Xamarin Studio C# files for storyboard.
// 3. Remove *.desinger.cs and *.cs from F# project
// 4. Modify ViewController constructor had 'handler : IntPtr'
// 5. Modify AppDelegate.Window propery in AppDelegate.fs
// 6. Set that 'Main Interface' item is MainStoryboard in Info.plist. 

[<Register ("XamarinFSharp_iOSViewController")>]
type XamarinFSharp_iOSViewController ( handler : IntPtr ) =
    inherit UIViewController ( handler )

    // make UIOutlet properties by your hands.
    [<Outlet>]
    member val edit1 : UITextField = null with get, set
    [<Outlet>]
    member val edit2 : UITextField = null with get, set
    [<Outlet>]
    member val button1 : UIButton = null with get, set
    [<Outlet>]
    member val text1 : UILabel = null with get, set

    // Release any cached data, images, etc that aren't in use.
    override this.DidReceiveMemoryWarning () =
        base.DidReceiveMemoryWarning ()

    // Perform any additional setup after loading the view, typically from a nib.
    override this.ViewDidLoad () =
        base.ViewDidLoad ()
        this.View.BackgroundColor <- UIColor.White

        this.edit1.Text <- "10";
        this.edit2.Text <- "20";
        this.button1.TouchUpInside.Add( fun _ -> 
            let x = Convert.ToInt32( this.edit1.Text )
            let y = Convert.ToInt32( this.edit2.Text )
            let ans = x + y 
            this.text1.Text <- ans.ToString()        
        )


    // Return true for supported orientations
    override this.ShouldAutorotateToInterfaceOrientation (orientation) =
        orientation <> UIInterfaceOrientation.PortraitUpsideDown

