using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Web.Utilities
{
    public static class ConvertDate
    {
        public static string Toshamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();

  

            var _Year = pc.GetYear(value);
            var _Month = pc.GetMonth(value);
            var _day = pc.GetDayOfMonth(value);
            var hour = pc.GetHour(value).ToString("00");
            var min = pc.GetMinute(value).ToString("00");
            var sec = pc.GetSecond(value).ToString("00");
        
            return $" {_Year}-{_Month}-{_day}  {hour}:{min}:{sec} ";
        }
    }
}
