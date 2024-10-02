namespace inf2010s_semesterProject.Presantation
{
    partial class CancelReservation
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
            this.ReservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.cancelResevGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelReservationButton = new System.Windows.Forms.Button();
            this.cancelResevGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReservationIDLabel
            // 
            this.ReservationIDLabel.AutoSize = true;
            this.ReservationIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationIDLabel.Location = new System.Drawing.Point(21, 33);
            this.ReservationIDLabel.Name = "ReservationIDLabel";
            this.ReservationIDLabel.Size = new System.Drawing.Size(93, 16);
            this.ReservationIDLabel.TabIndex = 0;
            this.ReservationIDLabel.Text = "ReservationID";
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.Location = new System.Drawing.Point(24, 60);
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.reservationIDTextBox.TabIndex = 1;
            this.reservationIDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cancelResevGroupBox
            // 
            this.cancelResevGroupBox.Controls.Add(this.ReservationIDLabel);
            this.cancelResevGroupBox.Controls.Add(this.reservationIDTextBox);
            this.cancelResevGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelResevGroupBox.Location = new System.Drawing.Point(12, 34);
            this.cancelResevGroupBox.Name = "cancelResevGroupBox";
            this.cancelResevGroupBox.Size = new System.Drawing.Size(342, 100);
            this.cancelResevGroupBox.TabIndex = 2;
            this.cancelResevGroupBox.TabStop = false;
            this.cancelResevGroupBox.Text = "Please Enter the ReservationID to cancel";
            // 
            // cancelReservationButton
            // 
            this.cancelReservationButton.Location = new System.Drawing.Point(254, 169);
            this.cancelReservationButton.Name = "cancelReservationButton";
            this.cancelReservationButton.Size = new System.Drawing.Size(75, 23);
            this.cancelReservationButton.TabIndex = 3;
            this.cancelReservationButton.Text = "DONE";
            this.cancelReservationButton.UseVisualStyleBackColor = true;
            this.cancelReservationButton.Click += new System.EventHandler(this.cancelReservationButton_Click);
            // 
            // CancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 221);
            this.Controls.Add(this.cancelReservationButton);
            this.Controls.Add(this.cancelResevGroupBox);
            this.Name = "CancelReservation";
            this.Text = "CancelReservation";
            this.cancelResevGroupBox.ResumeLayout(false);
            this.cancelResevGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ReservationIDLabel;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.GroupBox cancelResevGroupBox;
        private System.Windows.Forms.Button cancelReservationButton;
    }
}