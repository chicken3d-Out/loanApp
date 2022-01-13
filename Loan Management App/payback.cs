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
    public partial class payback : UserControl
    {
        public payback()
        {
            InitializeComponent();
        }
        //Variable needed for update
        int currentBalance;
        int currentRemainingDays;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=lendingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDailyPayment_Click(object sender, EventArgs e)
        {
            try
            {
                //NOTE THAT TXTBORROWERID IS ACTUALLY LOANID//   I DIDN'T CHANGE IT BECAUSE IT WILL CAUSE SOME ERROR IN VISUAL STUDIO
                if (txtBorrowerID.Text == "")
                {
                    MessageBox.Show("Don't Leave the BorrowerID Fields Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string checkLoanExist = "SELECT loanID from loans where loanID = "+ txtBorrowerID.Text +";";
                    cmd = new MySqlCommand(checkLoanExist, con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        string add = "SELECT dailyPayment,daysRemaining, balance from loans where loanID = " + txtBorrowerID.Text + ";";
                        cmd = new MySqlCommand(add, con);
                        MySqlDataReader dp = cmd.ExecuteReader();
                        if (dp.Read())
                        {
                            txtAmount.Text = dp.GetInt32("dailyPayment").ToString();
                            this.currentBalance = dp.GetInt32("balance");
                            this.currentRemainingDays = dp.GetInt32("daysRemaining");
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Loan Dont Exist", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBorrowerID.Text = "";
                        txtAmount.Text = "";
                        con.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Pay Back Error", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBorrowerID.Text = "";
            txtAmount.Text = "";
            lblRemainingBalance.Text = "0";
            lblRemainingDays.Text = "0";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if(txtBorrowerID.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Dont Leave the Input Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string checkBorrowerExist = "SELECT loanID from loans where loanID = " + txtBorrowerID.Text + ";";
                cmd = new MySqlCommand(checkBorrowerExist, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    string updateLoansDetails = "UPDATE loans SET daysRemaining= " + (currentRemainingDays - 1) + ", balance = " + (currentBalance - Convert.ToInt32(txtAmount.Text)) + " where loanID = " + txtBorrowerID.Text + ";";
                    cmd = new MySqlCommand(updateLoansDetails, con);
                    int success = cmd.ExecuteNonQuery();

                    if (success > 0)
                    {
                        MessageBox.Show("Payment Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string getUpdatedData = "SELECT daysRemaining, balance from loans where loanID = " + txtBorrowerID.Text + ";";
                        cmd = new MySqlCommand(getUpdatedData, con);
                        MySqlDataReader dp = cmd.ExecuteReader();
                        if (dp.Read())
                        {
                            lblRemainingBalance.Text = dp.GetInt32("balance").ToString();
                            lblRemainingDays.Text = dp.GetInt32("daysRemaining").ToString();
                            txtBorrowerID.Text = "";
                            txtAmount.Text = "";
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Payment Failed!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }else
                {
                    MessageBox.Show("Loan Dont Exist!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                
            }   
        }

        private void payback_Load(object sender, EventArgs e)
        {

        }

        private void txtBorrowerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
