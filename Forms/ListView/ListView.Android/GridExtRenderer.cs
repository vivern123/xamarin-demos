#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Views = Android.Views;
using Xamarin.Forms;
using SampleBrowser.SfListView;
using SampleBrowser.SfListView.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GridExt), typeof(GridExtRenderer))]
namespace SampleBrowser.SfListView.Droid
{
    class GridExtRenderer : VisualElementRenderer<GridExt>
    {
        public override bool OnTouchEvent(Views.MotionEvent e)
        {
            this.Parent.RequestDisallowInterceptTouchEvent(true);
            return base.OnTouchEvent(e);
        }
    }
}