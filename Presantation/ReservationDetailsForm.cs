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
        
        public ReservationDetailsForm()
        {
            InitializeComponent();
        }

        /**
         * Creating a random string which wil be RoomID, ReservationID
         */
        public string RandomString(int length)
        {
            StringBuilder StringBuilder = new StringBuilder(7);
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
            try { 
                string name = nameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;
                string roomsRequied = roomTextBox.Text;
                string checkIn = checkInTextBox.Text;
                string checkOut = checkOutTextBox.Text;
                string numberOfAdults = adultsTextBox.Text;
                string numberOfChildren = childrenTextBox.Text;
                string region = regionTextBox.Text;
                string specialRequest = specialRequestTextBox.Text;

                string guestID = RandomString(7);
                string reservationID = RandomString(8);
                string roomID = RandomString(9);

                Guest guest = new Guest(name, lastName, phone, email, guestID, reservationID, roomID, checkIn, checkOut);
                Room room = new Room(roomID, 2000, 4, Room.RoomStatus.Available);

                Reservation reservation = new Reservation(guest, reservationID, checkIn, checkOut, room , Convert.ToInt32(numberOfAdults), Convert.ToInt32(numberOfChildren), 2000, Reservation.Season.High, specialRequest);
                ReservationDataBase reservationData = new ReservationDataBase();
                Database database = new Database();

                ReservationController reservationController = new ReservationController();

                bool isAdded = reservationController.FinalizeReservation(reservation);

                if (isAdded)
                {
                    MessageBox.Show("Reservation has been made successfully");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Reservation has not been made successfully");
                }
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
 