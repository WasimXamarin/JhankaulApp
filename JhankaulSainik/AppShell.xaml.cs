using JhankaulSainik.ViewModels;
using JhankaulSainik.Views;
using JhankaulSainik.Views.Sainik;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JhankaulSainik
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new AppShellViewModel(Navigation);
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
