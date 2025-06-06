﻿using inf2010s_semesterProject.Data;
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
    public partial class CancelReservation : Form
    {
        public CancelReservation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelReservationButton_Click(object sender, EventArgs e)
        {
            ReservationDatabase reservationDatabase = new ReservationDatabase("Reservation");
            GuestDatabase guestDatabase = new GuestDatabase("Guest");
            try
            {
                if (reservationDatabase.SearchReservation(reservationIDTextBox.Text)){
                    reservationDatabase.CancelReservation(reservationIDTextBox.Text);
                    guestDatabase.DeleteGuest(guestTextBox.Text);
                    MessageBox.Show("Reservation " + reservationIDTextBox.Text + " Cancelled! Thank you for booking with us.");
                    this.Close();
                }
                                else
                {
                    MessageBox.Show("Reservation " + reservationIDTextBox.Text + " not found.");
                }
            }
                        catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
