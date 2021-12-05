using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models.Organizer;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Organizer
{
    public class OrganizersEditViewModel : BaseViewModel
    {
        public OrganizersModel EditCommandData { get; }
        public OrganizersEditViewModel(OrganizersModel editCommandData)
        {
            EditCommandData = editCommandData;
            FullName = EditCommandData.FullName;
            MobileNumber = EditCommandData.MobileNumber;
            EmailId = EditCommandData.EmailId;
            FacebookId = EditCommandData.FacebookId;
            Addresses = EditCommandData.Address;
            Year = EditCommandData.Year;
        }

        #region Update Organizer Command
        public Command UpdateOrganizerCommand
        {
            get
            {
                return new Command(OnUpdateOrganizerCommandClicked);
            }
        }

        private void OnUpdateOrganizerCommandClicked(object obj)
        {
            try
            {
                ToastClass.GreenMessageMethod("Successfully Update Organizer.");
                Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

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

        #region FacebookId
        private string _facebookId;
        public string FacebookId
        {
            get { return _facebookId; }
            set { SetProperty(ref _facebookId, value); }
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

        #region Year
        private string _year;
        public string Year
        {
            get { return _year; }
            set { SetProperty(ref _year, value); }
        }
        #endregion  

        #region IsVisibleData
        private bool _isVisibleData;
        public bool IsVisibleData
        {
            get { return _isVisibleData; }
            set { SetProperty(ref _isVisibleData, value); }
        }
        #endregion 
    }
}
