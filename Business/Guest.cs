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
        private string check_inDate;
        private string check_outDate;
        private string season;
        private double totalCost;
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
        public string Check_inDate
        {
            get { return check_inDate; }
            set { check_inDate = value; }
        }
        public string Check_outDate
        {
            get { return check_outDate; }
            set { check_outDate = value; }
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
            check_inDate = "";
            check_outDate = "";
            season = "";
            totalCost = 0;
        }
        public Guest(string guestID, string reservationID, string roomID, string check_inDate, string check_outDate, string season, double totalCost)
        {
            this.guestID = guestID;
            this.reservationID = reservationID;
            this.roomID = roomID;
            this.check_inDate = check_inDate;
            this.check_outDate = check_outDate;
            this.season = season;
            this.totalCost = totalCost;
        }
        #endregion
        #region ToStringMethod
        public override string ToString()
        {
            return "Guest ID: " + guestID + "\nReservation ID: " + reservationID + "\nRoom ID: " + roomID + "\nCheck-in Date: " + check_inDate + "\nCheck-out Date: " + check_outDate + "\nSeason: " + season + "\nTotal Cost: " + totalCost;
        }
        #endregion
    }
}
