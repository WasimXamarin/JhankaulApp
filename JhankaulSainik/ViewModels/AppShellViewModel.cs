using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels
{
    public class AppShellViewModel : BaseViewModel
    {
        public INavigation Navigation { get; }
        public AppShellViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
    }
}
