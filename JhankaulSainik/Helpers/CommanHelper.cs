using JhankaulSainik.AppResource;
using JhankaulSainik.ConstantFunction;
using JhankaulSainik.Models;
using Plugin.Multilingual;
using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;
using static Xamarin.Essentials.Permissions;

namespace JhankaulSainik.Helpers
{
    public static class CommanHelper
    {
        public static void LanguageChangeHelper(LanguageModel obj)
        {
            var culture = new CultureInfo(obj.CountryCode ?? "");
            AppResources.Culture = culture;
            CrossMultilingual.Current.CurrentCultureInfo = culture;
            Preferences.Set("CountryCode", obj.CountryCode);
        }
       
        public async static Task<byte[]> GetPictureFromCameraService()
        {
            try
            {
                var Photo = await MediaPicker.CapturePhotoAsync();
                if(Photo != null)
                {
                    var stream = await Photo.OpenReadAsync();
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        return memoryStream.ToArray();
                    }
                }
                else
                {
                    return null;
                }
            }
            catch(FeatureNotSupportedException ex)
            {
                ToastClass.RedMessageMethod("Camera Feature Not Supported in your device.");
                return null;
            }
            catch(PermissionException ex)
            {
                ToastClass.RedMessageMethod("You denied the Camera permission.");
                return null;
            }
            catch (Exception Ex)
            {
                ToastClass.RedMessageMethod("Unable to get Photo.");
                return null;
            }
        }

        public static async Task<PermissionStatus> CheckAndRequestPermissionAsync<T>(T permission) where T : BasePermission
        {
            var status = await permission.CheckStatusAsync();
            if(status != PermissionStatus.Granted)
            {
                status = await permission.RequestAsync();
            }
            return status;
        }
    }
}
