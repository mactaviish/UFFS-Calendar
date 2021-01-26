using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UFFS_Calendar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMenu : ContentPage
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private async void import(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageArchive());
        }
        private async void consult(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageConsult());
        }
        private async void logout(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}