using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public abstract class Guest:Person
    {
        #region Fields
        private string guestID;
        private string check_inDate, check_outDate;

        #endregion
        #region Properties
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        #endregion
        #region Constructor
        public Guest():base()
        {
            guestID = "";
            check_inDate = "";
        }
        public Guest(string pName, string lastName, string pPhone, string email, string guestID):base(pName,lastName,pPhone, email)
        {
            this.guestID = guestID;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return base.ToString() + " GuestID: " + guestID;
        }

        public abstract double CalculateCost(double totalCost, int numDays);
        #endregion
    }
}
