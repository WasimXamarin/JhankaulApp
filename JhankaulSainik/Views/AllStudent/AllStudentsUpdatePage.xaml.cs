using JhankaulSainik.ViewModels;
using JhankaulSainik.ViewModels.AllStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.AllStudent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllStudentsUpdatePage : ContentPage
    {
        public AllStudentsUpdatePage()
        {
            InitializeComponent();
            BindingContext = new AllStudentsUpdateViewModel(Navigation);
        }
    }
}