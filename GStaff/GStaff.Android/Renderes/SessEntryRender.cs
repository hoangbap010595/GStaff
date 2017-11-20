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
using Xamarin.Forms;
using GStaff.RenderControls;
using GStaff.Droid.Renderes;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using ACanvas = Android.Graphics.Canvas;
using Android.Content.Res;

[assembly:ExportRenderer(typeof(RenEntry), typeof(SessEntryRender))]
namespace GStaff.Droid.Renderes
{
    public class SessEntryRender: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                Control.SetTextColor(global::Android.Graphics.Color.Black);
                Control.SetText("", TextView.BufferType.Normal);
            }
        }
    }
}