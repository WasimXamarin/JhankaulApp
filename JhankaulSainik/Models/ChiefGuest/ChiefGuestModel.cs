using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.Models.ChiefGuest
{
    public class ChiefGuestModel
    {
        public int Id { get; set; }
        public string ProfilePhoto { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Profession { get; set; }
        public string Addresses { get; set; }
        public string Year { get; set; }
        public bool IsVisibleData { get; set; }
    }
}
