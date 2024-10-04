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
            ageTextBox.Visible = false;
            ageLabel.Visible = false;
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
            nameTextBox.Text = ageTextBox.Text = lastNameTextBox.Text = phoneTextBox.Text = emailTextBox.Text = roomTextBox.Text = adultsTextBox.Text = childrenTextBox.Text = regionTextBox.Text = specialRequestTextBox.Text = "";
        }
        public void NextButton()
        {
            nextButton.Enabled = false;
        }


        private void childrenTextBox_TextChanged(object sender, EventArgs e)
        {
            try { 
                if (childrenTextBox.Text != "" && Convert.ToInt32(childrenTextBox.Text) > 0)
                {
                    ageTextBox.Visible = true;
                    ageLabel.Visible = true;
                }
                else
                {
                    ageTextBox.Visible = false;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid number of children "+ex);
            }
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
                string age = ageTextBox.Text;

                string guestID = RandomString(7);
                string reservationID = RandomString(8);

                List<Guest> guests = new List<Guest>();
                try
                {
                    int[] ageList = age.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                    for (int i = 0; i < Convert.ToInt32(numberOfChildren); i++)
                    {
                        guests.Add(new Child(name, lastName, phone, email, guestID, ageList[i]));
                    }
                }
                catch (Exception ex)
                {
                }

                
                for (int i = 0; i < Convert.ToInt32(numberOfAdults); i++)
                {
                    guests.Add(new Adult(name, lastName, phone, email, guestID));
                }


                ReservationDatabase db = new ReservationDatabase("Reservation");
                GuestDatabase guestDb = new GuestDatabase("Guest");
                RoomDatabase roomDb = new RoomDatabase("Room");

                if (roomDb.IsAvailableRooms())
                {
                    string roomID = roomDb.UpdateRooms();
                    room = new Room(roomID, 2000, 4, Room.RoomStatus.Available);
                    reservation = new Reservation(guests, reservationID, checkInDateTime, checkOutDateTime, room, Convert.ToInt32(numberOfAdults), Convert.ToInt32(numberOfChildren), specialRequest);
                    double cost = reservation.CalculateTotalCost() * Convert.ToInt32(roomsRequired);

                    costTextBox.Text = "R" + cost.ToString();




                    if (individualRadioButton.Checked)
                    {
                        PaymentForm paymentForm = new PaymentForm();
                        paymentForm.Show();
                        paymentForm.totalCostTextBox.Text = "R" + cost.ToString();
                    }
                    if (travellingAgentRadioButton.Checked || companyRadioButton.Checked)
                    {
                        double c = cost * 0.1;
                        MessageBox.Show("Thank you booking with us. An email has been sent, please confirm the booking and pay the deposit of " + c + " within 14 days.");
                    }

                    db.AddReservation(reservationID, roomID, guestID, checkInDateTime, checkOutDateTime, specialRequest, cost);
                    guestDb.AddGuest(guestID, name, lastName, phone, email);
                }
                else
                {
                    MessageBox.Show("Sorry, there are no rooms available");
                }
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

        private void travellingAgentRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void companyRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
 