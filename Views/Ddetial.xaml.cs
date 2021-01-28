using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PTSSRU.ViewModels;
using System;
using Xamarin.Essentials;

namespace PTSSRU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ddetial : ContentPage
    {
  
        public Ddetial()
        {
            InitializeComponent();
            BindingContext = new AViewModel();
        }      
    }
}