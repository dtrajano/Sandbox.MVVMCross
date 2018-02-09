using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Sandbox.MVVMCross.Core.ViewModels;
using UIKit;

namespace Sandbox_MVVMCross.iOS.Views.PreferencesView
{
    public partial class PreferencesView : MvxViewController
    {
        public PreferencesView() : base("PreferencesView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var set = this.CreateBindingSet<PreferencesView, PreferencesViewModel>();
            set.Bind(lblTitleScreen).To(vm => vm.TitleScreen);
            set.Bind(btnFirstOption).To(vm=>vm.GoFirstOption);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

