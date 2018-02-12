using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoDrm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //Debugger.Break();
            String message = e.OldValue.ToString() + " - " + e.NewValue.ToString();
            message =  String.Format("{0:0.00} - {1:c}", e.OldValue, e.NewValue);
            message = $"{e.OldValue} - {e.NewValue:0:00}";
            Debug.WriteLine(message);

            LabelSlider.Text = e.NewValue.ToString("0.00");
            //LabelSlider.Text = e.NewValue.ToString("{0.00}");

        }

    }
}
