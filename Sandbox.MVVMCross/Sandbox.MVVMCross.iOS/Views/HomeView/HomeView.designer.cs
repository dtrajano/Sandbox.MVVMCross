// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Sandbox_MVVMCross.iOS.Views.HomeView
{
    [Register ("HomeView")]
    partial class HomeView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFirstOption { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblWelcome { get; set; }

        [Action ("UIButton2140_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton2140_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnFirstOption != null) {
                btnFirstOption.Dispose ();
                btnFirstOption = null;
            }

            if (lblTitle != null) {
                lblTitle.Dispose ();
                lblTitle = null;
            }

            if (lblWelcome != null) {
                lblWelcome.Dispose ();
                lblWelcome = null;
            }
        }
    }
}