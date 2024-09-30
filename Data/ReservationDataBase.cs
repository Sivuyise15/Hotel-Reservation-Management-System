using inf2010s_semesterProject.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * A data layer class that will handle the actual interaction with the database for reservations.
 * This class will have methods to add, remove, update and retrieve reservations from the database.
 */
namespace inf2010s_semesterProject.Data
{
    public class ReservationDataBase: Database
    {
        public ReservationDataBase():base()
        {
        }
        /**Method to retrieve all reservations from the database.
         * @return DataSet containing all reservations.
         */
        public DataSet GetAllReservation() { 
            string sql = "SELECT * FROM Reservation";
            FillDataSet(sql, "Reservation");
            return dataSet;
        }
        /**Method to add a reservation to the database.
         * @param reservation The reservation to be added.
         * @return True if the reservation was added successfully, false otherwise.
         */
        public bool AddReservation(Reservation reservation) { 
            string sql = "INSERT INTO Reservation (ReservationID, CheckInDate, CheckOutDate, NumberOfGuests, RoomID, GuestID) VALUES ('" + reservation.ReservationID + "', '" + reservation.CheckInDate + "', '" + reservation.CheckOutDate + "', '" + reservation.NumberOfGuests + "', '" + reservation.Room.RoomID + "', '" + reservation.Guest.GuestID + "')";
            return UpdateDataSource(sql, "Reservation");

        }
        /**Method to update a reservation in the database.
         * @param reservation The reservation to be updated.
         * @return True if the reservation was updated successfully, false otherwise.
         */
        public bool UpdateReservation(Reservation reservation) { 
            string sql = "UPDATE Reservation SET CheckInDate = '" + reservation.CheckInDate + "', CheckOutDate = '" + reservation.CheckOutDate + "', NumberOfGuests = '" + reservation.NumberOfGuests + "', RoomID = '" + reservation.Room.RoomID + "', GuestID = '" + reservation.Guest.GuestID + "' WHERE ReservationID = '" + reservation.ReservationID + "'";
            return UpdateDataSource(sql, "Reservation");
        }
        /**Method to remove a reservation from the database.
         * @param reservation The reservation to be removed.
         * @return True if the reservation was removed successfully, false otherwise.
         */
        public bool DeleteReservation(Reservation reservation) { 
            string sql = "DELETE FROM Reservation WHERE ReservationID = '" + reservation.ReservationID + "'";
            return UpdateDataSource(sql, "Reservation");
        }
        /**Method to retrieve a reservation from the database by its ID.
         * @param reservationID The ID of the reservation to be retrieved.
         * @return DataSet containing the reservation with the specified ID.
         */
        public DataSet GetReservationByGuestID(string guestID)
        {
            string sql = "SELECT * FROM Reservation WHERE GuestID = '" + guestID + "'";
            FillDataSet(sql, "Reservation");
            return dataSet;
        }

    }
}
