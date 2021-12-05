using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.Models.Common
{
    public class BaseModel
    {
        public DateTime? CreatedDate { get; set; }
        public string strCreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyBy { get; set; }
        public bool IsActive { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
