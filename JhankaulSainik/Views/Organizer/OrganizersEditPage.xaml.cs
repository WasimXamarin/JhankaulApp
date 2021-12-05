using JhankaulSainik.Models.Organizer;
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
    public partial class OrganizersEditPage : ContentPage
    {
        public OrganizersEditPage(OrganizersModel editCommandData)
        {
            InitializeComponent(); 
             BindingContext = new OrganizersEditViewModel(editCommandData);
        }
    }
}