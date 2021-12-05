using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.ServiceConfiguration
{
    public class Constants
    {
        public static bool ForTest = true;
        public static string BaseURL => ForTest ? "https://localhost:44389/" : "";

        public string GetAllChiefGuest = "api/ChiefGuest";
    }
}
