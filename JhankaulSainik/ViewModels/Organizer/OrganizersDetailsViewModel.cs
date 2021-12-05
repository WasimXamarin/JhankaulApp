using JhankaulSainik.ConstantFunction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Organizer
{
    public class OrganizersDetailsViewModel
    {
        public INavigation Navigation { get; }
        public OrganizersDetailsViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        public Command EnglishCommand
        {
            get
            {
                return new Command(OnEnglishCommandClicked);
            }
        }

        private void OnEnglishCommandClicked(object obj)
        {
            ToastClass.EnglishLanguageMethod();
        }
        public Command HindiCommand
        {
            get
            {
                return new Command(OnHindiCommandClicked);
            }
        }

        private void OnHindiCommandClicked(object obj)
        {
            ToastClass.HindiLanguageMethod();
        }
    }
}
