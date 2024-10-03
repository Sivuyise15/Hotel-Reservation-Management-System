namespace inf2010s_semesterProject.Presantation
{
    partial class ReservationListingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reservationListView = new System.Windows.Forms.ListView();
            this.labelList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reservationListView
            // 
            this.reservationListView.HideSelection = false;
            this.reservationListView.Location = new System.Drawing.Point(15, 54);
            this.reservationListView.Name = "reservationListView";
            this.reservationListView.Size = new System.Drawing.Size(307, 309);
            this.reservationListView.TabIndex = 0;
            this.reservationListView.UseCompatibleStateImageBehavior = false;
            this.reservationListView.View = System.Windows.Forms.View.Details;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(12, 23);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(87, 16);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "Reservations";
            // 
            // ReservationListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 383);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.reservationListView);
            this.Name = "ReservationListingForm";
            this.Text = "ReservationListingForm";
            this.Load += new System.EventHandler(this.ReservationListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView reservationListView;
        private System.Windows.Forms.Label labelList;
    }
}