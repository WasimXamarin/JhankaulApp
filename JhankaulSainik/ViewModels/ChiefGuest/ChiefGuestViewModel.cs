using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models.ChiefGuest;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.ChiefGuest
{
    public class ChiefGuestViewModel : BaseViewModel
    {
        public ChiefGuestViewModel()
        {
            Title = "Chief Guest";
            _=ChiefGuestDataMethod();
        }

        #region Chief Guest Data Display
        private ObservableCollection<ChiefGuestModel> _chiefGuestData;
        public ObservableCollection<ChiefGuestModel> ChiefGuestData
        {
            get { return _chiefGuestData; }
            set { SetProperty(ref _chiefGuestData, value); }
        }

        public async Task<ObservableCollection<ChiefGuestModel>> ChiefGuestDataMethod()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://192.168.1.7:8092/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync("api/ChiefGuest/GetChiefGuests");
                    if (response.IsSuccessStatusCode)
                    {
                        string Result = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<ObservableCollection<ChiefGuestModel>>(Result);
                    }
                }
            }
            catch (Exception Ex)
            {
                throw;
            }
            return null;

            //ChiefGuestData = new ObservableCollection<ChiefGuestModel>()
            //{
            //    new ChiefGuestModel()
            //    {
            //        FullName = "WASIM",
            //        ProfilePhoto = "User.png",
            //        Gender = "Female",
            //        MobileNumber = "9675909269",
            //        EmailId = "wasim@gmail.com",
            //        Profession = "Developer",
            //        Addresses = "Jhankaul",
            //        Year = "2021"
            //    }
            //};
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

        public string BaseURL { get; private set; }

        private void OnHindiCommandClicked(object obj)
        {
            ToastClass.HindiLanguageMethod();
        }
        #endregion

    }
}
