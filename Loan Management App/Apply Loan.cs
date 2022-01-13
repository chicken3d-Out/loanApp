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
    public partial class Apply_Loan : Form
    {
        public Apply_Loan()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=lendingSystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        //Variable
        string dueDate;
        double interestRate;
        double balance;
        double dailyPayment;
        double additionalAmount;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAmountLoan.Text == "")
                {
                    MessageBox.Show("Loan Amount Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtDuationinDays.Text == "")
                {
                    MessageBox.Show("Duration Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtInterestRate.Text == "")
                {
                    MessageBox.Show("Interest Rate Filed is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Date
                int duration = Convert.ToInt32(txtDuationinDays.Text);

                this.dueDate = DateTime.Now.AddDays(duration).ToShortDateString();

                //Get Interest rate
                this.interestRate = (Convert.ToDouble(txtInterestRate.Text) / 100);
                //Get Aditional Amount of Loan * Interesrt Rate
                this.additionalAmount = Convert.ToInt32(txtAmountLoan.Text) * this.interestRate;
                //Get Total Amount Additional Amount + balance
                this.balance = Convert.ToInt32(txtAmountLoan.Text) + this.additionalAmount;
                //Get Daily Payment
                this.dailyPayment = this.balance / Convert.ToInt32(txtDuationinDays.Text);

                //Display All Calculation
                lblDailyPayment.Text = (Convert.ToDouble(txtInterestRate.Text) / 100).ToString();

                lblDailyPayment.Text = Convert.ToString(this.dailyPayment);
                lblTotalPayment.Text = Convert.ToString(this.balance);
                lblDuration.Text = txtDuationinDays.Text;

                lblDueDate.Text = this.dueDate;

                

            }
            catch
            {
                MessageBox.Show("Apply Loans Error!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBorrowerID.Text == "")
                {
                    MessageBox.Show("Borrower ID Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtAmountLoan.Text == "")
                {
                    MessageBox.Show("Loan Amount Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtDuationinDays.Text == "")
                {
                    MessageBox.Show("Duration Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtInterestRate.Text == "")
                {
                    MessageBox.Show("Interest Rate Filed is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Classify if Action is For Inserting or Updating
                if (lblEditMode.Text == "FALSE")
                {
                    con.Open();
                    string checkBorrowerExist = "SELECT borrowerID from borrower where borrowerID = " + txtBorrowerID.Text + ";";
                    cmd = new MySqlCommand(checkBorrowerExist, con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        string addLoans = "INSERT INTO loans values(null,"+txtBorrowerID.Text+","+txtAmountLoan.Text+","+txtDuationinDays.Text+"," +
                            ""+txtDuationinDays.Text+","+txtInterestRate.Text+","+this.dailyPayment+","+this.balance+",curdate(),DATE_ADD(CURDATE(),INTERVAL " +
                            ""+txtDuationinDays.Text+" DAY));";
                        cmd = new MySqlCommand(addLoans, con);
                        int success = cmd.ExecuteNonQuery();
                        con.Close();
                        if (success > 0)
                        {
                            MessageBox.Show("Record Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBorrowerID.Text = "";
                            txtAmountLoan.Text = "";
                            txtDuationinDays.Text = "";
                            txtInterestRate.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed To Create Record!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }       
                    }
                    else
                    {
                        MessageBox.Show("Borrower Dont Exist", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBorrowerID.Text = "";
                        txtAmountLoan.Text = "";
                        txtDuationinDays.Text = "";
                        txtInterestRate.Text = "";
                        con.Close();
                    }

                }
                else if (lblEditMode.Text == "TRUE")
                {
                    con.Open();
                    string checkBorrowerExist = "SELECT borrowerID from loans where borrowerID = " + txtBorrowerID.Text + ";";
                    cmd = new MySqlCommand(checkBorrowerExist, con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        string editLoans = "UPDATE loans SET amount =" + txtAmountLoan.Text + ", duration =" + txtDuationinDays.Text + "," +
                            "daysRemaining = " + txtDuationinDays.Text + ", interest =" + txtInterestRate.Text + ", dailyPayment =" + lblDailyPayment.Text + ", " +
                            "balance =" + lblTotalPayment.Text + " WHERE borrowerID = "+txtBorrowerID.Text+"";
                        cmd = new MySqlCommand(editLoans, con);
                        int success = cmd.ExecuteNonQuery();
                        con.Close();
                        if (success > 0)
                        {
                            MessageBox.Show("Record Successfully Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBorrowerID.Text = "";
                            txtAmountLoan.Text = "";
                            txtDuationinDays.Text = "";
                            txtInterestRate.Text = "";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed To Update Record!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Borrower Dont Exist", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBorrowerID.Text = "";
                        txtAmountLoan.Text = "";
                        txtDuationinDays.Text = "";
                        txtInterestRate.Text = "";
                        con.Close();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Creating Borrower Error!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBorrowerID.Text = "";
            txtAmountLoan.Text = "";
            txtDuationinDays.Text = "";
            txtInterestRate.Text = "";
        }

        private void txtBorrowerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtAmountLoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtDuationinDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
