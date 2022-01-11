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
                string noOfCustomers = "SELECT sum(payment) as 'dailyPayment' from paylogs where dateOfPayment = CURDATE();";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblDailyPayment.Text = dr.GetInt32("dailyPayment").ToString();
                }
            }
            catch
            {
                MessageBox.Show("Query Not Executable!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
