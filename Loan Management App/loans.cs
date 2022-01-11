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
    public partial class loans : UserControl
    {
        public loans()
        {
            InitializeComponent();
        }
        //index row for identifying what column is selected
        int indexRow;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=lendingSystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void loans_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT loans.loanID as 'Loan ID',borrower.firstName as 'First Name', borrower.lastName as 'Last Name', borrower.middleName as " +
                    "'Middle Name', loans.amount as 'Amount', loans.duration as 'Duration',loans.daysRemaining as 'Days Remaining',loans.interest as 'Interest',loans.dailyPayment as " +
                    "'Daily Payment',loans.balance as 'Balance',loans.dateBorrow as 'Date Borrowed', loans.duedate as 'Due Date' from borrower," +
                    "loans where borrower.borrowerID = loans.borrowerID";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewLoans.DataSource = dtable;
                dataGridViewLoans.CurrentCell.Selected = false;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Action Cannot Be Processed!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Open Connection
            con.Open();
            string dataTable = "SELECT loans.loanID as 'Loan ID',borrower.firstName as 'First Name', borrower.lastName as 'Last Name', borrower.middleName as " +
                    "'Middle Name', loans.amount as 'Amount', loans.duration as 'Duration',loans.daysRemaining as 'Days Remaining',loans.interest as 'Interest',loans.dailyPayment as " +
                    "'Daily Payment',loans.balance as 'Balance',loans.dateBorrow as 'Date Borrowed', loans.duedate as 'Due Date' from borrower," +
                    "loans where borrower.borrowerID = loans.borrowerID";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewLoans.DataSource = dtable;
            dataGridViewLoans.CurrentCell.Selected = false;
            con.Close();

            //clears search fields
            searchBy.Text = "";
            txtSearch.Text = "";
        }

        private void dataGridViewLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewLoans.Rows[indexRow];
            }
            catch
            {
                MessageBox.Show("Avoid Clicking Anywhere", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow getID = dataGridViewLoans.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewLoans.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Permanently Delete This Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string delete = "DELETE FROM loans WHERE loanID ='" + getID.Cells[0].Value + "'";
                        cmd = new MySqlCommand(delete, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //updates the deleted row from the datagridview automatically
                        int rowIndex = dataGridViewLoans.CurrentCell.RowIndex;
                        dataGridViewLoans.Rows.RemoveAt(rowIndex);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed To Delete!", "Delete Unsucessfull!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (searchBy.Text == "")
            {
                MessageBox.Show("Don't Leave the Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchBy.Focus();
            }
            else if (txtSearch.Text == "")
            {
                MessageBox.Show("Don't Leave the Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
            }
            else
            {
                con.Open();
                string dataTable = "SELECT loans.loanID as 'Loan ID',borrower.firstName as 'First Name', borrower.lastName as 'Last Name', borrower.middleName as " +
                    "'Middle Name', loans.amount as 'Amount', loans.duration as 'Duration',loans.daysRemaining as 'Days Remaining',loans.interest as 'Interest',loans.dailyPayment as " +
                    "'Daily Payment',loans.balance as 'Balance',loans.dateBorrow as 'Date Borrowed', loans.duedate as 'Due Date' from borrower," +
                    "loans where borrower.borrowerID = loans.borrowerID AND borrower." + searchBy.Text + " LIKE '%" + txtSearch.Text + "%';";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewLoans.DataSource = dtable;
                con.Close();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Apply_Loan applyLoan = new Apply_Loan();
            applyLoan.Show();
        }
    }
}
