using System;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace Sandbox.MVVMCross.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel<string>
    {
        string name = "Diogo Trajano";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string lastName;

        public override void Prepare()
        {
            // first callback. Initialize parameter-agnostic stuff here
        }

        public override void Prepare(string _lastName)
        {
            // receive and store the parameter here
            this.name += _lastName;
        }

        //public override async Task Initialize()
        //{
        //    await base.Initialize();
        //    // do the heavy work here
        //}
    }
}
