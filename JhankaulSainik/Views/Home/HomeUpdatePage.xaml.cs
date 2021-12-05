using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeUpdatePage : ContentPage
    {
        public HomeUpdatePage()
        {
            InitializeComponent();
            BindingContext = new HomeUpdateViewModel(Navigation);
        }
    }
}