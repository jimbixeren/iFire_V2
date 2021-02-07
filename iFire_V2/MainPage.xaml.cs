using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iFire_V2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);


            //ImageSource.FromResource("iFire_V2.Assets.Images.iFire.png", assembly);
            ImageSource.FromResource("iFire_V2.Assets.Images.plane.png", assembly);



        }
    }
}
