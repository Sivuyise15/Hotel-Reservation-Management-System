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
        private string reservationID;
        private Room room;
        private int numberOfAdults, numberOfChildren;
        private double price;
        private Season season;
        private Guest guest;
        private Date check_inDate, check_outDate;

        public enum Season
        {
            Low,
            High
        }
        #endregion
        #region Properties
        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
        }
        public Date Check_inDate
        {
            get { return check_inDate; }
            set { check_inDate = value; }
        }
        public Date Check_outDate
        {
            get { return check_outDate; }
            set { check_outDate = value; }
        }
        public string ReservationID
        {
            get { return reservationID; }
            set { reservationID = value; }
        }
        public Room Room
        {
            get { return room; }
            set { room = value; }
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
            get { return price; }
            set { price = value; }
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
            check_inDate = null;
            check_outDate = null;
            room = null;
            numberOfAdults = 0;
            numberOfChildren = 0;
            price = 0;
            season = Season.Low;
        }
        public Reservation(Guest guest, string reservationID, Date check_inDate, Date check_outDate, Room room, int numberOfAdults, int numberOfChildren, double price, Season season)
        {
            this.guest = guest;
            this.reservationID = reservationID;
            this.check_inDate = check_inDate;
            this.check_outDate = check_outDate;
            this.room = room;
            this.numberOfAdults = numberOfAdults;
            this.numberOfChildren = numberOfChildren;
            this.price = price;
            this.season = season;
        }
        #endregion
        #region
        public double CalculateTotalCost()
        {
            int totalDays = check_outDate.Day - check_inDate.Day;
            return guest.CalculateCost(price, totalDays);
        }
        #endregion
    }
}
