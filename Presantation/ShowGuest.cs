using inf2010s_semesterProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inf2010s_semesterProject.Presantation
{
    public partial class ShowGuest : Form
    {
        public ShowGuest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowGuest_Load(object sender, EventArgs e)
        {
            
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guestIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string id = guestIDTextBox.Text;
            ReservationDatabase reservationDatabase = new ReservationDatabase("Guest");
            DataTable dataTable = reservationDatabase.SelectGuestByReservation(id);
            guestDataGridView.DataSource = dataTable;
        }
    }
}
