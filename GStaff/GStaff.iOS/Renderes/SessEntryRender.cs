﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using GStaff.iOS.Renderes;
using GStaff.RenderControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RenEntry), typeof(SessEntryRender))]
namespace GStaff.iOS.Renderes
{
    public class SessEntryRender: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}