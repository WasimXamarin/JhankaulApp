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
    public partial class SchoolsAddPage : ContentPage
    {
        public SchoolsAddPage()
        {
            InitializeComponent();
            BindingContext = new SchoolsAddViewModel(Navigation);
        }
    }
}