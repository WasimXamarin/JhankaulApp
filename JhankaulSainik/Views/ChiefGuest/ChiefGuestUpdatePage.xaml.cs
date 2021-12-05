using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.ChiefGuest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.ChiefGuest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChiefGuestUpdatePage : ContentPage
    {
        public ChiefGuestUpdatePage()
        {
            InitializeComponent();
            BindingContext = new ChiefGuestUpdateViewModel();
        }
    }
}