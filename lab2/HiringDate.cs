using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    public struct HiringDate {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // new DateTime(2018, 7, 23)
        private DateOnly date;
        public DateOnly Date
        {
            get { 
                return date;
            }
            set
            {
                date = new DateOnly(Year, Month, Day);
            }
        }

        public HiringDate(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            this.date = new DateOnly(Year, Month, Day);
        }
        public override string ToString()
        {
            string data = $"Date is {Date}";
            return data;
        }
    }
}
