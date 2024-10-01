using inf2010s_semesterProject.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class ReservationController
    {
        #region Data Members
        ReservationDataBase reservationDB;
        Collection<Reservation> reservations;
        #endregion

        #region Properties
        public Collection<Reservation> AllReservations
        {
            get
            {
                return reservations;
            }
        }
        #endregion

        #region Constructor
        public ReservationController()
        {
            // Instantiate the ReservationDB object to communicate with the database
            reservationDB = new ReservationDataBase();
            reservations = reservationDB.AllReservations;
        }
        #endregion

        #region Database Communication
        public void DataMaintenance(Reservation res, Database.DBOperation dBOperation)
        {
            int index = 0;
            // Perform a given database operation to the dataset in memory
            reservationDB.DataSetChange(res, dBOperation);
            switch (dBOperation)
            {
                case Database.DBOperation.Add:
                    reservations.Add(res); // Add the reservation to the collection
                    break;
                case Database.DBOperation.Edit:
                    index = FindIndex(res.ReservationID);
                    reservations[index] = res; // Update the reservation in the collection
                    break;
            }
        }

        public bool FinalizeChanges(Reservation res)
        {
            // Commit the changes to the database
            return reservationDB.UpdateDataSource(res);
        }
        #endregion

        #region Utility Methods
        public int FindIndex(string resID)
        {
            int index = 0;
            foreach (Reservation res in reservations)
            {
                if (res.ReservationID == resID)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        #endregion
    }

}
