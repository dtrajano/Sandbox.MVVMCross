using System;
using MvvmCross.Core.ViewModels;

namespace Sandbox.MVVMCross.Core.ViewModels
{
    public class MyMenuViewModel : MvxViewModel
    {
        string _titleScreen = "My Menu Screen";
        public string TitleScreen
        {
            get { return _titleScreen; }
            set { _titleScreen = value; }
        }
        public MyMenuViewModel()
        {
        }
    }
}
