using Acr.UserDialogs;
using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models.Organizer;
using JhankaulSainik.Views.Organizer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Organizer
{
    public class OrganizersListUpdateViewModel : BaseViewModel
    {
        public OrganizersListUpdateViewModel()
        {
            Title = "Organizer Update";
            _ = OrganizerEditDataMethod();
        }

        #region Chief Guest Update Data Display
        private ObservableCollection<OrganizersModel> _organizertUpdateData;
        public ObservableCollection<OrganizersModel> OrganizertUpdateData
        {
            get { return _organizertUpdateData; }
            set { SetProperty(ref _organizertUpdateData, value); }
        }

        public async Task OrganizerEditDataMethod()
        {
            OrganizertUpdateData = new ObservableCollection<OrganizersModel>()
            {
                new OrganizersModel()
                {
                    FullName = "WASIM",
                    ProfilePhoto = "User.png",
                    MobileNumber = "9675909269",
                    FacebookId = "wasim@facebook.com",
                    EmailId = "wasim@gmail.com",
                    Address = "Jhankaul",
                    IsVisibleData = true,
                    Year = "2021"
                },
                new OrganizersModel()
                {
                    FullName = "WASIM 1",
                    ProfilePhoto = "User.png",
                    MobileNumber = "9675909270",
                    FacebookId = "alam@facebook.com",
                    EmailId = "alam@gmail.com",
                    Address = "Turkputti",
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
            if (result)
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

        private OrganizersModel _editTapped;
        public OrganizersModel EditTapped
        {
            set
            {
                SetProperty(ref _editTapped, value);
                if (_editTapped != null)
                    OrganizerClickData(_editTapped);
            }
            get { return _editTapped; }
        }

        private void OrganizerClickData(OrganizersModel editCommandData)
        {
            try
            {
                Navigation.PushAsync(new OrganizersEditPage(editCommandData));
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
