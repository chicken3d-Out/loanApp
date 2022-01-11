
namespace Loan_Management_App
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnPayLogs = new FontAwesome.Sharp.IconButton();
            this.btnPayback = new FontAwesome.Sharp.IconButton();
            this.btnLoans = new FontAwesome.Sharp.IconButton();
            this.btnBorrower = new FontAwesome.Sharp.IconButton();
            this.btnStatistics = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.statistics1 = new Loan_Management_App.statistics();
            this.paylogs1 = new Loan_Management_App.paylogs();
            this.payback1 = new Loan_Management_App.payback();
            this.loans1 = new Loan_Management_App.loans();
            this.borrower1 = new Loan_Management_App.borrower();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btnPayLogs);
            this.panel1.Controls.Add(this.btnPayback);
            this.panel1.Controls.Add(this.btnLoans);
            this.panel1.Controls.Add(this.btnBorrower);
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 790);
            this.panel1.TabIndex = 2;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkGreen;
            this.sidePanel.Location = new System.Drawing.Point(0, 203);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(21, 75);
            this.sidePanel.TabIndex = 4;
            // 
            // btnPayLogs
            // 
            this.btnPayLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayLogs.FlatAppearance.BorderSize = 0;
            this.btnPayLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnPayLogs.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnPayLogs.IconColor = System.Drawing.Color.Black;
            this.btnPayLogs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayLogs.IconSize = 45;
            this.btnPayLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayLogs.Location = new System.Drawing.Point(0, 503);
            this.btnPayLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayLogs.Name = "btnPayLogs";
            this.btnPayLogs.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPayLogs.Size = new System.Drawing.Size(348, 75);
            this.btnPayLogs.TabIndex = 6;
            this.btnPayLogs.Text = "Pay Back Logs";
            this.btnPayLogs.UseVisualStyleBackColor = true;
            this.btnPayLogs.Click += new System.EventHandler(this.btnPayLogs_Click);
            // 
            // btnPayback
            // 
            this.btnPayback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayback.FlatAppearance.BorderSize = 0;
            this.btnPayback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayback.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnPayback.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnPayback.IconColor = System.Drawing.Color.Black;
            this.btnPayback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayback.IconSize = 45;
            this.btnPayback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayback.Location = new System.Drawing.Point(0, 428);
            this.btnPayback.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayback.Name = "btnPayback";
            this.btnPayback.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPayback.Size = new System.Drawing.Size(348, 75);
            this.btnPayback.TabIndex = 5;
            this.btnPayback.Text = "Pay Back";
            this.btnPayback.UseVisualStyleBackColor = true;
            this.btnPayback.Click += new System.EventHandler(this.btnPayback_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoans.FlatAppearance.BorderSize = 0;
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoans.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnLoans.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnLoans.IconColor = System.Drawing.Color.Black;
            this.btnLoans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoans.IconSize = 45;
            this.btnLoans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoans.Location = new System.Drawing.Point(0, 353);
            this.btnLoans.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLoans.Size = new System.Drawing.Size(348, 75);
            this.btnLoans.TabIndex = 4;
            this.btnLoans.Text = "Loans";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnBorrower
            // 
            this.btnBorrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrower.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrower.FlatAppearance.BorderSize = 0;
            this.btnBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrower.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnBorrower.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnBorrower.IconColor = System.Drawing.Color.Black;
            this.btnBorrower.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrower.IconSize = 45;
            this.btnBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrower.Location = new System.Drawing.Point(0, 278);
            this.btnBorrower.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrower.Name = "btnBorrower";
            this.btnBorrower.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBorrower.Size = new System.Drawing.Size(348, 75);
            this.btnBorrower.TabIndex = 3;
            this.btnBorrower.Text = "Borrower";
            this.btnBorrower.UseVisualStyleBackColor = true;
            this.btnBorrower.Click += new System.EventHandler(this.btnBorrower_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnStatistics.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnStatistics.IconColor = System.Drawing.Color.Black;
            this.btnStatistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistics.IconSize = 45;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 203);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(348, 75);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 203);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(142, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 41);
            this.label8.TabIndex = 4;
            this.label8.Text = "App";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(142, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 41);
            this.label7.TabIndex = 4;
            this.label7.Text = "Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(142, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loan";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.lblSection);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 54);
            this.panel4.TabIndex = 3;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSection.Location = new System.Drawing.Point(12, 9);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(89, 38);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "label1";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.University;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 94;
            this.iconPictureBox1.Location = new System.Drawing.Point(40, 83);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(94, 96);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.btn_Exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(348, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 54);
            this.panel3.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(964, 9);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(45, 36);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Exit.IconColor = System.Drawing.Color.Black;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 35;
            this.btn_Exit.Location = new System.Drawing.Point(1051, 9);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(45, 36);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel6.Controls.Add(this.lblDate);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.iconPictureBox3);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(477, 97);
            this.panel6.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(11, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(127, 46);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(146, 413);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "User Friendly";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 77;
            this.iconPictureBox3.Location = new System.Drawing.Point(383, 16);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(85, 77);
            this.iconPictureBox3.TabIndex = 2;
            this.iconPictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(105, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Improved Data Security";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(10, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Updates Changes In Database At Reel-Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(86, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Keeps Track Of Your Stock ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beverages Inventory System";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(348, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1030, 97);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(495, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 98);
            this.panel7.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(610, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(204, 49);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label10";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 78;
            this.iconPictureBox2.Location = new System.Drawing.Point(918, 16);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(91, 78);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // statistics1
            // 
            this.statistics1.Location = new System.Drawing.Point(348, 148);
            this.statistics1.Name = "statistics1";
            this.statistics1.Size = new System.Drawing.Size(1009, 612);
            this.statistics1.TabIndex = 9;
            // 
            // paylogs1
            // 
            this.paylogs1.Location = new System.Drawing.Point(348, 148);
            this.paylogs1.Name = "paylogs1";
            this.paylogs1.Size = new System.Drawing.Size(1009, 612);
            this.paylogs1.TabIndex = 8;
            // 
            // payback1
            // 
            this.payback1.Location = new System.Drawing.Point(348, 148);
            this.payback1.Name = "payback1";
            this.payback1.Size = new System.Drawing.Size(1009, 612);
            this.payback1.TabIndex = 7;
            // 
            // loans1
            // 
            this.loans1.Location = new System.Drawing.Point(348, 148);
            this.loans1.Name = "loans1";
            this.loans1.Size = new System.Drawing.Size(1009, 612);
            this.loans1.TabIndex = 6;
            // 
            // borrower1
            // 
            this.borrower1.Location = new System.Drawing.Point(348, 148);
            this.borrower1.Name = "borrower1";
            this.borrower1.Size = new System.Drawing.Size(1009, 612);
            this.borrower1.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1378, 790);
            this.Controls.Add(this.statistics1);
            this.Controls.Add(this.paylogs1);
            this.Controls.Add(this.payback1);
            this.Controls.Add(this.loans1);
            this.Controls.Add(this.borrower1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private FontAwesome.Sharp.IconButton btnPayLogs;
        private FontAwesome.Sharp.IconButton btnPayback;
        private FontAwesome.Sharp.IconButton btnLoans;
        private FontAwesome.Sharp.IconButton btnBorrower;
        private FontAwesome.Sharp.IconButton btnStatistics;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSection;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTime;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private borrower borrower1;
        private loans loans1;
        private payback payback1;
        private paylogs paylogs1;
        private statistics statistics1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}