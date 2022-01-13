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
    public partial class dailyPayment : UserControl
    {
        public dailyPayment()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=lendingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void dailyPayment_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(SUM(payment), 0) as 'dailyPayment' from payLogs where dateOfPayment = CURDATE();";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblDailyPayment.Text = dr.GetInt32("dailyPayment").ToString();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Daily Payment Error!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void lblDailyPayment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(SUM(payment), 0) as 'dailyPayment' from payLogs where dateOfPayment = CURDATE();";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblDailyPayment.Text = dr.GetInt32("dailyPayment").ToString();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Daily Payment Error!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }
    }
}
