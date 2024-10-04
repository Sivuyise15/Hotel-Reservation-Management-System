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

        private double lowSeasonPrice = 550;
        private double midSeasonPrice = 750;
        private double highSeasonPrice = 995;
        private double generalPrice = 600;

        // fields
        private string reservationID;
        private DateTime checkInDate;
        private DateTime checkOutDate;
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
        
        public DateTime CheckInDate { 
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
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
            checkInDate = DateTime.Now;
            checkOutDate = DateTime.Now;
            room = null;
            numberOfAdults = 0;
            numberOfChildren = 0;
        }
        public Reservation(List<Guest> guests, string reservationID, DateTime checkIn, DateTime checkOut, Room room, int numberOfAdults, int numberOfChildren, string specialRequests)
        {
            this.guests = guests;
            this.reservationID = reservationID;
            this.checkInDate = checkIn;
            this.checkOutDate = checkOut;
            this.room = room;
            this.numberOfAdults = numberOfAdults;
            this.numberOfChildren = numberOfChildren;
            this.specialRequests = specialRequests;
        }
        #endregion
        #region Methods
        public double CalculateTotalCost()
        {
            int totalDays = checkOutDate.Day - checkInDate.Day;

            double totalCost = 0;
            try { 

                for (int i = 0; i < guests.Count; i++)
                {
                    if (checkInDate.Day > 0 && checkInDate.Day <= 7 && checkInDate.Month == 12)
                    {
                        totalCost += guests[i].CalculateCost(lowSeasonPrice, totalDays);
                    }
                    else if (checkInDate.Day >= 8 && checkInDate.Day <= 15 && checkInDate.Month == 12)
                    {
                        totalCost += guests[i].CalculateCost(midSeasonPrice, totalDays);
                    }
                    else if (checkInDate.Day > 15 && checkInDate.Day <= 31 && checkInDate.Month == 12)
                    {
                        totalCost += guests[i].CalculateCost(highSeasonPrice, totalDays);
                    }
                    else
                    {
                        totalCost += guests[i].CalculateCost(generalPrice, totalDays);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return totalCost;
        }
        #endregion
    }
}
