﻿using Capacity.Controls;
using Capacity.iOS;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CEntry), typeof(CustomEntryRenderer))]
namespace Capacity.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 1;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}