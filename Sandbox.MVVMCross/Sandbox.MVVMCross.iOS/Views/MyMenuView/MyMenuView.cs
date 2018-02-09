using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Sandbox.MVVMCross.Core.ViewModels;
using UIKit;

namespace Sandbox_MVVMCross.iOS.Views.MyMenuView
{
    public partial class MyMenuView : MvxViewController
    {
        public MyMenuView() : base("MyMenuView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var set = this.CreateBindingSet<MyMenuView, MyMenuViewModel>();
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

