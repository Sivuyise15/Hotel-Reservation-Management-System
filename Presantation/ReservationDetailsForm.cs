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
        Guest guest;
        Room room;
        Reservation reservation;
        #endregion

        public ReservationDetailsForm()
        {
            InitializeComponent();
            guest = new Guest();
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;
                string roomsRequired = roomTextBox.Text;
                string checkIn = checkInTextBox.Text;
                string checkOut = checkOutTextBox.Text;
                string numberOfAdults = adultsTextBox.Text;
                string numberOfChildren = childrenTextBox.Text;
                string specialRequest = specialRequestTextBox.Text;

                string guestID = RandomString(7);
                string reservationID = RandomString(8);
                string roomID = RandomString(9);

                guest = new Guest(name, lastName, phone, email, guestID, reservationID, roomID, checkIn, checkOut);
                room = new Room(roomID, 2000, 4, Room.RoomStatus.Available);
                reservation = new Reservation(guest, reservationID, checkIn, checkOut, room, Convert.ToInt32(numberOfAdults), Convert.ToInt32(numberOfChildren), 2000, Reservation.Season.High, specialRequest);

                ReservationDatabase db = new ReservationDatabase("Reservation");
                db.AddReservation(reservationID, roomID, guestID, checkIn, checkOut, specialRequest);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            nameTextBox.Text = lastNameTextBox.Text = phoneTextBox.Text = emailTextBox.Text = roomTextBox.Text = checkInTextBox.Text = checkOutTextBox.Text = adultsTextBox.Text = childrenTextBox.Text = regionTextBox.Text = specialRequestTextBox.Text = "";
        }

        private void ReservationDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
 