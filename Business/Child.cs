using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class Child:Guest
    {
        #region Fields
        private int Age;
        #endregion
        #region Properties
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        #endregion

        #region Contructors
        public Child() : base()
        {
            age = -1;
        }

        public Child(string pName, string lastName, string pPhone, string email, string guestID, int age):base(pName, lastName, pPhone, email, guestID) { 

            this.Age = age;
        }
        #endregion
        #region
        public override double CalculateCost(double totalCost, int numDays)
        {
            if (age < 5) {
                return 0.0;
            }
            return totalCost * 0.5*numDays;
        }
        #endregion

    }
}
