using PTSSRU.Custom;
using PTSSRU.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace PTSSRU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class B : ContentPage
    {
        public B()
        {
            InitializeComponent();
            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(13.777260703193848, -100.50910002742215),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",              
                Url = "https://sv1.picz.in.th/images/2021/01/11/lKpjqk.jpg"
            };
        }
  
        async void Pin_Clicked_1(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Success", "Form Saved", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                _ = Navigation.PushAsync(new PalaceThree());
            }
            else
            {
                return;
            }

        }

        async void Pin_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Success", "Form Saved", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                _ = Navigation.PushAsync(new PalaceThree());
            }
            else
            {
                return;
            }

        }
    }
}