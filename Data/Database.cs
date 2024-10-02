using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Data
{
    public class Database
    {
        public DataSet DataSet = new DataSet();
        public SqlConnection conStr = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SIVUYISE\OneDrive - University of Cape Town\INF2011S\Semester Project\phumlakamnandiProject\inf2010s_semesterProject\phumlaKamnandiDataBase.mdf;Integrated Security=True");
        public SqlDataAdapter DataAdapter = new SqlDataAdapter();
        public Database(string table)
        {
            SqlCommand SqlSelect = new SqlCommand("SELECT * FROM "+table, conStr);
            DataAdapter.SelectCommand = SqlSelect;

            conStr.Open();
            DataAdapter.Fill(DataSet, table);
            conStr.Close();
        }
    }
}
