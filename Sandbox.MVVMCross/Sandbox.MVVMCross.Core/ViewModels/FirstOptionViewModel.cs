using System;
using MvvmCross.Core.ViewModels;

namespace Sandbox.MVVMCross.Core.ViewModels
{
    public class FirstOptionViewModel : MvxViewModel<string>
    {
        private string _titleScreen = "First Option Screen";
        public string TitleScreen
        {
            get { return _titleScreen;  }
            set { _titleScreen = value; }
        }

        public FirstOptionViewModel()
        {
        }

        public override void Prepare()
        {
            base.Prepare();
        }

        public override void Prepare(string message)
        {
            _titleScreen += message;
        }
    }
}
