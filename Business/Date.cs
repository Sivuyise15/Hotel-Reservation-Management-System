using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class Date
    {
        #region Fields
        private int day;
        private int month;
        private int year;
        #endregion

        #region Contructors
        public Date()
        {
            day = 0;
            month = 0;
            year = 0;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion
        #region Properties
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        #endregion
    }
}
