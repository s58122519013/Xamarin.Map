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
    public partial class C : ContentPage
    {
        public C()
        {
            InitializeComponent();
        }
        private void ImageCell_PalaceOne(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalaceOne());
        }
        private void ImageCell_PalaceTwo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalaceTwo());
        }
        private void ImageCell_PalaceThree(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalaceThree());
        }
        private void ImageCell_PalaceFour(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalaceFour());
        }
        private void ImageCell_PalaceFive(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalanceFive());
        }
        private void ImageCell_PalaceSix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalanceSix());
        }
        private void ImageCell_PalaceSeven(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalaceSeven());
        }
        private void ImageCell_PalaceEigth(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalaceEigth());
        }
        private void ImageCell_PalaceNine(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PalaceNine());
        }
    }
}