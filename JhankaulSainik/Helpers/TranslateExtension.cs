using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Helpers
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        const string ResourceId = "JhankaulSainik.AppResource.AppResources";

        public static readonly Lazy<ResourceManager> resmgr = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            try
            {
                if (Text == null)
                    return "";

                var ci = CrossMultilingual.Current.CurrentCultureInfo;

                return resmgr.Value.GetString(Text, ci);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
