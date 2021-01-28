using PTSSRU.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTSSRU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class A : ContentPage
    {
        public A()
        {
            InitializeComponent();
        }
      async void OnButtonClicked(object sender, EventArgs args)
        {

            var result = await DisplayAlert("เดิน ชม 2 ชั่วโมง", "คุณต้องการเริ่มระบบเดินชม", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                _ = Navigation.PushAsync(new PalanceFive());
            }
            else 
            {
                return;
            }
        }

        async void gob_Clicked(object sender, EventArgs e)
        {

            var result = await DisplayAlert("เดิน ชม 1 ชั่วโมง", "คุณต้องการเริ่มระบบเดินชม", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                _ = Navigation.PushAsync(new PalanceFive());
            }
            else
            {
                return;
            }
        }

        async void goa_Clicked(object sender, EventArgs e)
        {

            var result = await DisplayAlert("เดินชม 30 นาที", "คุณต้องการเริ่มระบบเดินชม", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                _ = Navigation.PushAsync(new PalanceFive());
            }
            else
            {
                return;
            }
        }
    }
}