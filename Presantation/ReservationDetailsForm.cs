using inf2010s_semesterProject.Business;
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
    public partial class ReservationDetailsForm : Form
    {
        #region Fields
        Room room;
        Reservation reservation;
        #endregion

        public ReservationDetailsForm()
        {
            InitializeComponent();
            room = new Room();
            reservation = new Reservation();
        }
        private void ReservationDetailsForm_Load(object sender, EventArgs e)
        {
            
        }

        /**
         * Creating a random string which wil be RoomID, ReservationID
         */
        public string RandomString(int length)
        {
            StringBuilder StringBuilder = new StringBuilder(length);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder.Clear();
            for (int i = 0; i < length; i++)
            {
                StringBuilder.Append(chars[random.Next(chars.Length)]);
            }
            return StringBuilder.ToString();
        }
        public void Clear()
        {
            nameTextBox.Text = lastNameTextBox.Text = phoneTextBox.Text = emailTextBox.Text = roomTextBox.Text = adultsTextBox.Text = childrenTextBox.Text = regionTextBox.Text = specialRequestTextBox.Text = "";
        }

        private void childrenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;
                string roomsRequired = roomTextBox.Text;
                DateTime checkInDateTime = checkInDateTimePicker.Value;
                DateTime checkOutDateTime = checkOutDateTimePicker.Value;
                string numberOfAdults = adultsTextBox.Text;
                string numberOfChildren = childrenTextBox.Text;
                string specialRequest = specialRequestTextBox.Text;

                string guestID = RandomString(7);
                string reservationID = RandomString(8);
                string roomID = RandomString(9);

                List<Guest> guests = new List<Guest>();
                for (int i = 0; i < Convert.ToInt32(numberOfAdults); i++)
                {
                    guests.Add(new Adult(name, lastName, phone, email, guestID));
                }
                for (int i = 0; i < Convert.ToInt32(numberOfChildren); i++)
                {
                    guests.Add(new Child(name, lastName, phone, email, guestID, 15));
                }


                room = new Room(roomID, 2000, 4, Room.RoomStatus.Available);
                reservation = new Reservation(guests, reservationID, checkInDateTime, checkOutDateTime, room, Convert.ToInt32(numberOfAdults), Convert.ToInt32(numberOfChildren), specialRequest);
                double cost = reservation.CalculateTotalCost();

                costTextBox.Text = "R" + cost.ToString();
                
                ReservationDatabase db = new ReservationDatabase("Reservation");
                GuestDatabase guestDb = new GuestDatabase("Guest");


                if (individualRadioButton.Checked)
                {
                    PaymentForm paymentForm = new PaymentForm();
                    paymentForm.Show();
                    paymentForm.totalCostTextBox.Text = "R" + cost.ToString();
                }

                db.AddReservation(reservationID, roomID, guestID, checkInDateTime, checkOutDateTime, specialRequest, cost);
                guestDb.AddGuest(guestID, name, lastName, phone, email);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
 