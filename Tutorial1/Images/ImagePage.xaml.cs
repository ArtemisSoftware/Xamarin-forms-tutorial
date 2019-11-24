using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial1.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            
            var imageSource = new UriImageSource { Uri = new Uri("https://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;

        
        }
    }
}