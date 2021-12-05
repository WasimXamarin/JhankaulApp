using JhankaulSainik.Services;
using JhankaulSainik.Views.Sainik;
using JhankaulSainik.Views.About;
using JhankaulSainik.Views.AdmitCard;
using JhankaulSainik.Views.AllStudent;
using JhankaulSainik.Views.Home;
using JhankaulSainik.Views.ChiefGuest;
using JhankaulSainik.Views.Organizer;
using JhankaulSainik.Views.Prizes;
using JhankaulSainik.Views.Profile;
using JhankaulSainik.Views.Registration;
using JhankaulSainik.Views.Result;
using JhankaulSainik.Views.School;

using Xamarin.Forms;

namespace JhankaulSainik
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            PageNameAssign();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected void PageNameAssign()
        {
            Routing.RegisterRoute(nameof(AboutAddPage), typeof(AboutAddPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(AboutUpdatePage), typeof(AboutUpdatePage));
            Routing.RegisterRoute(nameof(AdmitCardPage), typeof(AdmitCardPage));
            Routing.RegisterRoute(nameof(AdmitCardAddPage), typeof(AdmitCardAddPage));
            Routing.RegisterRoute(nameof(AdmitCardUpdatePage), typeof(AdmitCardUpdatePage));
            Routing.RegisterRoute(nameof(AllStudentsPage), typeof(AllStudentsPage));
            Routing.RegisterRoute(nameof(AllStudentsAddPage), typeof(AllStudentsAddPage));
            Routing.RegisterRoute(nameof(AllStudentsUpdatePage), typeof(AllStudentsUpdatePage));
            Routing.RegisterRoute(nameof(ChiefGuestAddPage), typeof(ChiefGuestAddPage));
            Routing.RegisterRoute(nameof(ChiefGuestEditPage), typeof(ChiefGuestEditPage));
            Routing.RegisterRoute(nameof(ChiefGuestPage), typeof(ChiefGuestPage));
            Routing.RegisterRoute(nameof(ChiefGuestUpdatePage), typeof(ChiefGuestUpdatePage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(HomeAddPage), typeof(HomeAddPage));
            Routing.RegisterRoute(nameof(HomeUpdatePage), typeof(HomeUpdatePage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(OrganizersAddPage), typeof(OrganizersAddPage));
            Routing.RegisterRoute(nameof(OrganizersDetailsPage), typeof(OrganizersDetailsPage));
            Routing.RegisterRoute(nameof(OrganizersEditPage), typeof(OrganizersEditPage));
            Routing.RegisterRoute(nameof(OrganizersListPage), typeof(OrganizersListPage));
            Routing.RegisterRoute(nameof(OrganizersListUpdatePage), typeof(OrganizersListUpdatePage));
            Routing.RegisterRoute(nameof(PrizesListPage), typeof(PrizesListPage));
            Routing.RegisterRoute(nameof(PrizesListUpdatePage), typeof(PrizesListUpdatePage));
            Routing.RegisterRoute(nameof(PrizesAddPage), typeof(PrizesAddPage));
            Routing.RegisterRoute(nameof(PrizesDetailsPage), typeof(PrizesDetailsPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(ProfileDetailsPage), typeof(ProfileDetailsPage));
            Routing.RegisterRoute(nameof(ProfileUpdatePage), typeof(ProfileUpdatePage));
            Routing.RegisterRoute(nameof(ResultPage), typeof(ResultPage));
            Routing.RegisterRoute(nameof(ResultAddPage), typeof(ResultAddPage));
            Routing.RegisterRoute(nameof(ResultUpdatePage), typeof(ResultUpdatePage));
            Routing.RegisterRoute(nameof(ResultDetailsPage), typeof(ResultDetailsPage));
            Routing.RegisterRoute(nameof(SainikAddPage), typeof(SainikAddPage));
            Routing.RegisterRoute(nameof(SainiksListPage), typeof(SainiksListPage));
            Routing.RegisterRoute(nameof(SainiksListDetailsPage), typeof(SainiksListDetailsPage));
            Routing.RegisterRoute(nameof(SainiksListEditPage), typeof(SainiksListEditPage));
            Routing.RegisterRoute(nameof(SainiksListUpdatePage), typeof(SainiksListUpdatePage));
            Routing.RegisterRoute(nameof(SchoolsAddPage), typeof(SchoolsAddPage));
            Routing.RegisterRoute(nameof(SchoolsListUpdatePage), typeof(SchoolsListUpdatePage));
            Routing.RegisterRoute(nameof(SchoolsListPage), typeof(SchoolsListPage));
            Routing.RegisterRoute(nameof(SchoolsListUpdatePage), typeof(SchoolsListUpdatePage));
            Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
        }
    }
}
