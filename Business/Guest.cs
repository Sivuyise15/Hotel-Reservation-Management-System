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
        private string season;
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
        public string Season
        {
            get { return season; }
            set { season = value; }
        }
        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        #endregion
        #region Constructor
        public Guest()
        {
            guestID = "";
            reservationID = "";
            roomID = "";
            season = "";
        }
        public Guest(string guestID, string reservationID, string roomID, string season)
        {
            this.guestID = guestID;
            this.reservationID = reservationID;
            this.roomID = roomID;
            this.season = season;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return "Guest ID: " + guestID + "\nReservation ID: " + reservationID + "\nRoom ID: " + roomID + "\nCheck-in Date: " + "\nSeason: " + season + "\nTotal Cost: " ;
        }

        public virtual double CalculateCost(double totalCost, int numDays) {
            return totalCost*numDays;
        }
        #endregion
    }
}
