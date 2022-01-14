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
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingSystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void loans_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT loans.loanID as 'Loan ID',borrower.borrowerID as BorrowerID,borrower.firstName as 'First Name', borrower.lastName as 'Last Name', borrower.middleName as " +
                    "'Middle Name', loans.amount as 'Amount', loans.duration as 'Duration',loans.daysRemaining as 'Days Remaining',loans.interest as 'Interest',loans.dailyPayment as " +
                    "'Daily Payment',loans.balance as 'Balance',DATE_FORMAT(loans.dateBorrow, '%m/%d/%Y') as 'Date Borrowed', DATE_FORMAT(loans.duedate, '%m/%d/%Y') as 'Due Date' from borrower," +
                    "loans where borrower.borrowerID = loans.borrowerID AND loans.balance != 0;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewLoans.DataSource = dtable;
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
            string dataTable = "SELECT loans.loanID as 'Loan ID',borrower.borrowerID as BorrowerID,borrower.firstName as 'First Name', borrower.lastName as 'Last Name', borrower.middleName as " +
                    "'Middle Name', loans.amount as 'Amount', loans.duration as 'Duration',loans.daysRemaining as 'Days Remaining',loans.interest as 'Interest',loans.dailyPayment as " +
                    "'Daily Payment',loans.balance as 'Balance',DATE_FORMAT(loans.dateBorrow, '%m/%d/%Y') as 'Date Borrowed', DATE_FORMAT(loans.duedate,'%m/%d/%Y') as 'Due Date' from borrower," +
                    "loans where borrower.borrowerID = loans.borrowerID AND loans.balance != 0;";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewLoans.DataSource = dtable;
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
                MessageBox.Show("Sorting Success", "Data Sorted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string dataTable = "SELECT loans.loanID as 'Loan ID',borrower.borrowerID as BorrowerID,borrower.firstName as 'First Name', borrower.lastName as 'Last Name', borrower.middleName as " +
                    "'Middle Name', loans.amount as 'Amount', loans.duration as 'Duration',loans.daysRemaining as 'Days Remaining',loans.interest as 'Interest',loans.dailyPayment as " +
                    "'Daily Payment',loans.balance as 'Balance',DATE_FORMAT(loans.dateBorrow, '%m/%d/%Y') as 'Date Borrowed', DATE_FORMAT(loans.duedate, '%m/%d/%Y') as 'Due Date' from borrower," +
                    "loans where borrower.borrowerID = loans.borrowerID AND loans.balance != 0 AND borrower." + searchBy.Text + " LIKE '%" + txtSearch.Text + "%';";
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
            applyLoan.btnApply.Text = "Apply";
            applyLoan.lblEditMode.Text = "FALSE";

            //Cursor Fucos on Borrower ID textField
            applyLoan.txtBorrowerID.Focus();

            applyLoan.Show();


        }

        private void dataGridViewLoans_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewLoans.ClearSelection();
        }

        private void dataGridViewLoans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //instantiate the value of dgv to edit form
            ViewLoans viewLoans = new ViewLoans();
            DataGridViewRow getData = dataGridViewLoans.Rows[indexRow];

            //instantiate the value
            viewLoans.lblFirstname.Text = Convert.ToString(getData.Cells[2].Value);
            viewLoans.lblLastname.Text = Convert.ToString(getData.Cells[3].Value);
            viewLoans.lblMiddlename.Text = Convert.ToString(getData.Cells[4].Value);
            viewLoans.lblLoanAmount.Text = Convert.ToString(getData.Cells[5].Value);
            viewLoans.lblDuration.Text = Convert.ToString(getData.Cells[6].Value);
            viewLoans.lblDaysRemaining.Text = Convert.ToString(getData.Cells[7].Value);
            viewLoans.lblInterestRate.Text = Convert.ToString(getData.Cells[8].Value);
            viewLoans.lblDailyPayment.Text = Convert.ToString(getData.Cells[9].Value);
            viewLoans.lblBalance.Text = Convert.ToString(getData.Cells[10].Value);
            viewLoans.lblDateBorrowed.Text = Convert.ToString(getData.Cells[11].Value).Substring(0, 10);
            viewLoans.lblDueDate.Text = Convert.ToString(getData.Cells[12].Value).Substring(0, 10);
            

            //shows the edit form
            viewLoans.ShowDialog();
        }

        private void btnFailedToPay_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT loans.loanID as 'Loan ID',borrower.borrowerID as BorrowerID,borrower.firstName as 'First Name', borrower.lastName as 'Last Name', borrower.middleName as " +
                    "'Middle Name', loans.amount as 'Amount', loans.duration as 'Duration',loans.daysRemaining as 'Days Remaining',loans.interest as 'Interest',loans.dailyPayment as " +
                    "'Daily Payment',loans.balance as 'Balance',loans.dateBorrow as 'Date Borrowed', loans.duedate as 'Due Date' from borrower," +
                    "loans where borrower.borrowerID = loans.borrowerID AND duedate < CURDATE();";
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoans.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data to be exported!", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Are you sure you want to Export data now to Excel?", "Export To Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //saving datagrid inputs to microsoft excel
                saveFileDialog1.InitialDirectory = "C:/Downloads";
                saveFileDialog1.Title = "Save as Excel File";
                saveFileDialog1.FileName = "Loans_Record";
                saveFileDialog1.Filter = "Excel Files(2019)|*.xlsx";

                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    //Change properties of the workbook
                    ExcelApp.Columns.ColumnWidth = 20;

                    //Storing header Part in Excel
                    for (int i = 1; i < dataGridViewLoans.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridViewLoans.Columns[i - 1].HeaderText;
                    }

                    //Storing each row and column value to excel sheet
                    for (int i = 0; i < dataGridViewLoans.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewLoans.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridViewLoans.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();

                    MessageBox.Show("Data Has Been Successfully Exported to Excel File", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLoans.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Mark this loan Red?", "Mark Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //update the back color on timed out car
                        DataGridViewRow rowColor = dataGridViewLoans.Rows[indexRow];
                        rowColor.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Marking Data Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
