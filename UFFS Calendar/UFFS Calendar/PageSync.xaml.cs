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
    public partial class PageSync : ContentPage
    {
        public PageSync()
        {
            InitializeComponent();
        }

        private async void syncronize(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageSyncronized());
        }
        private async void BackClick(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}