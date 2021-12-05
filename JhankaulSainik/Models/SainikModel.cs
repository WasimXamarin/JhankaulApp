using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.Models
{
    public class SainikModel
    {
        public int Id { get; set; }
        public string ProfilePhoto { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public string FacebookId { get; set; }
        public string MobileNumber { get; set; }
        public string Position { get; set; }
        public string YearFrom { get; set; }
        public string ToText { get; set; }
        public string YearTo { get; set; }
        public string Village { get; set; }
        public bool IsVisibleData { get; set; }
    }
}
