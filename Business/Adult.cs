using inf2010s_semesterProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject
{
    public class Adult:Guest
    {
        #region Contructors
        public Adult():base() { }
        public Adult(string pName, string lastName, string pPhone, string email, string guestID, string reservationID, string roomID, string check_inDate, string check_outDate) : base(pName, lastName, pPhone, email, guestID, reservationID, roomID, check_inDate, check_outDate) { }
        #endregion
        #region Methods
        public override double CalculateCost(double totalCost, int numDays)
        {
            return totalCost*numDays;
        }
        #endregion
    }
}
