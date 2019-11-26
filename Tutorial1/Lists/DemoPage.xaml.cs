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

            

            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("H", "H"){
                    new Contact { Name = "Huguinho", ImageUrl = "https://placekitten.com/200/202"}
                },
                new ContactGroup("Z", "Z"){
                    new Contact { Name = "Zezinho", ImageUrl = "https://placekitten.com/200/201", Status = "Hey, lets talk"} 
                },
                new ContactGroup("L", "L"){
                    new Contact { Name = "Luisinho", ImageUrl = "https://placekitten.com/200/200"} 
                }
            };
        }
    }
}