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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void cardNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void totalCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservation succesfully completed! A confirmation email will be sent to customer shortly with all the reservation details. Thank you.");
            this.Close();
        }
    }
}
