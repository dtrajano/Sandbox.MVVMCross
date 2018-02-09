using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace Sandbox.MVVMCross.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        string name = "Diogo Trajano";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string _titleScreen = "Home Screen";
        public string TitleScreen
        {
            get { return _titleScreen; }
            set { _titleScreen = value; }
        }

        private string lastName;
        private readonly IMvxNavigationService _navigationService;


        public override void Prepare()
        {
            // first callback. Initialize parameter-agnostic stuff here
        }

        public void Prepare(string _lastName)
        {
            // receive and store the parameter here
            this.name += _lastName;
        }

        public IMvxCommand GoFirstOption
        {
            //get { return new MvxCommand(() => ShowViewModel<FirstOptionViewModel>()); }
            get { return new MvxCommand(() => _navigationService.Navigate<FirstOptionViewModel, string>(string.Empty)); }
        }

        public HomeViewModel(IMvxNavigationService navigation) 
        {
            _navigationService = navigation;
        }

        //public override async Task Initialize()
        //{
        //    await base.Initialize();
        //    // do the heavy work here
        //}
    }
}
