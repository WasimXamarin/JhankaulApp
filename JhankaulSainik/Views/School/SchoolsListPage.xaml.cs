using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.School
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchoolsListPage : ContentPage
    {
        public SchoolsListPage()
        {
            InitializeComponent();
            BindingContext = new SchoolsListViewModel(Navigation);
        }
    }
}