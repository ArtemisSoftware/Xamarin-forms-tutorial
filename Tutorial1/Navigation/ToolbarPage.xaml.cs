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
    public partial class ToolbarPage : ContentPage
    {
        public ToolbarPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem activated", "OK");
        }
    }
}