using Acr.UserDialogs;
using JhankaulSainik.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.ConstantFunction
{
    public class ToastClass
    {
        public static void HindiLanguageMethod()
        {
            var toastConfig = new ToastConfig(AppResource.AppResources.NowAppInHindi);
            toastConfig.SetDuration(2000);
            toastConfig.SetPosition(ToastPosition.Bottom);
            toastConfig.SetBackgroundColor(System.Drawing.Color.Green);
            UserDialogs.Instance.Toast(toastConfig);
            Helpers.CommanHelper.LanguageChangeHelper(new LanguageModel { Country = "", CountryCode = "hi" });
            App.Current.MainPage = new AppShell();
        }

        public static void EnglishLanguageMethod()
        {
            var toastConfig = new ToastConfig(AppResource.AppResources.NowAppInEnglish);
            toastConfig.SetDuration(2000);
            toastConfig.SetPosition(ToastPosition.Bottom);
            toastConfig.SetBackgroundColor(System.Drawing.Color.Green);
            UserDialogs.Instance.Toast(toastConfig);
            Helpers.CommanHelper.LanguageChangeHelper(new LanguageModel { Country = "", CountryCode = "" });
            App.Current.MainPage = new AppShell();
        }

        public static void GreenMessageMethod(string YourMessage)
        {
            var toastConfig = new ToastConfig(YourMessage);
            toastConfig.SetDuration(2000);
            toastConfig.SetPosition(ToastPosition.Bottom);
            toastConfig.SetBackgroundColor(System.Drawing.Color.Green);
            UserDialogs.Instance.Toast(toastConfig);
        }

        public static void RedMessageMethod(string YourMessage)
        {
            var toastConfig = new ToastConfig(YourMessage);
            toastConfig.SetDuration(2000);
            toastConfig.SetPosition(ToastPosition.Bottom);
            toastConfig.SetBackgroundColor(System.Drawing.Color.Red);
            UserDialogs.Instance.Toast(toastConfig);
        }
    }
}
