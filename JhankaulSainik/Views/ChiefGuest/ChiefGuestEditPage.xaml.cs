using JhankaulSainik.Models;
using JhankaulSainik.Models.ChiefGuest;
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
    public partial class ChiefGuestEditPage : ContentPage
    {
        public ChiefGuestEditPage(ChiefGuestModel editCommandData)
        {
            InitializeComponent();
            BindingContext = new ChiefGuestEditViewModel(editCommandData);
        }
    }
}