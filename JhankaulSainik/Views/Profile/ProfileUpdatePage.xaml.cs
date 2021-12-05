using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileUpdatePage : ContentPage
    {
        public ProfileUpdatePage()
        {
            InitializeComponent();
            BindingContext = new ProfileUpdateViewModel(Navigation);
        }
    }
}