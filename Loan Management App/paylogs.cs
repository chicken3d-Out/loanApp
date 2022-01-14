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
    public partial class paylogs : UserControl
    {
        public paylogs()
        {
            InitializeComponent();
        }
        //index row for identifying what column is selected
        int indexRow;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingSystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void paylogs_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT payLogs.payLogsID as 'Pay Logs ID',loans.loanID as 'Loan ID',borrower.firstName as 'First Name', borrower.lastName as 'Last Name', payLogs.o as '-',payLogs.payment as" +
                    " 'Payment Amount', payLogs.oo as '--',DATE_FORMAT(payLogs.dateOfPayment, '%m/%d/%Y') as 'Date of Payment',payLogs.ooo as '---', payLogs.balance as 'Balance' " +
                    "from borrower,payLogs,loans where borrower.borrowerID = payLogs.borrowerID AND loans.loanID = payLogs.loanID;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewPayLogs.DataSource = dtable;
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
            string dataTable = "SELECT payLogs.payLogsID as 'Pay Logs ID',loans.loanID as 'Loan ID',borrower.firstName as 'First Name', borrower.lastName as 'Last Name', payLogs.o as '-',payLogs.payment as" +
                    " 'Payment Amount', payLogs.oo as '--',DATE_FORMAT(payLogs.dateOfPayment, '%m/%d/%Y') as 'Date of Payment',payLogs.ooo as '---', payLogs.balance as 'Balance' " +
                    "from borrower,payLogs,loans where borrower.borrowerID = payLogs.borrowerID AND loans.loanID = payLogs.loanID;";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewPayLogs.DataSource = dtable;
            con.Close();

            //clears search fields
            searchBy.Text = "";
            txtSearch.Text = "";
        }

        private void dataGridViewPayLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewPayLogs.Rows[indexRow];
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
                DataGridViewRow getID = dataGridViewPayLogs.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewPayLogs.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Permanently Delete This Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string delete = "DELETE FROM payLogs WHERE payLogsID ='" + getID.Cells[0].Value + "'";
                        cmd = new MySqlCommand(delete, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //updates the deleted row from the datagridview automatically
                        int rowIndex = dataGridViewPayLogs.CurrentCell.RowIndex;
                        dataGridViewPayLogs.Rows.RemoveAt(rowIndex);
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
                string dataTable = "SELECT payLogs.payLogsID as 'Pay logs ID',loans.loanID as 'Loan ID',borrower.firstName as 'First Name', borrower.lastName as 'Last Name', payLogs.o as '-',payLogs.payment as" +
                    " 'Payment Amount', payLogs.oo as '--',DATE_FORMAT(payLogs.dateOfPayment, '%m/%d/%Y') as 'Date of Payment',payLogs.ooo as '---', payLogs.balance as 'Balance' " +
                    "from borrower,payLogs,loans where borrower.borrowerID = payLogs.borrowerID AND loans.loanID = payLogs.loanID AND loans." + searchBy.Text + " LIKE '%" + txtSearch.Text + "%';";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewPayLogs.DataSource = dtable;
                con.Close();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dataGridViewPayLogs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewPayLogs.ClearSelection();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayLogs.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data to be exported!", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Are you sure you want to Export data now to Excel?", "Export To Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //saving datagrid inputs to microsoft excel
                saveFileDialog1.InitialDirectory = "C:/Downloads";
                saveFileDialog1.Title = "Save as Excel File";
                saveFileDialog1.FileName = "Pay Logs Report";
                saveFileDialog1.Filter = "Excel Files(2019)|*.xlsx";

                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    //Change properties of the workbook
                    ExcelApp.Columns.ColumnWidth = 20;

                    //Storing header Part in Excel
                    for (int i = 1; i < dataGridViewPayLogs.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridViewPayLogs.Columns[i - 1].HeaderText;
                    }

                    //Storing each row and column value to excel sheet
                    for (int i = 0; i < dataGridViewPayLogs.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewPayLogs.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridViewPayLogs.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();

                    MessageBox.Show("Data Has Been Successfully Exported to Excel File", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
