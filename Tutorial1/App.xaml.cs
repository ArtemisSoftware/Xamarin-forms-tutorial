using System;
using Tutorial1.Forms;
using Tutorial1.Images;
using Tutorial1.Lists;
using Tutorial1.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainFormPage();
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
