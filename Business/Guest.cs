using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class Guest:Person
    {
        #region Fields
        private string guestID;
        private string reservationID;
        private string roomID;
        #endregion
        #region Properties
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public string ReservationID
        {
            get { return reservationID; }
            set { reservationID = value; }
        }
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        #endregion
        #region Constructor
        public Guest():base()
        {
            guestID = "";
            reservationID = "";
            roomID = "";
        }
        public Guest(string pName, string lastName, string pPhone, string email, string guestID, string reservationID, string roomID, string check_inDate, string check_outDate):base(pName,lastName,pPhone, email)
        {
            this.guestID = guestID;
            this.reservationID = reservationID;
            this.roomID = roomID;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return "Guest ID: " + guestID + "\nReservation ID: " + reservationID + "\nRoom ID: " + roomID + "\nCheck-in Date: " + "\nSeason: " + "\nTotal Cost: " ;
        }

        public virtual double CalculateCost(double totalCost, int numDays) {
            return totalCost*numDays;
        }
        #endregion
    }
}
