namespace inf2010s_semesterProject.Presantation
{
    partial class PaymentForm
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
            this.paymentDetailsLabel = new System.Windows.Forms.Label();
            this.creditCardGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cardHolderLabel = new System.Windows.Forms.Label();
            this.cvcTextBox = new System.Windows.Forms.TextBox();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.expiryDateTextBox = new System.Windows.Forms.TextBox();
            this.cvcLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.paymentButton = new System.Windows.Forms.Button();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.creditCardGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentDetailsLabel
            // 
            this.paymentDetailsLabel.AutoSize = true;
            this.paymentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDetailsLabel.Location = new System.Drawing.Point(51, 59);
            this.paymentDetailsLabel.Name = "paymentDetailsLabel";
            this.paymentDetailsLabel.Size = new System.Drawing.Size(165, 25);
            this.paymentDetailsLabel.TabIndex = 0;
            this.paymentDetailsLabel.Text = "Payment details";
            // 
            // creditCardGroupBox
            // 
            this.creditCardGroupBox.Controls.Add(this.textBox4);
            this.creditCardGroupBox.Controls.Add(this.cardHolderLabel);
            this.creditCardGroupBox.Controls.Add(this.cvcTextBox);
            this.creditCardGroupBox.Controls.Add(this.expiryDateLabel);
            this.creditCardGroupBox.Controls.Add(this.expiryDateTextBox);
            this.creditCardGroupBox.Controls.Add(this.cvcLabel);
            this.creditCardGroupBox.Controls.Add(this.textBox1);
            this.creditCardGroupBox.Controls.Add(this.cardNumberLabel);
            this.creditCardGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardGroupBox.Location = new System.Drawing.Point(56, 103);
            this.creditCardGroupBox.Name = "creditCardGroupBox";
            this.creditCardGroupBox.Size = new System.Drawing.Size(438, 244);
            this.creditCardGroupBox.TabIndex = 1;
            this.creditCardGroupBox.TabStop = false;
            this.creditCardGroupBox.Text = "Please enter customer credit card details";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(60, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 21);
            this.textBox4.TabIndex = 7;
            // 
            // cardHolderLabel
            // 
            this.cardHolderLabel.AutoSize = true;
            this.cardHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardHolderLabel.Location = new System.Drawing.Point(53, 38);
            this.cardHolderLabel.Name = "cardHolderLabel";
            this.cardHolderLabel.Size = new System.Drawing.Size(120, 15);
            this.cardHolderLabel.TabIndex = 6;
            this.cardHolderLabel.Text = "Cardholder`s Name*";
            // 
            // cvcTextBox
            // 
            this.cvcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvcTextBox.Location = new System.Drawing.Point(311, 170);
            this.cvcTextBox.Name = "cvcTextBox";
            this.cvcTextBox.Size = new System.Drawing.Size(100, 21);
            this.cvcTextBox.TabIndex = 5;
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateLabel.Location = new System.Drawing.Point(57, 152);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(135, 15);
            this.expiryDateLabel.TabIndex = 4;
            this.expiryDateLabel.Text = "Expiry Date*(MM/YYYY)";
            // 
            // expiryDateTextBox
            // 
            this.expiryDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateTextBox.Location = new System.Drawing.Point(60, 170);
            this.expiryDateTextBox.Name = "expiryDateTextBox";
            this.expiryDateTextBox.Size = new System.Drawing.Size(100, 21);
            this.expiryDateTextBox.TabIndex = 3;
            // 
            // cvcLabel
            // 
            this.cvcLabel.AutoSize = true;
            this.cvcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvcLabel.Location = new System.Drawing.Point(325, 152);
            this.cvcLabel.Name = "cvcLabel";
            this.cvcLabel.Size = new System.Drawing.Size(35, 15);
            this.cvcLabel.TabIndex = 2;
            this.cvcLabel.Text = "CVC*";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(56, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 21);
            this.textBox1.TabIndex = 1;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberLabel.Location = new System.Drawing.Point(53, 93);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(160, 15);
            this.cardNumberLabel.TabIndex = 0;
            this.cardNumberLabel.Text = "Card Number*(20 numbers)";
            this.cardNumberLabel.Click += new System.EventHandler(this.cardNumberLabel_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(12, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(277, 29);
            this.logoLabel.TabIndex = 2;
            this.logoLabel.Text = "PhumlaKamnandi Hotels";
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(652, 377);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(89, 31);
            this.paymentButton.TabIndex = 3;
            this.paymentButton.Text = "DONE";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(598, 152);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(124, 20);
            this.totalCostTextBox.TabIndex = 4;
            this.totalCostTextBox.TextChanged += new System.EventHandler(this.totalCostTextBox_TextChanged);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(594, 125);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(128, 24);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "Total cost due";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.creditCardGroupBox);
            this.Controls.Add(this.paymentDetailsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.creditCardGroupBox.ResumeLayout(false);
            this.creditCardGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paymentDetailsLabel;
        private System.Windows.Forms.GroupBox creditCardGroupBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label cardHolderLabel;
        private System.Windows.Forms.TextBox cvcTextBox;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.TextBox expiryDateTextBox;
        private System.Windows.Forms.Label cvcLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Button paymentButton;
        public System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label totalCostLabel;
    }
}