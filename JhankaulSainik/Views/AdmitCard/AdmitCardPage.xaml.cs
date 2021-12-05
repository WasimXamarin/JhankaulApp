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
    public partial class AdmitCardPage : ContentPage
    {
        public AdmitCardPage()
        {
            InitializeComponent();
            BindingContext = new AdmitCardViewModel(Navigation);
        }
    }
}