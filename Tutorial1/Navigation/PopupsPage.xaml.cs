using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial1.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupsPage : ContentPage
    {
        public PopupsPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            if (response)
            {
                DisplayAlert("Done", "You are sure", "OK");
            }

        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Link");
            await DisplayAlert("Response", response, "OK");
        }
    }
}