using PTSSRU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTSSRU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class D : ContentPage
    {
        public D()
        {
            InitializeComponent();
        }
        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string monkeyName = (e.CurrentSelection.FirstOrDefault() as Ismodel).Name;           
            await Shell.Current.GoToAsync($"monkeydetails?name={monkeyName}");            
        }
    }
}