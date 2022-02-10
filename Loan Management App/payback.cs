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
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingsystem");
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
                        string add = "SELECT dailyPayment,totalPayment, balance from loans where loanID = " + txtBorrowerID.Text + ";";
                        cmd = new MySqlCommand(add, con);
                        MySqlDataReader dp = cmd.ExecuteReader();
                        if (dp.Read())
                        {
                            txtAmount.Text = dp.GetInt32("dailyPayment").ToString();
                            this.currentBalance = dp.GetInt32("balance");
                            lblBalance.Text = dp.GetInt32("balance").ToString();
                            lblTotal.Text = dp.GetInt32("totalPayment").ToString();
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
                MessageBox.Show("Please Open the XAMPP Connection First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBorrowerID.Text = "";
            txtAmount.Text = "";

            lblRemainingBalance.Text = "0";
            lblTotal.Text = "0";
            lblTotalPayment.Text = "0";
            lblBalance.Text = "0";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBorrowerID.Text == "" || txtAmount.Text == "")
                {
                    MessageBox.Show("Dont Leave the Input Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.currentBalance == 0)
                {
                    MessageBox.Show("This Current Loan Has 0 balance!", "This Loan is Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                else if (Convert.ToInt32(txtAmount.Text) >this.currentBalance)
                {
                    MessageBox.Show("The Amount to be Payed is more than the balance!", "Amount is More", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (MessageBox.Show("Click Yes To Confirm Payment", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    string checkBorrowerExist = "SELECT loanID from loans where loanID = " + txtBorrowerID.Text + ";";
                    cmd = new MySqlCommand(checkBorrowerExist, con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        string updateLoansDetails = "UPDATE loans SET currentPayment="+txtAmount.Text+", totalPayment= " + (Convert.ToInt32(lblTotal.Text) + Convert.ToInt32(txtAmount.Text)) + ", balance = " + (currentBalance - Convert.ToInt32(txtAmount.Text)) + " where loanID = " + txtBorrowerID.Text + ";";
                        cmd = new MySqlCommand(updateLoansDetails, con);
                        int success = cmd.ExecuteNonQuery();

                        if (success > 0)
                        {
                            MessageBox.Show("Payment Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string getUpdatedData = "SELECT totalPayment, balance from loans where loanID = " + txtBorrowerID.Text + ";";
                            cmd = new MySqlCommand(getUpdatedData, con);
                            MySqlDataReader dp = cmd.ExecuteReader();
                            if (dp.Read())
                            {
                                lblRemainingBalance.Text = dp.GetInt32("balance").ToString();
                                lblTotalPayment.Text = dp.GetInt32("totalPayment").ToString();
                                txtBorrowerID.Text = "";
                                txtAmount.Text = "";
                                lblBalance.Text = "0";
                                lblTotal.Text = "0";
                            }
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Payment Failed!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Loan Dont Exist!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Click the Get Amount First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }    
        }

        private void payback_Load(object sender, EventArgs e)
        {
            txtBorrowerID.Focus();
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

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
