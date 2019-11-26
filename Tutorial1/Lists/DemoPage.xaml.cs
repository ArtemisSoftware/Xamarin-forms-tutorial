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
                new Contact { Name = "Huguinho", ImageUrl = "https://lorempixel.com/400/200/people"},
                new Contact { Name = "Zezinho", ImageUrl = "https://lorempixel.com/400/200/people", Status = "Hey, lets talk"},
                new Contact { Name = "Luisinho", ImageUrl = "https://lorempixel.com/400/200/people"}
            };
        }
    }
}