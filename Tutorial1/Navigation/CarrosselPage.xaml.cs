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
    public partial class CarrosselPage : CarouselPage
    {
        public CarrosselPage()
        {
            InitializeComponent();
        }
    }
}