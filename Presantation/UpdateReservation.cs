using inf2010s_semesterProject.Business;
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
    public partial class UpdateReservation : Form
    {
        public UpdateReservation()
        {
            InitializeComponent();
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateReservation_Load(object sender, EventArgs e)
        {
            checkInDateTimePicker.Visible = false;
            checkOuDateTimePicker.Visible = false;
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            lastNameLabel.Visible = false;
            lastNameTextBox.Visible = false;
            ageLabel.Visible = false;
            ageTextBox.Visible = false;
            phoneLabel.Visible = false;
            phoneTextBox.Visible = false;
            emailLabel.Visible = false;
            emailTextBox.Visible = false;
            roomsLabel.Visible = false;
            roomTextBox.Visible = false;
            adultsLabel.Visible = false;
            adultsTextBox.Visible = false;
            childrenLabel.Visible = false;
            childrenTextBox.Visible = false;
            requestLabel.Visible = false;
            specialRequestTextBox.Visible = false;
            checkLabel.Visible = false;
            checkOutLabel.Visible = false;
            updateButton.Visible = false;
            reservationIDLabel.Visible = false;
            reservationIDTextBox.Visible = false;
            guestIDlabel.Visible = false;
            guestIDTextBox.Visible = false;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            dLabel.Visible = false;
            dateCheckBox.Visible = false;
            guestListCheckBox.Visible = false;
            detailsCheckBox.Visible = false;
            requestsCheckBox.Visible = false;
            doneButton.Visible = false;
            updateButton.Visible = true;

            if(dateCheckBox.Checked)
            {
                reservationIDLabel.Visible = true;
                reservationIDTextBox.Visible = true;
                checkInDateTimePicker.Visible = true;
                checkOuDateTimePicker.Visible = true;
                checkLabel.Visible = true;
                checkOutLabel.Visible = true;
            }
            if(detailsCheckBox.Checked)
            {
                reservationIDLabel.Visible = true;
                reservationIDTextBox.Visible = true;
                guestIDlabel.Visible = true;
                guestIDTextBox.Visible = true;
                nameLabel.Visible = true;
                nameTextBox.Visible = true;
                lastNameLabel.Visible = true;
                lastNameTextBox.Visible = true;
                phoneLabel.Visible = true;
                phoneTextBox.Visible = true;
                emailLabel.Visible = true;
                emailTextBox.Visible = true;
            }
            if(guestListCheckBox.Checked)
            {
                reservationIDLabel.Visible = true;
                reservationIDTextBox.Visible = true;
                guestIDlabel.Visible = true;
                guestIDTextBox.Visible = true;
                ageLabel.Visible = true;
                ageTextBox.Visible = true;
                roomsLabel.Visible = true;
                roomTextBox.Visible = true;
                adultsLabel.Visible = true;
                adultsTextBox.Visible = true;
                childrenLabel.Visible = true;
                childrenTextBox.Visible = true;
                
            }
            if(requestsCheckBox.Checked)
            {
                reservationIDLabel.Visible = true;
                reservationIDTextBox.Visible = true;
                requestLabel.Visible = true;
                specialRequestTextBox.Visible = true;
            }
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string reservationID = reservationIDTextBox.Text;
            string guestID = guestIDTextBox.Text;

            string name = nameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string age = ageTextBox.Text;
            string room = roomTextBox.Text;
            string adults = adultsTextBox.Text;
            string children = childrenTextBox.Text;
            string specialRequest = specialRequestTextBox.Text;
            DateTime checkIn = checkInDateTimePicker.Value;
            DateTime checkOut = checkOuDateTimePicker.Value;

            Reservation reservation = new Reservation();
            reservation.CheckInDate = checkIn;
            reservation.CheckOutDate = checkOut;

     

            if (dateCheckBox.Checked)
            {
                //update reservation
                Data.ReservationDatabase reservationDatabase = new Data.ReservationDatabase("Reservation");
                reservationDatabase.UpdateReservation(reservationID, checkIn, checkOut, specialRequest, 0);
                MessageBox.Show("Reservation with ID " + reservationID + " been updated");
            }
            if (detailsCheckBox.Checked)
            {
                //update guest
                Data.GuestDatabase guestDatabase = new Data.GuestDatabase("Guest");
                guestDatabase.UpdateGuest(guestID, name, lastName, phone, email);
                this.Close();
                MessageBox.Show("Guest details with ID "+guestID+" been updated");
            }
            if (dateCheckBox.Checked) { 
                Data.ReservationDatabase reservationDatabase = new Data.ReservationDatabase("Reservation");
                reservationDatabase.UpdateReservationDate(reservationID, checkIn, checkOut);
            }
            this.Close();

        }
    }
}
