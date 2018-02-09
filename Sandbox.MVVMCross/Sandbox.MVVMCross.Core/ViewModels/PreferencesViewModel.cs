using System;
using MvvmCross.Core.ViewModels;

namespace Sandbox.MVVMCross.Core.ViewModels
{
    public class PreferencesViewModel : MvxViewModel
    {
        string _titleScreen = "Preferences Screen";
        public string TitleScreen
        {
            get { return _titleScreen; }
            set { _titleScreen = value; }
        }

        public IMvxCommand GoFirstOption
        {
            get { return new MvxCommand(() => ShowViewModel<FirstOptionViewModel>()); }
        }

        public PreferencesViewModel()
        {
        }
    }
}
