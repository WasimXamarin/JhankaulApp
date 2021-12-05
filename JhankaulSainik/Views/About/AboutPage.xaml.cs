using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.About;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.About
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel(Navigation);
        }
    }
}