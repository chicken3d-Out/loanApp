using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loan_Management_App
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            //display overview first
            lblSection.Text = "Statistics";
            sidePanel.Top = btnStatistics.Top;
            sidePanel.Height = btnStatistics.Height;
            statistics1.BringToFront();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //display overview first
            lblSection.Text = "Statistics";
            sidePanel.Top = btnStatistics.Top;
            sidePanel.Height = btnStatistics.Height;
            statistics1.BringToFront();
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            //display overview first
            lblSection.Text = "Borrower";
            sidePanel.Top = btnBorrower.Top;
            sidePanel.Height = btnBorrower.Height;
            borrower1.BringToFront();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            //display overview first
            lblSection.Text = "Loans";
            sidePanel.Top = btnLoans.Top;
            sidePanel.Height = btnLoans.Height;
            loans1.BringToFront();
        }

        private void btnPayback_Click(object sender, EventArgs e)
        {
            //display overview first
            lblSection.Text = "Pay Back";
            sidePanel.Top = btnPayback.Top;
            sidePanel.Height = btnPayback.Height;
            payback1.BringToFront();
        }

        private void btnPayLogs_Click(object sender, EventArgs e)
        {
            //display overview first
            lblSection.Text = "Pay Back Logs";
            sidePanel.Top = btnPayLogs.Top;
            sidePanel.Height = btnPayLogs.Height;
            paylogs1.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Exit?", "Close the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Sign Out?", "Close the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
