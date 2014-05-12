namespace XamarinFSharp.Android

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

[<Activity (Label = "XamarinFSharp.Android", MainLauncher = true)>]
type MainActivity () =
    inherit Activity ()


    member val edit1 : EditText = null with get, set
    member val edit2 : EditText = null with get, set
    member val button1 : Button = null with get, set
    member val text1 : TextView = null with get, set

    member this.InitializeComponent =
        this.edit1 <- this.FindViewById<EditText>(Resource_Id.editText1)
        this.edit2 <- this.FindViewById<EditText>(Resource_Id.editText2)
        this.button1 <- this.FindViewById<Button>(Resource_Id.button1)
        this.text1 <- this.FindViewById<TextView>(Resource_Id.textView1)

    override this.OnCreate (bundle) =

        base.OnCreate (bundle)

        // Set our view from the "main" layout resource
        this.SetContentView (Resource_Layout.Main)
        this.InitializeComponent

        this.button1.Click.Add( fun _ ->
            let x = Convert.ToInt32( this.edit1.Text )
            let y = Convert.ToInt32( this.edit2.Text )
            let ans = x + y 
            this.text1.Text <- ans.ToString()        
        )

