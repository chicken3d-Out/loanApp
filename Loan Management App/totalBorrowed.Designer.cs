
namespace Loan_Management_App
{
    partial class totalBorrowed
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBorrowed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.panel3.Controls.Add(this.lblTotalBorrowed);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 167);
            this.panel3.TabIndex = 23;
            // 
            // lblTotalBorrowed
            // 
            this.lblTotalBorrowed.AutoSize = true;
            this.lblTotalBorrowed.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBorrowed.Location = new System.Drawing.Point(23, 45);
            this.lblTotalBorrowed.Name = "lblTotalBorrowed";
            this.lblTotalBorrowed.Size = new System.Drawing.Size(86, 90);
            this.lblTotalBorrowed.TabIndex = 19;
            this.lblTotalBorrowed.Text = "0";
            this.lblTotalBorrowed.Click += new System.EventHandler(this.lblTotalBorrowed_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Borrowed";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 87;
            this.iconPictureBox2.Location = new System.Drawing.Point(342, 45);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(107, 87);
            this.iconPictureBox2.TabIndex = 17;
            this.iconPictureBox2.TabStop = false;
            // 
            // totalBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "totalBorrowed";
            this.Size = new System.Drawing.Size(449, 167);
            this.Load += new System.EventHandler(this.totalBorrowed_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBorrowed;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
