using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial1.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : MasterDetailPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl = "https://lorempixel.com/100/100/people/1" },
                new Contact { Name = "John", ImageUrl = "https://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
            };
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactDetailPage(contact));
            IsPresented = false; //IsMasterPresented
            
        }
    }
}