// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace XamarinFSharp.iOS
{
	[Register ("XamarinFSharp_iOSViewController")]
	partial class XamarinFSharp_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton button1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField edit1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField edit2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel text1 { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (button1 != null) {
				button1.Dispose ();
				button1 = null;
			}
			if (edit1 != null) {
				edit1.Dispose ();
				edit1 = null;
			}
			if (edit2 != null) {
				edit2.Dispose ();
				edit2 = null;
			}
			if (text1 != null) {
				text1.Dispose ();
				text1 = null;
			}
		}
	}
}
