using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.AdmitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.AdmitCard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdmitCardUpdatePage : ContentPage
    {
        public AdmitCardUpdatePage()
        {
            InitializeComponent();
            BindingContext = new AdmitCardUpdateViewModel(Navigation);
        }
    }
}