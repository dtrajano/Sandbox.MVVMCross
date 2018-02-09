using System;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using Sandbox.MVVMCross.Core.ViewModels;
using UIKit;

namespace Sandbox_MVVMCross.iOS.Views
{
    public class BaseView : MvxViewController
    {
        protected bool NavigationBarEnabled = false;


        public BaseView()
        {
        }
    }
}
