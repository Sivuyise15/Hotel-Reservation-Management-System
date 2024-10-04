using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inf2010s_semesterProject.Data
{
    public class RoomDatabase:Database  
    {
        public RoomDatabase(string table):base(table)
        {
        }

        /** Show rooms with available statuts */
        public void ShowAvailableRooms()
        {
            SqlCommand SqlSelect = new SqlCommand("SELECT * FROM Room WHERE Status = 'Available'", conStr);
            DataAdapter.SelectCommand = SqlSelect;

            DataSet.Clear();
            conStr.Open();
            DataAdapter.Fill(DataSet, "Room");
            conStr.Close();
        }
        /** return boolean if there is any room available */
        public bool IsAvailableRooms() {
            SqlCommand SqlSelect = new SqlCommand("SELECT * FROM Room WHERE Status = 'Available'", conStr);
            DataAdapter.SelectCommand = SqlSelect;

            conStr.Open();
            DataAdapter.Fill(DataSet, "Room");
            conStr.Close();
            if (DataSet.Tables["Room"].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        /** return roomID  and update of the room to unavailable */
        public string UpdateRooms() {
            SqlCommand SqlSelect = new SqlCommand("SELECT TOP 1 * FROM Room WHERE Status = 'Available'", conStr);
            DataAdapter.SelectCommand = SqlSelect;

            conStr.Open();
            DataAdapter.Fill(DataSet, "Room");
            conStr.Close();
            string roomID = DataSet.Tables["Room"].Rows[0]["RoomID"].ToString();
            SqlCommand SqlUpdate = new SqlCommand("UPDATE Room SET Status = 'Reserved' WHERE RoomID = '" + roomID + "'", conStr);
            conStr.Open();
            SqlUpdate.ExecuteNonQuery();
            conStr.Close();
            return roomID;
        }
    }
}
