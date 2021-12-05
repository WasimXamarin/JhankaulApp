using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.Models.Organizer
{
    public class OrganizersModel
    {
        public int Id { get; set; }
        public string ProfilePhoto { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public string FacebookId { get; set; }
        public string Address { get; set; }
        public string Year { get; set; }
        public bool IsVisibleData { get; set; }
    }
}
