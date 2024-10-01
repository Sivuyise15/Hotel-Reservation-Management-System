using inf2010s_semesterProject.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * A data layer class that will handle the actual interaction with the database for reservations.
 * This class will have methods to add, remove, update and retrieve reservations from the database.
 */
namespace inf2010s_semesterProject.Data
{
    public class ReservationDataBase : Database
    {
        #region Fields
        private string tableName = "Reservation";
        private string sql1 = "INSERT INTO Reservation (ReservationID,GuestID, RoomID, CheckInDate, CheckOutDate, SpecialRequests) " +
                            "VALUES (@ReservationID, @GuestID, @RoomID, @CheckInDate, @CheckOutDate, @SpecialRequests)";
        #endregion

        #region Constructor
        public ReservationDataBase() : base()
        {
        }
        #endregion

        #region Database operations CRUD

        public void DataSetChanges(Reservation reservation, Database.DBOperation operation)
        {
            DataRow dr = null;

            try
            {
                dr = dsMain.Tables[tableName].NewRow();
                dr["ReservationID"] = reservation.ReservationID;
                dr["GuestID"] = reservation.Guest.GuestID;
                dr["RoomID"] = reservation.Room.RoomID;
                dr["CheckInDate"] = reservation.CheckInDate;
                dr["CheckOutDate"] = reservation.CheckOutDate;
                dr["SpecialRequests"] = reservation.SpecialRequests;

                dsMain.Tables[tableName].Rows.Add(dr);
                if (operation == DBOperation.Add)
                {
                    if (UpdateDataSource(reservation))
                    {
                        daMain.Update(dsMain, tableName);
                    }
                }
                else if (operation == DBOperation.Edit)
                {
                    daMain.Update(dsMain, tableName);
                }
                else if (operation == DBOperation.Delete)
                {
                    dr = dsMain.Tables[tableName].Rows.Find(reservation.ReservationID);
                    dr.Delete();
                    daMain.Update(dsMain, tableName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /**
         * Adds a reservation to the database.
         * @param reservation The reservation to add to the database.
         * @return True if the reservation was added successfully, false otherwise.
         */
        private void Build_Insert_Parameters(Reservation reservation) { 
            SqlParameter param  = default(SqlParameter);
            param = new SqlParameter("@ReservationID", SqlDbType.NVarChar, 50, "ReservationID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 50, "RoomID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.NVarChar, 50, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter(
                "@CheckOutDate", SqlDbType.NVarChar, 50, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SpecialRequests", SqlDbType.NVarChar, 50, "SpecialRequests");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Create_Insert_Command(Reservation reservation) {
            daMain.InsertCommand = new SqlCommand(sql1, cnMain);
            Build_Insert_Parameters(reservation);
        }

        public bool UpdateDataSource(Reservation reservation) {
            bool success = false;

            try {
                Create_Insert_Command(reservation);
                daMain.Update(dsMain, tableName);
                success = true;
            } catch (Exception ex) {
                throw ex;
            }

            return success;
        }

        #endregion

    }
}
