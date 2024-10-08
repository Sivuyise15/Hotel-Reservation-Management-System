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
    public partial class addGuest : Form
    {
        public addGuest()
        {
            InitializeComponent();
        }
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

        private void doneButton_Click(object sender, EventArgs e)
        {
            string Name = nameTextBox.Text;
            string LastName = lastNameTextBox.Text;
            string Phone = phoneTextBox.Text;
            string Email = emailTextBox.Text;
            string PhoneNumber = phoneTextBox.Text;
            string guestID = RandomString(6);

            GuestDatabase guestDatabase = new GuestDatabase("Guest");
            guestDatabase.AddGuest(guestID, Name, LastName, Phone, Email);
            this.Close();

        }
    }
}
