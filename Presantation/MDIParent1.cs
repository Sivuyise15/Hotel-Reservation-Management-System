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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void makeReservationButton_Click(object sender, EventArgs e)
        {
            ReservationDetailsForm res = new ReservationDetailsForm();
            res.Show();
        }

        private void cancelReservationButton_Click(object sender, EventArgs e)
        {
            CancelReservation cancelReservation = new CancelReservation();
            cancelReservation.Show();
        }

        private void showReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationListingForm reservationForm = new ReservationListingForm();

            reservationForm.Show();
        }

        private void checkReservationButton_Click(object sender, EventArgs e)
        {
            ShowGuest showGuest = new ShowGuest();
            showGuest.Show();
        }

        private void updateReservationButton_Click(object sender, EventArgs e)
        {
            UpdateReservation updateReservation = new UpdateReservation();
            updateReservation.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            availableRoomsDataGridView.Visible = false;
            doneButton.Visible = false;
        }

        private void availableRoomsButton_Click(object sender, EventArgs e)
        {
            updateReservationButton.Visible = false;
            availableRoomsDataGridView.Visible = true;
            makeReservationButton.Visible = false;
            cancelReservationButton.Visible = false;
            checkReservationButton.Visible = false;
            availableRoomsButton.Visible = false;
            doneButton.Visible = true;
            welcomeGroupBox.Visible = false;

            Data.RoomDatabase roomDatabase = new Data.RoomDatabase("Room");
            roomDatabase.ShowAvailableRooms();
            availableRoomsDataGridView.DataSource = roomDatabase.DataSet.Tables["Room"];

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            doneButton.Visible = false;
            availableRoomsDataGridView.Visible = false;
            makeReservationButton.Visible = true;
            cancelReservationButton.Visible = true;
            checkReservationButton.Visible = true;
            availableRoomsButton.Visible = true;
            updateReservationButton.Visible = true;
            welcomeGroupBox.Visible = true;
        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can contact us at 1-800-123-4567 or email us at phumlakamnandihotels.co.za. Thank you for choosing us.");
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            addGuest addGuest = new addGuest();
           addGuest.Show();
        }
    }
}
