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
        private string reservationID, check_inDate, check_outDate;
        private Room room;
        private int numberOfAdults, numberOfChildren;
        private double price;
        private Season season;
        private Guest guest;
        private int numberOfGuests;
        private string specialRequests;
        public enum Season
        {
            Low,
            Mid,
            High
        }
        #endregion
        #region Properties
        public string CheckInDate
        {
            get { return check_inDate; }
            set { check_inDate = value; }
        }
        public string CheckOutDate
        {
            get { return check_outDate; }
            set { check_outDate = value; }
        }
        public string SpecialRequests
        {
            get { return specialRequests; }
            set { specialRequests = value; }
        }
        public int NumberOfGuests
        {
            get { return numberOfGuests; }
            set { numberOfGuests = numberOfAdults + numberOfChildren; }
        }
        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
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
        public Reservation(Guest guest, string reservationID, string check_inDate, string check_outDate, Room room, int numberOfAdults, int numberOfChildren, double price, Season season, string specialRequests)
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
            this.specialRequests = specialRequests;
        }
        #endregion
        #region Methods
        public double CalculateTotalCost()
        {
            //Edit later to use DateTime instead of parsed integers
            int[] checkIn = Array.ConvertAll(check_inDate.Split('/'), int.Parse);
            int[] checkOut = Array.ConvertAll(check_outDate.Split('/'), int.Parse);
            int totalDays = (checkOut[0] - checkIn[0]) + (checkOut[1] - checkIn[1]) + (checkOut[2] - checkIn[2]);
            return guest.CalculateCost(price, totalDays);
        }
        #endregion
    }
}
