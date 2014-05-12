using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinCSharp.Android
{
    public partial class MainActivity : Activity
    {
        public EditText edit1;
        public EditText edit2;
        public TextView text1;
        public Button button1;

        private void InitializeComponent()
        {
            this.edit1 = FindViewById<EditText>(Resource.Id.editText1);
            this.edit2 = FindViewById<EditText>(Resource.Id.editText2);
            this.text1 = FindViewById<TextView>(Resource.Id.textView1);
            this.button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += button1_Click;
        }
        partial void button1_Click(object sender, EventArgs e);
    }
}