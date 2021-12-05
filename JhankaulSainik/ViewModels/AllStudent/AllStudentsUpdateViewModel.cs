using JhankaulSainik.ConstantFunction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.AllStudent
{
    public class AllStudentsUpdateViewModel : BaseViewModel
    {
        public INavigation Navigation { get; }
        public AllStudentsUpdateViewModel(INavigation navigation)
        {
            Title = "All Student Update";
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
