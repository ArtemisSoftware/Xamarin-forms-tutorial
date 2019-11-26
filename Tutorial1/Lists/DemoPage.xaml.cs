using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial1.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoPage : ContentPage
    {
        public DemoPage()
        {
            InitializeComponent();



            listView.ItemsSource = new List<Contact>
            {
                    new Contact { Name = "Huguinho", ImageUrl = "https://placekitten.com/200/202"},
                    new Contact { Name = "Zezinho", ImageUrl = "https://placekitten.com/200/201", Status = "Hey, lets talk"} ,
                    new Contact { Name = "Luisinho", ImageUrl = "https://placekitten.com/200/200"} ,

            };
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }
    }
}