
namespace Loan_Management_App
{
    partial class Apply_Loan
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblDailyPayment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDuationinDays = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new FontAwesome.Sharp.IconPictureBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtAmountLoan = new System.Windows.Forms.TextBox();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpperPortion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEditMode = new System.Windows.Forms.Label();
            this.borrowerID = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnClear.Location = new System.Drawing.Point(31, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 40);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnApply.Location = new System.Drawing.Point(720, 482);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(105, 40);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply/Save";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(51, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Duration in Days :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(52, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 32);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Payment : P";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(51, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "Daily Payment : P";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(157, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 32);
            this.label13.TabIndex = 19;
            this.label13.Text = "Loan Overview";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.Location = new System.Drawing.Point(873, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 40);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblDueDate);
            this.panel3.Controls.Add(this.lblDuration);
            this.panel3.Controls.Add(this.lblTotalPayment);
            this.panel3.Controls.Add(this.lblDailyPayment);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(516, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 391);
            this.panel3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(96, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Due Date :";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDueDate.Location = new System.Drawing.Point(243, 308);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(37, 37);
            this.lblDueDate.TabIndex = 18;
            this.lblDueDate.Text = "0";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDuration.Location = new System.Drawing.Point(272, 239);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(37, 37);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "0";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalPayment.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalPayment.Location = new System.Drawing.Point(272, 169);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(37, 37);
            this.lblTotalPayment.TabIndex = 18;
            this.lblTotalPayment.Text = "0";
            // 
            // lblDailyPayment
            // 
            this.lblDailyPayment.AutoSize = true;
            this.lblDailyPayment.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.lblDailyPayment.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDailyPayment.Location = new System.Drawing.Point(272, 94);
            this.lblDailyPayment.Name = "lblDailyPayment";
            this.lblDailyPayment.Size = new System.Drawing.Size(37, 37);
            this.lblDailyPayment.TabIndex = 18;
            this.lblDailyPayment.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtDuationinDays);
            this.panel2.Controls.Add(this.btnCalculate);
            this.panel2.Controls.Add(this.txtInterestRate);
            this.panel2.Controls.Add(this.txtAmountLoan);
            this.panel2.Controls.Add(this.txtBorrowerID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 391);
            this.panel2.TabIndex = 23;
            // 
            // txtDuationinDays
            // 
            this.txtDuationinDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtDuationinDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDuationinDays.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtDuationinDays.FormattingEnabled = true;
            this.txtDuationinDays.Items.AddRange(new object[] {
            "48",
            "60"});
            this.txtDuationinDays.Location = new System.Drawing.Point(235, 199);
            this.txtDuationinDays.Name = "txtDuationinDays";
            this.txtDuationinDays.Size = new System.Drawing.Size(169, 36);
            this.txtDuationinDays.TabIndex = 3;
            this.txtDuationinDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuationinDays_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.btnCalculate.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalculate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.btnCalculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalculate.IconSize = 53;
            this.btnCalculate.Location = new System.Drawing.Point(338, 336);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(66, 53);
            this.btnCalculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtInterestRate.Location = new System.Drawing.Point(235, 283);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(169, 36);
            this.txtInterestRate.TabIndex = 4;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // txtAmountLoan
            // 
            this.txtAmountLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtAmountLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountLoan.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtAmountLoan.Location = new System.Drawing.Point(235, 120);
            this.txtAmountLoan.Name = "txtAmountLoan";
            this.txtAmountLoan.Size = new System.Drawing.Size(169, 36);
            this.txtAmountLoan.TabIndex = 2;
            this.txtAmountLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountLoan_KeyPress);
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtBorrowerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBorrowerID.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtBorrowerID.Location = new System.Drawing.Point(235, 42);
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(169, 36);
            this.txtBorrowerID.TabIndex = 1;
            this.txtBorrowerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBorrowerID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duration in Days :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(204, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Calculate :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Interest Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount Loan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Borrower ID :";
            // 
            // lblUpperPortion
            // 
            this.lblUpperPortion.AutoSize = true;
            this.lblUpperPortion.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperPortion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUpperPortion.Location = new System.Drawing.Point(24, 4);
            this.lblUpperPortion.Name = "lblUpperPortion";
            this.lblUpperPortion.Size = new System.Drawing.Size(161, 38);
            this.lblUpperPortion.TabIndex = 0;
            this.lblUpperPortion.Text = "Apply Loan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lblUpperPortion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 50);
            this.panel1.TabIndex = 22;
            // 
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Location = new System.Drawing.Point(317, 496);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(67, 17);
            this.lblEditMode.TabIndex = 28;
            this.lblEditMode.Text = "EditMode";
            this.lblEditMode.Visible = false;
            // 
            // borrowerID
            // 
            this.borrowerID.AutoSize = true;
            this.borrowerID.Location = new System.Drawing.Point(426, 496);
            this.borrowerID.Name = "borrowerID";
            this.borrowerID.Size = new System.Drawing.Size(78, 17);
            this.borrowerID.TabIndex = 28;
            this.borrowerID.Text = "BorrowerID";
            this.borrowerID.Visible = false;
            // 
            // Apply_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1010, 539);
            this.Controls.Add(this.borrowerID);
            this.Controls.Add(this.lblEditMode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Apply_Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply_Loan";
            this.Load += new System.EventHandler(this.Apply_Loan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnCalculate;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblDuration;
        public System.Windows.Forms.Label lblTotalPayment;
        public System.Windows.Forms.Label lblDailyPayment;
        public System.Windows.Forms.TextBox txtInterestRate;
        public System.Windows.Forms.TextBox txtAmountLoan;
        public System.Windows.Forms.Label lblEditMode;
        public System.Windows.Forms.Label borrowerID;
        public System.Windows.Forms.Label lblUpperPortion;
        public System.Windows.Forms.ComboBox txtDuationinDays;
    }
}