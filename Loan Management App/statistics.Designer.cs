
namespace Loan_Management_App
{
    partial class statistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPayment1 = new Loan_Management_App.totalPayment();
            this.totalBorrowed1 = new Loan_Management_App.totalBorrowed();
            this.dailyPayment1 = new Loan_Management_App.dailyPayment();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWeeklyPayment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblYearlyPayment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPastDue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 50);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(24, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Statistics Section";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 87;
            this.iconPictureBox1.Location = new System.Drawing.Point(408, 30);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(87, 87);
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.lblCustomers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(61, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 117);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.lblCustomers.ForeColor = System.Drawing.Color.Black;
            this.lblCustomers.Location = new System.Drawing.Point(25, 41);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(73, 76);
            this.lblCustomers.TabIndex = 19;
            this.lblCustomers.Text = "0";
            this.lblCustomers.Click += new System.EventHandler(this.lblCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Customers";
            // 
            // totalPayment1
            // 
            this.totalPayment1.Location = new System.Drawing.Point(605, 476);
            this.totalPayment1.Name = "totalPayment1";
            this.totalPayment1.Size = new System.Drawing.Size(495, 117);
            this.totalPayment1.TabIndex = 25;
            // 
            // totalBorrowed1
            // 
            this.totalBorrowed1.Location = new System.Drawing.Point(605, 61);
            this.totalBorrowed1.Name = "totalBorrowed1";
            this.totalBorrowed1.Size = new System.Drawing.Size(495, 117);
            this.totalBorrowed1.TabIndex = 24;
            // 
            // dailyPayment1
            // 
            this.dailyPayment1.Location = new System.Drawing.Point(61, 198);
            this.dailyPayment1.Name = "dailyPayment1";
            this.dailyPayment1.Size = new System.Drawing.Size(495, 117);
            this.dailyPayment1.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.panel3.Controls.Add(this.lblWeeklyPayment);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Location = new System.Drawing.Point(61, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 117);
            this.panel3.TabIndex = 18;
            // 
            // lblWeeklyPayment
            // 
            this.lblWeeklyPayment.AutoSize = true;
            this.lblWeeklyPayment.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.lblWeeklyPayment.ForeColor = System.Drawing.Color.Black;
            this.lblWeeklyPayment.Location = new System.Drawing.Point(25, 37);
            this.lblWeeklyPayment.Name = "lblWeeklyPayment";
            this.lblWeeklyPayment.Size = new System.Drawing.Size(73, 76);
            this.lblWeeklyPayment.TabIndex = 19;
            this.lblWeeklyPayment.Text = "0";
            this.lblWeeklyPayment.Click += new System.EventHandler(this.lblCustomers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Weekly Payment";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 87;
            this.iconPictureBox2.Location = new System.Drawing.Point(405, 27);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(87, 87);
            this.iconPictureBox2.TabIndex = 17;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.lblMonthlyPayment);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Location = new System.Drawing.Point(605, 337);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 117);
            this.panel4.TabIndex = 18;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyPayment.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(30, 41);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(73, 76);
            this.lblMonthlyPayment.TabIndex = 19;
            this.lblMonthlyPayment.Text = "0";
            this.lblMonthlyPayment.Click += new System.EventHandler(this.lblCustomers_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "Monthly Payment";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(52)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 87;
            this.iconPictureBox3.Location = new System.Drawing.Point(405, 30);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(87, 87);
            this.iconPictureBox3.TabIndex = 17;
            this.iconPictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.lblYearlyPayment);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.iconPictureBox4);
            this.panel5.Location = new System.Drawing.Point(61, 476);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(495, 117);
            this.panel5.TabIndex = 18;
            // 
            // lblYearlyPayment
            // 
            this.lblYearlyPayment.AutoSize = true;
            this.lblYearlyPayment.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.lblYearlyPayment.ForeColor = System.Drawing.Color.Black;
            this.lblYearlyPayment.Location = new System.Drawing.Point(25, 41);
            this.lblYearlyPayment.Name = "lblYearlyPayment";
            this.lblYearlyPayment.Size = new System.Drawing.Size(73, 76);
            this.lblYearlyPayment.TabIndex = 19;
            this.lblYearlyPayment.Text = "0";
            this.lblYearlyPayment.Click += new System.EventHandler(this.lblCustomers_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 37);
            this.label8.TabIndex = 19;
            this.label8.Text = "Yearly Payment";
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.LightGreen;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 87;
            this.iconPictureBox4.Location = new System.Drawing.Point(405, 30);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(87, 87);
            this.iconPictureBox4.TabIndex = 17;
            this.iconPictureBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(52)))), ((int)(((byte)(235)))));
            this.panel6.Controls.Add(this.lblPastDue);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.iconPictureBox5);
            this.panel6.Location = new System.Drawing.Point(605, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(495, 117);
            this.panel6.TabIndex = 18;
            // 
            // lblPastDue
            // 
            this.lblPastDue.AutoSize = true;
            this.lblPastDue.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.lblPastDue.ForeColor = System.Drawing.Color.Black;
            this.lblPastDue.Location = new System.Drawing.Point(30, 41);
            this.lblPastDue.Name = "lblPastDue";
            this.lblPastDue.Size = new System.Drawing.Size(73, 76);
            this.lblPastDue.TabIndex = 19;
            this.lblPastDue.Text = "0";
            this.lblPastDue.Click += new System.EventHandler(this.lblCustomers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "Past Due Balance";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(52)))), ((int)(((byte)(235)))));
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 87;
            this.iconPictureBox5.Location = new System.Drawing.Point(405, 33);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(87, 87);
            this.iconPictureBox5.TabIndex = 17;
            this.iconPictureBox5.TabStop = false;
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.totalPayment1);
            this.Controls.Add(this.totalBorrowed1);
            this.Controls.Add(this.dailyPayment1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "statistics";
            this.Size = new System.Drawing.Size(1152, 612);
            this.Load += new System.EventHandler(this.statistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomers;
        private dailyPayment dailyPayment1;
        private totalBorrowed totalBorrowed1;
        private totalPayment totalPayment1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWeeklyPayment;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblYearlyPayment;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPastDue;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}
