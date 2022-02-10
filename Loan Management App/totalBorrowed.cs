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
    public partial class totalBorrowed : UserControl
    {
        public totalBorrowed()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void totalBorrowed_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(SUM(amount), 0) as 'totalBorrowed' from loans;";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblTotalBorrowed.Text = dr.GetInt32("totalBorrowed").ToString();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please Open the XAMPP Connection First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void lblTotalBorrowed_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(SUM(amount), 0) as 'totalBorrowed' from loans;";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblTotalBorrowed.Text = dr.GetInt32("totalBorrowed").ToString();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please Open the XAMPP Connection First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }
    }
}
