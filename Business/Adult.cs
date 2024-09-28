using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject
{
    public class Adult:Person
    {
        #region
        private double totalCost;
        #endregion
        #region Properties
        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        #endregion
        #region Contructors
        public Adult():base() { }
        public Adult(string name, string lastName, string phone, string email, double totalCost):base(name, lastName, phone, email) { 
            this.totalCost = totalCost;
        }
        #endregion
    }
}
