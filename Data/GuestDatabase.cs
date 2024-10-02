using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace inf2010s_semesterProject.Data
{
    public class GuestDatabase:Database
    {
        public GuestDatabase(string table):base(table)
        {
        }

        public void AddGuest(string GuestID, string Name, string LastName, string Phone, string Email)
        {
            SqlCommand SqlInsert = new SqlCommand("INSERT INTO Guest (GuestID, FirstName, LastName, Email,PhoneNumber) VALUES (@GuestID, @FirstName, @LastName, @Email, @PhoneNumber)", conStr);
            SqlInsert.Parameters.Add(@"GuestID", SqlDbType.NVarChar, 50, "GuestID").Value = GuestID;
            SqlInsert.Parameters.Add(@"FirstName", SqlDbType.NVarChar, 50, "FirstName").Value = Name;
            SqlInsert.Parameters.Add(@"LastName", SqlDbType.NVarChar, 50, "LastName").Value = LastName;
            SqlInsert.Parameters.Add(@"PhoneNumber", SqlDbType.NVarChar, 50, "PhoneNumber").Value = Phone;
            SqlInsert.Parameters.Add(@"Email", SqlDbType.NVarChar, 50, "Email").Value = Email;

            conStr.Open();
            SqlInsert.ExecuteNonQuery();
            conStr.Close();
        }
    }
}
