
namespace Loan_Management_App
{
    partial class AddBorrower
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
            this.lblUpperLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFIrstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtMunicipality = new System.Windows.Forms.TextBox();
            this.txtBarangay = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEditMode = new System.Windows.Forms.Label();
            this.borrowerID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lblUpperLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 50);
            this.panel1.TabIndex = 16;
            // 
            // lblUpperLabel
            // 
            this.lblUpperLabel.AutoSize = true;
            this.lblUpperLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUpperLabel.Location = new System.Drawing.Point(24, 4);
            this.lblUpperLabel.Name = "lblUpperLabel";
            this.lblUpperLabel.Size = new System.Drawing.Size(244, 38);
            this.lblUpperLabel.TabIndex = 0;
            this.lblUpperLabel.Text = "Register Borrower";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.txtOccupation);
            this.panel2.Controls.Add(this.txtPhoneNo);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtMiddlename);
            this.panel2.Controls.Add(this.txtLastname);
            this.panel2.Controls.Add(this.txtFIrstname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 423);
            this.panel2.TabIndex = 17;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txtGender.Location = new System.Drawing.Point(233, 245);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(169, 36);
            this.txtGender.TabIndex = 5;
            this.txtGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGender_KeyPress);
            // 
            // txtOccupation
            // 
            this.txtOccupation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOccupation.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtOccupation.Location = new System.Drawing.Point(233, 365);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(169, 36);
            this.txtOccupation.TabIndex = 7;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtPhoneNo.Location = new System.Drawing.Point(233, 306);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(169, 36);
            this.txtPhoneNo.TabIndex = 6;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtAge.Location = new System.Drawing.Point(233, 187);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(169, 36);
            this.txtAge.TabIndex = 4;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddlename.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtMiddlename.Location = new System.Drawing.Point(233, 134);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(169, 36);
            this.txtMiddlename.TabIndex = 3;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtLastname.Location = new System.Drawing.Point(233, 81);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(169, 36);
            this.txtLastname.TabIndex = 2;
            // 
            // txtFIrstname
            // 
            this.txtFIrstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtFIrstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFIrstname.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtFIrstname.Location = new System.Drawing.Point(233, 22);
            this.txtFIrstname.Name = "txtFIrstname";
            this.txtFIrstname.Size = new System.Drawing.Size(169, 36);
            this.txtFIrstname.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(64, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Occupation :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(64, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(92, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(126, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(52, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Middlename :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(64, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lastname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(64, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtZipCode);
            this.panel3.Controls.Add(this.txtProvince);
            this.panel3.Controls.Add(this.txtMunicipality);
            this.panel3.Controls.Add(this.txtBarangay);
            this.panel3.Controls.Add(this.txtStreet);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(516, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 423);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipCode.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtZipCode.Location = new System.Drawing.Point(231, 348);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(169, 36);
            this.txtZipCode.TabIndex = 12;
            this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
            // 
            // txtProvince
            // 
            this.txtProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvince.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtProvince.Location = new System.Drawing.Point(231, 283);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(169, 36);
            this.txtProvince.TabIndex = 11;
            // 
            // txtMunicipality
            // 
            this.txtMunicipality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtMunicipality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMunicipality.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtMunicipality.Location = new System.Drawing.Point(231, 221);
            this.txtMunicipality.Name = "txtMunicipality";
            this.txtMunicipality.Size = new System.Drawing.Size(169, 36);
            this.txtMunicipality.TabIndex = 10;
            // 
            // txtBarangay
            // 
            this.txtBarangay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtBarangay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarangay.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtBarangay.Location = new System.Drawing.Point(231, 160);
            this.txtBarangay.Name = "txtBarangay";
            this.txtBarangay.Size = new System.Drawing.Size(169, 36);
            this.txtBarangay.TabIndex = 9;
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtStreet.Location = new System.Drawing.Point(231, 96);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(169, 36);
            this.txtStreet.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(73, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zip Code :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(77, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Province :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(37, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Municipality :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(67, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 32);
            this.label11.TabIndex = 17;
            this.label11.Text = "Barangay :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(105, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "Street :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(157, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 32);
            this.label13.TabIndex = 19;
            this.label13.Text = "Current Address";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRegister.Location = new System.Drawing.Point(720, 507);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(105, 40);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Reg/Save";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.Location = new System.Drawing.Point(873, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 40);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button1.Location = new System.Drawing.Point(31, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Location = new System.Drawing.Point(477, 521);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(29, 17);
            this.lblEditMode.TabIndex = 22;
            this.lblEditMode.Text = "T/F";
            this.lblEditMode.Visible = false;
            // 
            // borrowerID
            // 
            this.borrowerID.AutoSize = true;
            this.borrowerID.Location = new System.Drawing.Point(297, 521);
            this.borrowerID.Name = "borrowerID";
            this.borrowerID.Size = new System.Drawing.Size(78, 17);
            this.borrowerID.TabIndex = 23;
            this.borrowerID.Text = "BorrowerID";
            this.borrowerID.Visible = false;
            // 
            // AddBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1010, 578);
            this.Controls.Add(this.borrowerID);
            this.Controls.Add(this.lblEditMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBorrower";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtFIrstname;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.Label lblEditMode;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label borrowerID;
        public System.Windows.Forms.TextBox txtOccupation;
        public System.Windows.Forms.TextBox txtPhoneNo;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.TextBox txtLastname;
        public System.Windows.Forms.TextBox txtZipCode;
        public System.Windows.Forms.TextBox txtProvince;
        public System.Windows.Forms.TextBox txtMunicipality;
        public System.Windows.Forms.TextBox txtBarangay;
        public System.Windows.Forms.TextBox txtStreet;
        public System.Windows.Forms.TextBox txtMiddlename;
        public System.Windows.Forms.ComboBox txtGender;
        public System.Windows.Forms.Label lblUpperLabel;
    }
}