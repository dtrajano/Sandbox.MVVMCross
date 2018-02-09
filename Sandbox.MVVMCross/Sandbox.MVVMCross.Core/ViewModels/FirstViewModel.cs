using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using Sandbox.MVVMCross.Core.ViewModels;

namespace Sandbox_MVVMCross.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }

        private IMvxNavigationService _navigationService;

        public FirstViewModel(IMvxNavigationService navigation) {
            _navigationService = navigation;
        }

        public IMvxCommand RedirectToHome
        {
            get 
            { 
                string lastName = "Oliveira";
                return new MvxCommand(() => _navigationService.Navigate<HomeViewModel, string>(lastName)); 
            }
        }
    }
}
