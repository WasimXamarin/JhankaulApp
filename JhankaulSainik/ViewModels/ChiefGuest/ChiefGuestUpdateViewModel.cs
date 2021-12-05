using Acr.UserDialogs;
using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models;
using JhankaulSainik.Models.ChiefGuest;
using JhankaulSainik.Views;
using JhankaulSainik.Views.ChiefGuest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.ChiefGuest
{
    public class ChiefGuestUpdateViewModel : BaseViewModel
    {
        public ChiefGuestUpdateViewModel()
        {
            Title = "Chief Guest Update";
            _ = ChiefGuestEditDataMethod();
        }

        #region Chief Guest Update Data Display
        private ObservableCollection<ChiefGuestModel> _chiefGuestUpdateData;
        public ObservableCollection<ChiefGuestModel> ChiefGuestUpdateData
        {
            get { return _chiefGuestUpdateData; }
            set { SetProperty(ref _chiefGuestUpdateData, value); }
        }

        public async Task ChiefGuestEditDataMethod()
        {
            ChiefGuestUpdateData = new ObservableCollection<ChiefGuestModel>()
            {
                new ChiefGuestModel()
                {
                    FullName = "WASIM",
                    ProfilePhoto = "User.png",
                    MobileNumber = "9675909269",
                    Profession = "Developer",
                    EmailId = "wasim@gmail.com",
                    Addresses = "Jhankaul",
                    IsVisibleData = true,
                    Year = "2021"
                },
                new ChiefGuestModel()
                {
                    FullName = "WASIM 1",
                    ProfilePhoto = "User.png",
                    MobileNumber = "9675909270",
                    Profession = "HR",
                    EmailId = "alam@gmail.com",
                    Addresses = "Turkputti",
                    IsVisibleData = true,
                    Year = "2020"
                }
            };
        }

        #endregion

        #region Delete Command
        public Command DeleteCommand
        {
            get { return new Command(OnDeleteCommandClicked); }
        }

        private async void OnDeleteCommandClicked(object obj)
        {
            var result = await UserDialogs.Instance.ConfirmAsync("Would you like to confirm selection?", "Confirm Selection", "Yes", "No");
            if(result)
            {
                ToastClass.RedMessageMethod("This Data will be delete by you");
            }
            else
            {
                ToastClass.GreenMessageMethod("No action perform");
            }
        }
        #endregion

        #region Edit Tapped

        private ChiefGuestModel _editTapped;
        public ChiefGuestModel EditTapped
        {
            set 
            { 
                SetProperty(ref _editTapped, value);
                if(_editTapped != null)
                    ChiefGuestClickData(_editTapped);
            }
            get { return _editTapped; }
        }

        private void ChiefGuestClickData(ChiefGuestModel editCommandData)
        {
            try
            {
                Navigation.PushAsync(new ChiefGuestEditPage(editCommandData));
                EditTapped = null;
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

    }
}