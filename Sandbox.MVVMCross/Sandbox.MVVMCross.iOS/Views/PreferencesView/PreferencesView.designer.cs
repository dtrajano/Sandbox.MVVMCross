// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Sandbox_MVVMCross.iOS.Views.PreferencesView
{
    [Register ("PreferencesView")]
    partial class PreferencesView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFirstOption { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTitleScreen { get; set; }

        [Action ("UIButton296_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton296_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnFirstOption != null) {
                btnFirstOption.Dispose ();
                btnFirstOption = null;
            }

            if (lblTitleScreen != null) {
                lblTitleScreen.Dispose ();
                lblTitleScreen = null;
            }
        }
    }
}