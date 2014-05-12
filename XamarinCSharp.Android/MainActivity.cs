using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinCSharp.Android
{
    [Activity(Label = "XamarinCSharp.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            InitializeComponent(); // To *.designer.cs
        }

        partial void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(this.edit1.Text);
            int y = Convert.ToInt32(this.edit2.Text);
            int ans = x + y;
            this.text1.Text = ans.ToString();
        }
    }

}

