using JhankaulSainik.ViewModels.Organizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.Organizer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizersAddPage : ContentPage
    {
        public OrganizersAddPage()
        {
            InitializeComponent();
            BindingContext = new OrganizersAddViewModel(Navigation);
        }
    }
}