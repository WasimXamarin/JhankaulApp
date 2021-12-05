using System;
using System.Collections.Generic;
using System.Text;

namespace JhankaulSainik.Models.Common
{
    public enum TimeType
    {
        OnlyDate = 1,
        OnlyTime,
        DateAndTime
    }
    public class DateFormat
    {
        public DateFormat()
        {

        }
        public static string GetDateTime(DateTime? dateTime, TimeType timeType)
        {
            if(dateTime == null)
            {
                return "";
            }
            else if(timeType == TimeType.OnlyTime)
            {
                return Convert.ToDateTime(dateTime).ToString("HH:mm");
            }
            else if(timeType == TimeType.OnlyDate)
            {
                return Convert.ToDateTime(dateTime).ToString("dd-MMM-yy");
            }
            else if(timeType == TimeType.DateAndTime)
            {
                return Convert.ToDateTime(dateTime).ToString("dd-MMM-yy HH:mm");
            }
            else
            {
                return "";
            }
        }
    }
}
