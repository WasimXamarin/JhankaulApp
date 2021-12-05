using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.Prizes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.Prizes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrizesListPage : ContentPage
    {
        public PrizesListPage()
        {
            InitializeComponent();
            BindingContext = new PrizesListViewModel(Navigation);
        }
    }
}