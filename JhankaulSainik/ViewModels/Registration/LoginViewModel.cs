using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models;
using JhankaulSainik.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Registration
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            Title = "Log In";
        }

        #region English Language
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
        #endregion

        #region Hindi Language
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
        #endregion

        #region Email Id
        private string _emailId;
        public string EmailId
        {
            get { return _emailId; }
            set { SetProperty(ref _emailId, value); }
        }
        #endregion

        #region Password
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        #endregion

        #region Log In Command
        public Command LoginCommand
        {
            get
            {
                return new Command(OnLoginCommandClicked);
            }
        }

        private void OnLoginCommandClicked(object obj)
        {
            if (string.IsNullOrEmpty(EmailId) || string.IsNullOrEmpty(Password))
            {
                ToastClass.RedMessageMethod("All fields Mandatory.");
            }
            else
            {
                ToastClass.GreenMessageMethod("Successfully Log In.");
                App.Current.MainPage = new AppShell();
            }
        }
        #endregion
    
    }
}
