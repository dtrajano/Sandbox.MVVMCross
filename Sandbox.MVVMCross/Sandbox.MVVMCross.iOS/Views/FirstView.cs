using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using Sandbox.MVVMCross.Core.ViewModels;
using Sandbox_MVVMCross.Core.ViewModels;
using UIKit;

namespace Sandbox_MVVMCross.iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxTabBarViewController
    {
        private int _createdSoFarCount = 0;

        public FirstView(IntPtr handle) : base(handle)
        {
            ViewDidLoad();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if(ViewModel == null)  {
                return;
            }

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
            set.Bind(btnRedirect).To(vm=>vm.RedirectToHome);
            set.Apply();

            HomeViewModel homeViewModel = new HomeViewModel();
            PreferencesViewModel preferencesViewModel = new PreferencesViewModel();
            MyMenuViewModel myMenuViewModel = new MyMenuViewModel();
            var viewControllers = new UIViewController[]
                                 {
                                    CreateTabFor("Inicio", "1", homeViewModel),
                                    CreateTabFor("Meu Menu", "2", myMenuViewModel),
                                    CreateTabFor("Preferências", "3", preferencesViewModel)
                                 };

            ViewControllers = viewControllers;
            CustomizableViewControllers = new UIViewController[] { };
            SelectedViewController = ViewControllers[0];
        }

        private UIViewController CreateTabFor(string title, string imageName, IMvxViewModel viewModel)
        {
            var controller = new UINavigationController();
            var screen = this.CreateViewControllerFor(viewModel) as UIViewController;
            SetTitleAndTabBarItem(screen, title, string.Empty);
            controller.PushViewController(screen, false);
            return controller;
        }

        private void SetTitleAndTabBarItem(UIViewController screen, string title, string imageName)
        {
            screen.Title = title;
            //screen.TabBarItem = new UITabBarItem(title, UIImage.FromBundle("Images/Tabs/" + imageName + ".png"),_createdSoFarCount);
            _createdSoFarCount++;
        }

        public bool ShowView(IMvxIosView view)
        {
            if (TryShowViewInCurrentTab(view))
                return true;

            return false;
        }

        private bool TryShowViewInCurrentTab(IMvxIosView view)
        {
            var navigationController = (UINavigationController)this.SelectedViewController;
            navigationController.PushViewController((UIViewController)view, true);
            return true;
        }
    }
}
