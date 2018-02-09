using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Sandbox.MVVMCross.Core.ViewModels;
using UIKit;

namespace Sandbox_MVVMCross.iOS.Views.HomeView
{
    [MvxFromStoryboard]
    public partial class HomeView : MvxViewController
    {

        public HomeView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<HomeView, HomeViewModel>();
            set.Bind(lblTitle).To(vm=>vm.Name);
            set.Apply();
        }
    }
}

