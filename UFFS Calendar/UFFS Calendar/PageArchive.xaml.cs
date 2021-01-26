using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UFFS_Calendar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageArchive : ContentPage
    {
        public PageArchive()
        {
            InitializeComponent();
        }

        async void PickPDF(System.Object sender, System.EventArgs e)
        {
            var customFileType = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
            {
                { DevicePlatform.Android, new[] { "application/pdf" } },
            });
            var archive = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = customFileType,
                PickerTitle = "Selecione o arquivo PDF com seus horários"
            });
            await Navigation.PushAsync(new PageSync());
        }
        async void BackClick(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}