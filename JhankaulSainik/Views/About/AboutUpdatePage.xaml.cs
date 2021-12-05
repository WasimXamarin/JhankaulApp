using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.About;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.About
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUpdatePage : ContentPage
    {
        public AboutUpdatePage()
        {
            InitializeComponent();
            BindingContext = new AboutUpdateViewModel(Navigation);
        }
    }
}