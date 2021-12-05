using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.Sainik
{
    public class SainiksListUpdateViewModel : BaseViewModel
    {
        public SainiksListUpdateViewModel()
        {
            SainikDataMethod();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        #region Refresh Data
        public Command LoadItemsCommand { get; }
        private async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            try
            {
                SainikDataMethod();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion

        #region Sainik Data Display
        private ObservableCollection<SainikModel> _sainikModels;
        public ObservableCollection<SainikModel> SainikModels
        {
            get { return _sainikModels; }
            set { SetProperty(ref _sainikModels, value); }
        }

        public SainikModel _sainikModelTapped;
        public SainikModel SainikModelTapped
        {
            set
            {
                SetProperty(ref _sainikModelTapped, value);
                if (_sainikModelTapped != null)
                    SainikClicked(_sainikModelTapped);
            }
        }

        private async void SainikClicked(SainikModel sainikModelTapped)
        {
            try
            {
                if (sainikModelTapped != null)
                {
                    var jsonString = JsonConvert.SerializeObject(sainikModelTapped);
                    await Shell.Current.GoToAsync($"///SainiksListUpdatePage/SainiksListEditPage?content={jsonString}");
                    SainikModelTapped = null;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void SainikDataMethod()
        {
            SainikModels = new ObservableCollection<SainikModel>()
            {
                new SainikModel()
                {
                    FullName = "Sainik 1",
                    ProfilePhoto = "icon_about.png",
                    MobileNumber = "9675909269",
                    EmailId = "sainik1@gmail.com",
                    FacebookId = "sainik1@facebook.com",
                    Position = "Major",
                    Village = "Jhankaul",
                    YearFrom = "2010",
                    YearTo = "2015",
                    IsVisibleData = true
                },
                new SainikModel()
                {
                    FullName = "Sainik 2",
                    ProfilePhoto = "icon_about.png",
                    MobileNumber = "9675909270",
                    EmailId = "sainik2@gmail.com",
                    FacebookId = "sainik2@facebook.com",
                    Position = "Captain",
                    Village = "Turkputti",
                    YearFrom = "2009",
                    YearTo = "2021",
                    IsVisibleData = false
                },
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