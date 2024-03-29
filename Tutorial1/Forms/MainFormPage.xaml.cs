﻿using System;
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
        private IList<ContactMethod> _contactMethods;

        public MainFormPage()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
                contactMethods.Items.Add(method.Name);
        }


        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod> {
                new ContactMethod { Id = 1, Name = "SMS"},
                new ContactMethod { Id = 2, Name = "Email" }
            };
        }


        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", contactMethods.Items[contactMethods.SelectedIndex], "OK");
        }
    }


    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}