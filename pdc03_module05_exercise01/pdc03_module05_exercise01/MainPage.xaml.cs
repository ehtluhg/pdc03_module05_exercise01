using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pdc03_module05_exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void exercise01_switch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exercise01_switch());
        }

        private async void exercise01_entry(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exercise01_entry());
        }

        private async void exercise01_picker(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exercise01_picker());
        }
    }
}
