
namespace Loan_Management_App
{
    partial class ViewLoans
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpperPortion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDaysRemaining = new System.Windows.Forms.Label();
            this.lblDailyPayment = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDateBorrowed = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(104, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Balance :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(33, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 32);
            this.label11.TabIndex = 17;
            this.label11.Text = "Daily Payment :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(51, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "Interest Rate :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.Location = new System.Drawing.Point(873, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 40);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblInterestRate);
            this.panel3.Controls.Add(this.lblDueDate);
            this.panel3.Controls.Add(this.lblDateBorrowed);
            this.panel3.Controls.Add(this.lblBalance);
            this.panel3.Controls.Add(this.lblDailyPayment);
            this.panel3.Location = new System.Drawing.Point(516, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 391);
            this.panel3.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(86, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Due Date :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblDuration);
            this.panel2.Controls.Add(this.lblDaysRemaining);
            this.panel2.Controls.Add(this.lblLoanAmount);
            this.panel2.Controls.Add(this.lblMiddlename);
            this.panel2.Controls.Add(this.lblLastname);
            this.panel2.Controls.Add(this.lblFirstname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 391);
            this.panel2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(94, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Middlename :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(82, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loan Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(114, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(123, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname :";
            // 
            // lblUpperPortion
            // 
            this.lblUpperPortion.AutoSize = true;
            this.lblUpperPortion.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperPortion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUpperPortion.Location = new System.Drawing.Point(24, 4);
            this.lblUpperPortion.Name = "lblUpperPortion";
            this.lblUpperPortion.Size = new System.Drawing.Size(173, 38);
            this.lblUpperPortion.TabIndex = 0;
            this.lblUpperPortion.Text = "Loan Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lblUpperPortion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 50);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duration in Days :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(56, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Days Remaining :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(24, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date Borrowed :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.BackColor = System.Drawing.Color.White;
            this.lblFirstname.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFirstname.Location = new System.Drawing.Point(289, 27);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(26, 27);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "-";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.White;
            this.lblLastname.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLastname.Location = new System.Drawing.Point(289, 83);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(26, 27);
            this.lblLastname.TabIndex = 0;
            this.lblLastname.Text = "-";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.BackColor = System.Drawing.Color.White;
            this.lblMiddlename.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMiddlename.Location = new System.Drawing.Point(289, 139);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(26, 27);
            this.lblMiddlename.TabIndex = 0;
            this.lblMiddlename.Text = "-";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.BackColor = System.Drawing.Color.White;
            this.lblLoanAmount.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLoanAmount.Location = new System.Drawing.Point(289, 197);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(26, 27);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "-";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDuration.Location = new System.Drawing.Point(289, 255);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(26, 27);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "-";
            // 
            // lblDaysRemaining
            // 
            this.lblDaysRemaining.AutoSize = true;
            this.lblDaysRemaining.BackColor = System.Drawing.Color.White;
            this.lblDaysRemaining.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRemaining.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDaysRemaining.Location = new System.Drawing.Point(289, 313);
            this.lblDaysRemaining.Name = "lblDaysRemaining";
            this.lblDaysRemaining.Size = new System.Drawing.Size(26, 27);
            this.lblDaysRemaining.TabIndex = 0;
            this.lblDaysRemaining.Text = "-";
            // 
            // lblDailyPayment
            // 
            this.lblDailyPayment.AutoSize = true;
            this.lblDailyPayment.BackColor = System.Drawing.Color.White;
            this.lblDailyPayment.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyPayment.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDailyPayment.Location = new System.Drawing.Point(249, 97);
            this.lblDailyPayment.Name = "lblDailyPayment";
            this.lblDailyPayment.Size = new System.Drawing.Size(26, 27);
            this.lblDailyPayment.TabIndex = 0;
            this.lblDailyPayment.Text = "-";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.BackColor = System.Drawing.Color.White;
            this.lblInterestRate.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInterestRate.Location = new System.Drawing.Point(249, 27);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(26, 27);
            this.lblInterestRate.TabIndex = 0;
            this.lblInterestRate.Text = "-";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBalance.Location = new System.Drawing.Point(249, 172);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(26, 27);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "-";
            // 
            // lblDateBorrowed
            // 
            this.lblDateBorrowed.AutoSize = true;
            this.lblDateBorrowed.BackColor = System.Drawing.Color.White;
            this.lblDateBorrowed.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBorrowed.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDateBorrowed.Location = new System.Drawing.Point(249, 240);
            this.lblDateBorrowed.Name = "lblDateBorrowed";
            this.lblDateBorrowed.Size = new System.Drawing.Size(26, 27);
            this.lblDateBorrowed.TabIndex = 0;
            this.lblDateBorrowed.Text = "-";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.White;
            this.lblDueDate.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDueDate.Location = new System.Drawing.Point(249, 313);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(26, 27);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.Text = "-";
            // 
            // ViewLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1010, 539);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLoans";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblUpperPortion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblInterestRate;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblDateBorrowed;
        public System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.Label lblDailyPayment;
        public System.Windows.Forms.Label lblDuration;
        public System.Windows.Forms.Label lblDaysRemaining;
        public System.Windows.Forms.Label lblLoanAmount;
        public System.Windows.Forms.Label lblMiddlename;
        public System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.Label lblFirstname;
    }
}