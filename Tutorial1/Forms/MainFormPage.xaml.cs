using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial1.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainFormPage : ContentPage
    {
        public MainFormPage()
        {
            InitializeComponent();
        }



        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue;
        }
    }
}