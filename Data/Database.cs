using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using inf2010s_semesterProject.Properties;
/**
 * This class 
 * 
 */
namespace inf2010s_semesterProject.Data
{
    public class Database
    {
        #region Fields
        private string connectionString = Settings.Default.phumlaKamnandiDataBaseConnectionString;
        protected SqlConnection sqlConnection;
        protected DataSet dataSet;
        protected SqlDataAdapter dataAdapter;

        public enum dataBaseOperation
        {
            Add = 0, Update = 1, Delete = 2, Select = 3
        }
        #endregion
        #region
        public Database() {
            try { 
                sqlConnection = new SqlConnection(connectionString);
                dataSet = new DataSet();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region update the dataSet
        public void FillDataSet(string sql, string table)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                sqlConnection.Open();
                dataAdapter.Fill(dataSet, table);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region update the data source
        public bool UpdateDataSource(string sql, string table)
        {
            bool sucess;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                sqlConnection.Open();
                dataAdapter.Update(dataSet, table);
                sqlConnection.Close();
                FillDataSet(sql, table);
                sucess =  true;
            }
            catch (Exception ex)
            {
                sucess = false;
                throw ex;
                
            }
            finally { 
            
            }
            return sucess;
        }

        #endregion
    }
}
