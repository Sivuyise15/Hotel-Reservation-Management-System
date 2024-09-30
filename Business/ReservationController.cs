using inf2010s_semesterProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class ReservationController
    {
        #region Field
        public List<Reservation> reservations;
        public ReservationDataBase reservationDatabase;
        #endregion

        #region Properties
        public List<Reservation> Reservations
        {
            get { return reservations; }
            set { reservations = value; }
        }
        #endregion

        #region Constructors
        public ReservationController()
        {
            reservations = new List<Reservation>();
            reservationDatabase = new ReservationDataBase();
        }
        #endregion
    }
}
