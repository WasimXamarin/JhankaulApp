
using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Sainik
{
    [QueryProperty(nameof(content), nameof(content))]
    public class SainiksListDetailsViewModel : BaseViewModel
    {
        public SainiksListDetailsViewModel()
        {
        }

        #region Data Recive
        private string _content;
        public string content
        {
            get => _content;
            set
            {
                _content = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
                SainikEditData = JsonConvert.DeserializeObject<SainikModel>(content);
                FullName = SainikEditData.FullName;
                MobileNumber = SainikEditData.MobileNumber;
                EmailId = SainikEditData.EmailId;
                FacebookId = SainikEditData.FacebookId;
                Position = SainikEditData.Position;
                YearFrom = SainikEditData.YearFrom;
                YearTo = SainikEditData.YearTo;
                Village = SainikEditData.Village;
            }
        }

        private SainikModel _sainikEditData;
        public SainikModel SainikEditData
        {
            set { SetProperty(ref _sainikEditData, value); }
            get { return _sainikEditData; }
        }
        #endregion

        #region Full Name
        public string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }
        #endregion

        #region Mobile Number
        public string _mobileNumber;
        public string MobileNumber
        {
            get { return _mobileNumber; }
            set { SetProperty(ref _mobileNumber, value); }
        }
        #endregion

        #region Email Id
        public string _emailId;
        public string EmailId
        {
            get { return _emailId; }
            set { SetProperty(ref _emailId, value); }
        }
        #endregion

        #region Facebook Id
        public string _facebookId;
        public string FacebookId
        {
            get { return _facebookId; }
            set { SetProperty(ref _facebookId, value); }
        }
        #endregion

        #region Position
        public string _position;
        public string Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }
        #endregion

        #region Year From
        public string _yearFrom;
        public string YearFrom
        {
            get { return _yearFrom; }
            set { SetProperty(ref _yearFrom, value); }
        }
        #endregion

        #region Year To
        public string _yearTo;
        public string YearTo
        {
            get { return _yearTo; }
            set { SetProperty(ref _yearTo, value); }
        }
        #endregion

        #region Village
        public string _village;
        public string Village
        {
            get { return _village; }
            set { SetProperty(ref _village, value); }
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
    }
}
