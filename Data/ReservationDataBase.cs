using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inf2010s_semesterProject.Data
{
    public class ReservationDatabase: Database
    {
        public ReservationDatabase(string table):base(table)
        {
        }

        public void AddReservation(string ReservationID, string RoomID, string GuestID, DateTime CheckIn, DateTime CheckOut, string specialRequest, double cost) { 

            SqlCommand SqlInsert = new SqlCommand("INSERT INTO Reservation (ReservationID, GuestID, RoomID, CheckInDate, CheckOutDate, ReservationTotalCost, SpecialRequests) VALUES (@ReservationID, @GuestID, @RoomID, @CheckInDate, @CheckOutDate,  @ReservationTotalCost, @SpecialRequests)", conStr);
            SqlInsert.Parameters.Add(@"ReservationID",SqlDbType.NVarChar, 50, "ReservationID").Value = ReservationID;
            SqlInsert.Parameters.Add(@"RoomID", SqlDbType.NVarChar, 50, "RoomID").Value = RoomID;
            SqlInsert.Parameters.Add(@"GuestID", SqlDbType.NVarChar, 50, "GuestID").Value = GuestID;
            SqlInsert.Parameters.Add(@"CheckInDate", SqlDbType.Date).Value = CheckIn;
            SqlInsert.Parameters.Add(@"CheckOutDate", SqlDbType.Date).Value = CheckOut;
            SqlInsert.Parameters.Add(@"SpecialRequests", SqlDbType.NVarChar, 50, "SpecialRequests").Value = specialRequest;
            SqlInsert.Parameters.Add(@"ReservationTotalCost", SqlDbType.Money, 50, "ReservationTotalCost").Value = cost;

            conStr.Open();
            SqlInsert.ExecuteNonQuery();
            conStr.Close();

        }

        /**
         * Cancell reservaation by ReservationID
         */

        public void CancelReservation(string ReservationID) { 
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Reservation WHERE ReservationID = @ReservationID", conStr);
            sqlCommand.Parameters.Add(@"ReservationID", SqlDbType.NVarChar, 50, "ReservationID").Value = ReservationID;
            
            conStr.Open();
            sqlCommand.ExecuteNonQuery();
            conStr.Close();
        }
        /** select guest by their reservation and return the all the guest details
         */
        public DataTable SelectGuestByReservation(string ReservationID)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Guest g INNER JOIN Reservation r ON g.GuestID = r.GuestID WHERE r.ReservationID = @ReservationID;", conStr);
            sqlCommand.Parameters.Add(@"ReservationID", SqlDbType.NVarChar, 50, "ReservationID").Value = ReservationID;
            conStr.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            conStr.Close();
            return dataTable;

        }
    
    }
}
