namespace inf2010s_semesterProject.Presantation
{
    partial class ShowGuest
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
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.guestViewGroupBox = new System.Windows.Forms.GroupBox();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.guestDataGridView = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.guestViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDTextBox.Location = new System.Drawing.Point(44, 82);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(352, 26);
            this.guestIDTextBox.TabIndex = 0;
            this.guestIDTextBox.TextChanged += new System.EventHandler(this.guestIDTextBox_TextChanged);
            // 
            // guestViewGroupBox
            // 
            this.guestViewGroupBox.Controls.Add(this.guestDataGridView);
            this.guestViewGroupBox.Controls.Add(this.guestIDLabel);
            this.guestViewGroupBox.Controls.Add(this.guestIDTextBox);
            this.guestViewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestViewGroupBox.Location = new System.Drawing.Point(28, 12);
            this.guestViewGroupBox.Name = "guestViewGroupBox";
            this.guestViewGroupBox.Size = new System.Drawing.Size(749, 385);
            this.guestViewGroupBox.TabIndex = 2;
            this.guestViewGroupBox.TabStop = false;
            this.guestViewGroupBox.Text = "Enter the guest ID to view their details.";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDLabel.Location = new System.Drawing.Point(40, 59);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(70, 20);
            this.guestIDLabel.TabIndex = 2;
            this.guestIDLabel.Text = "GuestID";
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(679, 414);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "OKAY";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // guestDataGridView
            // 
            this.guestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestDataGridView.Location = new System.Drawing.Point(44, 148);
            this.guestDataGridView.Name = "guestDataGridView";
            this.guestDataGridView.Size = new System.Drawing.Size(682, 150);
            this.guestDataGridView.TabIndex = 3;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(588, 414);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "VIEW";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // ShowGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 479);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.guestViewGroupBox);
            this.Name = "ShowGuest";
            this.Text = "ShowGuest";
            this.Load += new System.EventHandler(this.ShowGuest_Load);
            this.guestViewGroupBox.ResumeLayout(false);
            this.guestViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.GroupBox guestViewGroupBox;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.DataGridView guestDataGridView;
        private System.Windows.Forms.Button viewButton;
    }
}