using JhankaulSainik.ConstantFunction;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.About
{
    public class AboutViewModel : BaseViewModel
    {
        public INavigation Navigation { get; }
        public AboutViewModel(INavigation navigation)
        {
            Title = "About";
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
