using inf2010s_semesterProject.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inf2010s_semesterProject.Presantation
{
    public partial class ReservationListingForm : Form
    {
        bool reservFormClosed;
        public ReservationListingForm()
        {
            InitializeComponent();
            LoadReservationList();
            reservFormClosed = false;
        }

        private void LoadReservationList()
        {


            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SIVUYISE\OneDrive - University of Cape Town\INF2011S\Semester Project\phumlakamnandiProject\inf2010s_semesterProject\phumlaKamnandiDataBase.mdf"";Integrated Security=True";
            string query = "SELECT ReservationID, GuestID FROM Reservation";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reservationListView.Items.Clear();
                    reservationListView.Columns.Clear();
                    reservationListView.Columns.Add("Reservation ID", 100, HorizontalAlignment.Left);
                    reservationListView.Columns.Add("Guest Name", 150, HorizontalAlignment.Left);
                    while (reader.Read())
                    {
                        // Example: Assuming your Reservation table has these columns: ID, Name, Date
                        ListViewItem item = new ListViewItem(reader["ReservationID"].ToString());
                        item.SubItems.Add(reader["GuestID"].ToString());

                        // Add item to ListView
                        reservationListView.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ReservationListingForm_Load(object sender, EventArgs e)
        {

        }

        private void ReservationListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reservFormClosed = true;
        }
    }
}
