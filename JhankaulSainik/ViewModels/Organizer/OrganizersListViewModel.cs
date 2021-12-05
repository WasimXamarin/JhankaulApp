using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models.Organizer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Organizer
{
    public class OrganizersListViewModel : BaseViewModel
    {
        public INavigation Navigation { get; }
        public OrganizersListViewModel(INavigation navigation)
        {
            Title = "Organizers";
            Navigation = navigation;
            ChiefGuestDataMethod();
        }

        #region Chief Guest Data Display
        private ObservableCollection<OrganizersModel> _organizerData;
        public ObservableCollection<OrganizersModel> OrganizerData
        {
            get { return _organizerData; }
            set { SetProperty(ref _organizerData, value); }
        }

        public void ChiefGuestDataMethod()
        {
            OrganizerData = new ObservableCollection<OrganizersModel>()
            {
                new OrganizersModel()
                {
                    FullName = "WASIM",
                    ProfilePhoto = "User.png",
                    MobileNumber = "9675909269",
                    EmailId = "wasim@gmail.com",
                    FacebookId = "wasim@facebook.com",
                    Address = "Jhankaul",
                    Year = "2021"
                },
                new OrganizersModel()
                {
                    FullName = "WASIM ALAM",
                    ProfilePhoto = "User.png",
                    MobileNumber = "9675909270",
                    EmailId = "alam@gmail.com",
                    FacebookId = "alam@facebook.com",
                    Address = "Turkputti",
                    Year = "2020"
                }
            };
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
