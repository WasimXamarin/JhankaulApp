using JhankaulSainik.ConstantFunction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.ChiefGuest
{
    public class ChiefGuestAddViewModel : BaseViewModel
    {
        public ChiefGuestAddViewModel()
        {
            Title = "New Chief Guest Add";
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

        #region Full Name
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
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

        #region Profession
        private string _profession;
        public string Profession
        {
            get { return _profession; }
            set { SetProperty(ref _profession, value); }
        }
        #endregion

        #region Addresses
        private string _addresses;
        public string Addresses
        {
            get { return _addresses; }
            set { SetProperty(ref _addresses, value); }
        }
        #endregion

        #region Invitaion Year
        private string _year;
        public string Year
        {
            get { return _year; }
            set { SetProperty(ref _year, value); }
        }
        #endregion

        #region Add Chief Guest Command
        public Command AddChiefGuestCommand
        {
            get
            {
                return new Command(OnAddChiefGuestCommandClicked);
            }
        }

        private void OnAddChiefGuestCommandClicked(object obj)
        {
            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(MobileNumber) || string.IsNullOrEmpty(EmailId))
            {
                ToastClass.GreenMessageMethod("Successfully Add Chief Guest.");
                Navigation.PopAsync();
            }
        }
        #endregion

    }
}
