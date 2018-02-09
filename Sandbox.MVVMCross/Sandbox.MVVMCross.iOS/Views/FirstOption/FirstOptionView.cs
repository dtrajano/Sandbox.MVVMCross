using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Sandbox.MVVMCross.Core.ViewModels;
using UIKit;

namespace Sandbox_MVVMCross.iOS.Views.FirstOption
{
    public partial class FirstOptionView : MvxViewController
    {
        public FirstOptionView() : base("FirstOptionView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var set = this.CreateBindingSet<FirstOptionView, FirstOptionViewModel>();
            set.Bind(lblTitleScreen).To(vm => vm.TitleScreen);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

