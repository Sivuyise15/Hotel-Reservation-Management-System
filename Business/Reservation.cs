using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class Reservation
    {
        #region Fields
        private string reservationID, check_inDate, check_outDate, roomID;
        private int numberOfAdults, numberOfChildren;
        private double totalCost;
        private Season season;

        public enum Season
        {
            Low,
            High
        }
        #endregion
        #region Properties
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
        public int NumberOfAdults
        {
            get { return numberOfAdults; }
            set { numberOfAdults = value; }
        }
        public int NumberOfChildren
        {
            get { return numberOfChildren; }
            set { numberOfChildren = value; }
        }
        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        public Season Season_Enum
        {
            get { return season; }
            set { season = value; }
        }
        #endregion
        #region Constructor
        public Reservation()
        {
            reservationID = "";
            check_inDate = "";
            check_outDate = "";
            roomID = "";
            numberOfAdults = 0;
            numberOfChildren = 0;
            totalCost = 0;
            season = Season.Low;
        }
        public Reservation(string reservationID, string check_inDate, string check_outDate, string roomID, int numberOfAdults, int numberOfChildren, double totalCost, Season season)
        {
            this.reservationID = reservationID;
            this.check_inDate = check_inDate;
            this.check_outDate = check_outDate;
            this.roomID = roomID;
            this.numberOfAdults = numberOfAdults;
            this.numberOfChildren = numberOfChildren;
            this.totalCost = totalCost;
            this.season = season;
        }
        #endregion
    }
}
