using JhankaulSainik.Models;
using JhankaulSainik.ViewModels.Sainik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.Sainik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SainiksListDetailsPage : ContentPage
    {
        public SainiksListDetailsPage()
        {
            InitializeComponent();
            BindingContext = new SainiksListDetailsViewModel();
        }
    }
}