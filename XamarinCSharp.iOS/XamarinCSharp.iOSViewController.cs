using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XamarinCSharp.iOS
{
	public partial class XamarinCSharp_iOSViewController : UIViewController
	{
		public XamarinCSharp_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.View.BackgroundColor = UIColor.White;

			this.edit1.Text = "10";
			this.edit2.Text = "20";
			// for compare with F#, use lamda.
			this.button1.TouchUpInside += (sender, e) => {
				int x = Convert.ToInt32( this.edit1.Text );
				int y = Convert.ToInt32( this.edit2.Text );
				int ans = x + y ;
				this.text1.Text = ans.ToString();
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

