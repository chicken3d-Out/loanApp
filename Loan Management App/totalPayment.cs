﻿using System;
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
    public partial class totalPayment : UserControl
    {
        public totalPayment()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void totalPayment_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(SUM(totalPayment), 0) as 'totalPayment' from loans;";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblTotalPayment.Text = dr.GetInt32("totalPayment").ToString();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please Open the XAMPP Connection First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void lblTotalPayment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Get Number of Customers
                string noOfCustomers = "SELECT IFNULL(SUM(totalPayment), 0) as 'totalPayment' from loans;";
                cmd = new MySqlCommand(noOfCustomers, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblTotalPayment.Text = dr.GetInt32("totalPayment").ToString();
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
