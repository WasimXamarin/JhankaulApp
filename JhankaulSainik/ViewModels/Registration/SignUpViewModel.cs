using JhankaulSainik.ConstantFunction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Registration
{
    public class SignUpViewModel : BaseViewModel
    {
        public INavigation Navigation { get; }
        public SignUpViewModel(INavigation navigation)
        {
            Title = "Sign Up";
            Navigation = navigation;
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

        #region Mobile Number
        private string _mobileNumber;
        public string MobileNumber
        {
            get { return _mobileNumber; }
            set { SetProperty(ref _mobileNumber, value); }
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
        
        #region Full Name
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
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

        #region Sign Up Command
        public Command SignUpCommand
        {
            get
            {
                return new Command(OnSignUpCommandClicked);
            }
        }

        private void OnSignUpCommandClicked(object obj)
        {
            if(string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(MobileNumber) 
                || string.IsNullOrEmpty(EmailId) || string.IsNullOrEmpty(Password))
            {
                ToastClass.RedMessageMethod("All fields Mandatory.");
            }
            else
            {
                ToastClass.GreenMessageMethod("Successfully Register.");
                App.Current.MainPage = new AppShell();
            }
        }
        #endregion
    }
}