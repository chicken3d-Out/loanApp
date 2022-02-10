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
    public partial class statistics : UserControl
    {
        public statistics()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void statistics_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(COUNT(*), 0) as 'NoOfCustomers' from borrower;";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblCustomers.Text = dr.GetInt32("NoOfCustomers").ToString();
                }

                //Get Number of Past Due
                dr.Close();
                string pastDueBalance = "SELECT IFNULL(SUM(balance), 0) as 'pastDueBalance' from loans where duedate < CURDATE();";
                cmd = new MySqlCommand(pastDueBalance, con);
                MySqlDataReader pd = cmd.ExecuteReader();
                if (pd.Read() == true)
                {
                    lblPastDue.Text = pd.GetInt32("pastDueBalance").ToString();
                }

                //Get WeeklyPayment
                pd.Close();
                string weeklyPayment = "SELECT IFNULL(SUM(payment), 0) as 'weeklyPayment' from payLogs where YEARWEEK(dateOfPayment) = YEARWEEK(NOW());";
                cmd = new MySqlCommand(weeklyPayment, con);
                MySqlDataReader wp = cmd.ExecuteReader();
                if (wp.Read() == true)
                {
                    lblWeeklyPayment.Text = wp.GetInt32("weeklyPayment").ToString();
                }

                //Get Monthly Payment
                wp.Close();
                string monthlyPayment = "SELECT IFNULL(SUM(payment), 0) as 'monthlyPayment' from payLogs where MONTH(dateOfPayment) = MONTH(CURDATE());";
                cmd = new MySqlCommand(monthlyPayment, con);
                MySqlDataReader mp = cmd.ExecuteReader();
                if (mp.Read() == true)
                {
                    lblMonthlyPayment.Text = mp.GetInt32("monthlyPayment").ToString();
                }

                //Get Monthly Payment
                mp.Close();
                string yearlyPayment = "SELECT IFNULL(SUM(payment), 0) as 'yearlyPayment' from payLogs where YEAR(dateOfPayment) = YEAR(CURDATE());";
                cmd = new MySqlCommand(yearlyPayment, con);
                MySqlDataReader yp = cmd.ExecuteReader();
                if (yp.Read() == true)
                {
                    lblYearlyPayment.Text = yp.GetInt32("yearlyPayment").ToString();
                }
                yp.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please Open the XAMPP Connection First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(COUNT(*), 0) as 'NoOfCustomers' from borrower;";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblCustomers.Text = dr.GetInt32("NoOfCustomers").ToString();
                }

                //Get Number of Past Due
                dr.Close();
                string pastDueBalance = "SELECT IFNULL(SUM(balance), 0) as 'pastDueBalance' from loans where duedate < CURDATE();";
                cmd = new MySqlCommand(pastDueBalance, con);
                MySqlDataReader pd = cmd.ExecuteReader();
                if (pd.Read() == true)
                {
                    lblPastDue.Text = pd.GetInt32("pastDueBalance").ToString();
                }

                //Get WeeklyPayment
                pd.Close();
                string weeklyPayment = "SELECT IFNULL(SUM(payment), 0) as 'weeklyPayment' from payLogs where YEARWEEK(dateOfPayment,1) = YEARWEEK(NOW());";
                cmd = new MySqlCommand(weeklyPayment, con);
                MySqlDataReader wp = cmd.ExecuteReader();
                if (wp.Read() == true)
                {
                    lblWeeklyPayment.Text = wp.GetInt32("weeklyPayment").ToString();
                }

                //Get Monthly Payment
                wp.Close();
                string monthlyPayment = "SELECT IFNULL(SUM(payment), 0) as 'monthlyPayment' from payLogs where MONTH(dateOfPayment) = MONTH(CURDATE());";
                cmd = new MySqlCommand(monthlyPayment, con);
                MySqlDataReader mp = cmd.ExecuteReader();
                if (mp.Read() == true)
                {
                    lblMonthlyPayment.Text = mp.GetInt32("monthlyPayment").ToString();
                }

                //Get Monthly Payment
                mp.Close();
                string yearlyPayment = "SELECT IFNULL(SUM(payment), 0) as 'yearlyPayment' from payLogs where YEAR(dateOfPayment) = YEAR(CURDATE());";
                cmd = new MySqlCommand(yearlyPayment, con);
                MySqlDataReader yp = cmd.ExecuteReader();
                if (yp.Read() == true)
                {
                    lblYearlyPayment.Text = yp.GetInt32("yearlyPayment").ToString();
                }
                yp.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please Open the XAMPP Connection First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
