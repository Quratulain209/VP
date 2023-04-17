using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCleaningServicesScreen
{
    public class Services
    {
        public static string Guid()
        {
            int year = DateTime.Now.Year;
            int Month = DateTime.Now.Month;
            int Day = DateTime.Now.Day;
            int Hours = DateTime.Now.Hour;
            int Minutes = DateTime.Now.Minute;
            int Seconds = DateTime.Now.Second;

            return year.ToString() +
                Month.ToString() +
                Day.ToString() +
                Hours.ToString() +
                Minutes.ToString() +
                Seconds.ToString();
        }
    }
}
