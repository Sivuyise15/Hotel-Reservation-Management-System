using inf2010s_semesterProject.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        #region Data members
        private string table1 = "Reservation";
        private string sqlLocal1 = "SELECT * FROM Reservation";
        private Collection<Reservation> reservations;
        #endregion

        #region Property Method: Collection
        public Collection<Reservation> AllReservations
        {
            get
            {
                return reservations;
            }
        }
        #endregion

        #region Constructor
        public ReservationDataBase() : base()
        {
            reservations = new Collection<Reservation>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }
        #endregion

        #region Utility Methods
        private void Add2Collection(string table)
        {
            DataRow myRow;
            Reservation res;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    // Instantiate a new Reservation object
                    res = new Reservation();
                    res.Room = new Room();
                    res.Guest = new Guest();
                    // Obtain each reservation attribute from the row in the table
                    res.ReservationID = Convert.ToString(myRow["ReservationID"]).TrimEnd();
                    res.Room.RoomID = Convert.ToString(myRow["RoomID"]).TrimEnd();
                    res.Guest.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    res.CheckInDate = Convert.ToString(myRow["CheckInDate"]).TrimEnd();
                    res.CheckOutDate = Convert.ToString(myRow["CheckOutDate"]).TrimEnd();
                    // Add to the collection
                    reservations.Add(res);
                }
            }
        }



        private void FillRow(DataRow aRow, Reservation aReservation)
        {
            aRow["ReservationID"] = aReservation.ReservationID;
            aRow["RoomID"] = aReservation.Room.RoomID;
            aRow["GuestID"] = aReservation.Guest.GuestID;
            aRow["CheckInDate"] = aReservation.CheckInDate;
            aRow["CheckOutDate"] = aReservation.CheckOutDate;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Reservation res, Database.DBOperation dBOperation)
        {
            DataRow aRow = null;
            switch (dBOperation)
            {
                case Database.DBOperation.Add:
                    aRow = dsMain.Tables[table1].NewRow();
                    FillRow(aRow, res);
                    dsMain.Tables[table1].Rows.Add(aRow); // Add to the dataset
                    break;
                case Database.DBOperation.Edit:
                    // To implement the edit logic here
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update Database
        private void Build_INSERT_Parameters(Reservation aReservation)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ReservationID", SqlDbType.NVarChar, 15, "ReservationID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("GuestID", SqlDbType.NVarChar, 15, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("RoomID", SqlDbType.NVarChar, 15, "RoomID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.NVarChar, 15, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter(
                "@CheckOutDate", SqlDbType.NVarChar, 15, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Reservation aReservation)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Reservation (ReservationID, GuestID, RoomID, CheckInDate, CheckOutDate) VALUES (@ReservationID, @GuestID, @RoomID, @CheckInDate, @CheckOutDate)", cnMain);
            Build_INSERT_Parameters(aReservation);
        }

        public bool UpdateDataSource(Reservation res)
        {
            bool success = true;
            Create_INSERT_Command(res);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        #endregion
    }


}
