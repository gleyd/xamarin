using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace demoDrm.ViewModels
{
    class WelcomePageViewModel
    {
        private String _LastName;

        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private Int32 _Age;

        public Int32 Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        public Command MAJCommand { get; set; }
        public WelcomePageViewModel()
        {
            LastName = "Obiwan";
            Age = 47;

            MAJCommand = new Command(() =>
            {
                Debugger.Break();
            });
        }

    }
}
