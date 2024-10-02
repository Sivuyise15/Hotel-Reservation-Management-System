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
        // prices
        private double lowSeasonPrice = 550;
        private double midSeasonPrice = 750;
        private double highSeasonPrice = 995;
        private double generalPrice = 600;

        // fields
        private string reservationID, check_inDate, check_outDate;
        private Room room;
        private int numberOfAdults, numberOfChildren;
        private int numberOfGuests;
        private string specialRequests;
        private List<Guest> guests;

        #endregion
        #region Properties
        public List<Guest> Guests
        {
            get { return guests; }
            set { guests = value; }
        }
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
        }
        public Reservation(List<Guest> guests, string reservationID, string check_inDate, string check_outDate, Room room, int numberOfAdults, int numberOfChildren, string specialRequests)
        {
            this.guests = guests;
            this.reservationID = reservationID;
            this.check_inDate = check_inDate;
            this.check_outDate = check_outDate;
            this.room = room;
            this.numberOfAdults = numberOfAdults;
            this.numberOfChildren = numberOfChildren;
            this.specialRequests = specialRequests;
        }
        #endregion
        #region Methods
        public double CalculateTotalCost()
        {
            int totalGuests = numberOfAdults + numberOfChildren;
            int[] checkIn = Array.ConvertAll(check_inDate.Split('/'), int.Parse);
            int[] checkOut = Array.ConvertAll(check_outDate.Split('/'), int.Parse);
            int totalDays = (checkOut[2] - checkIn[2]) + (checkOut[1] - checkIn[1]) + (checkOut[0] - checkIn[0]);
            double totalCost = 0;

            for (int i = 0; i < guests.Count; i++)
            {
                if (checkIn[2] > 0 && checkIn[2] <= 7 && checkIn[1] == 12)
                {
                    totalCost =+ guests[i].CalculateCost(lowSeasonPrice, totalDays) * totalGuests;
                }
                else if (checkIn[2] >= 8 && checkIn[2] <= 15 && checkIn[1] == 12)
                {
                    totalCost = +guests[i].CalculateCost(midSeasonPrice, totalDays) * totalGuests;
                }
                else if (checkIn[2] > 15 && checkIn[2] <= 31 && checkIn[1] == 12)
                {
                    totalCost = +guests[i].CalculateCost(highSeasonPrice, totalDays) * totalGuests;
                }
                else
                {
                    totalCost = +guests[i].CalculateCost(generalPrice, totalDays) * totalGuests;
                }
            }
            return totalCost;
        }
        #endregion
    }
}
