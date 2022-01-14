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
    public partial class borrower : UserControl
    {
        public borrower()
        {
            InitializeComponent();
        }
        //index row for identifying what column is selected
        int indexRow;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingSystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();
        private void borrower_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT borrowerID as 'Borrower ID', firstName as 'First Name', lastName as 'Last Name', middleName as 'Middle Name'," +
                    " age as 'Age', gender as 'Gender',street as 'Street', barangay as 'Barangay', municipality as 'Municipality', province as 'Province', " +
                    "zipcode as 'Zip Code', phoneNo as 'Phone No.', occupation as 'Occupation' from borrower;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewBorrower.DataSource = dtable;
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
            string dataTable = "SELECT borrowerID as 'Borrower ID', firstName as 'First Name', lastName as 'Last Name', middleName as 'Middle Name'," +
                    " age as 'Age', gender as 'Gender',street as 'Street', barangay as 'Barangay', municipality as 'Municipality', province as 'Province', " +
                    "zipcode as 'Zip Code', phoneNo as 'Phone No.', occupation as 'Occupation' from borrower;";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewBorrower.DataSource = dtable;
            con.Close();

            //clears search fields
            searchBy.Text = "";
            txtSearch.Text = "";
        }

        private void dataGridViewBorrower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewBorrower.Rows[indexRow];
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
                DataGridViewRow getID = dataGridViewBorrower.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewBorrower.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Permanently Delete This Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string delete = "DELETE FROM borrower WHERE borrowerID ='" + getID.Cells[0].Value + "'";
                        cmd = new MySqlCommand(delete, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //updates the deleted row from the datagridview automatically
                        int rowIndex = dataGridViewBorrower.CurrentCell.RowIndex;
                        dataGridViewBorrower.Rows.RemoveAt(rowIndex);
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
                string dataTable = "SELECT borrowerID as 'Borrower ID', firstName as 'First Name', lastName as 'Last Name', middleName as 'Middle Name'," +
                    " age as 'Age', gender as 'Gender',street as 'Street', barangay as 'Barangay', municipality as 'Municipality', province as 'Province', " +
                    "zipcode as 'Zip Code', phoneNo as 'Phone No.', occupation as 'Occupation' from borrower WHERE " + searchBy.Text + " LIKE '%" + txtSearch.Text + "%';";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewBorrower.DataSource = dtable;
                con.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddBorrower addBorrower = new AddBorrower();
            addBorrower.Show();
            addBorrower.txtFIrstname.Focus();
            //Change the button text For Adding Borrower to "Register"
            addBorrower.btnRegister.Text = "Register";
            //Change the EditMode into false
            addBorrower.lblEditMode.Text = "FALSE";

        }

        private void dataGridViewBorrower_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewBorrower.ClearSelection();
        }

        private void dataGridViewBorrower_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //instantiate the value of dgv to edit form
            AddBorrower editBorrower = new AddBorrower();
            DataGridViewRow getData = dataGridViewBorrower.Rows[indexRow];

            //instantiate the value
            editBorrower.borrowerID.Text = Convert.ToString(getData.Cells[0].Value);
            editBorrower.txtFIrstname.Text = Convert.ToString(getData.Cells[1].Value);
            editBorrower.txtLastname.Text = Convert.ToString(getData.Cells[2].Value);
            editBorrower.txtMiddlename.Text = Convert.ToString(getData.Cells[3].Value);
            editBorrower.txtAge.Text = Convert.ToString(getData.Cells[4].Value);
            editBorrower.txtGender.Text = Convert.ToString(getData.Cells[5].Value);
            editBorrower.txtStreet.Text = Convert.ToString(getData.Cells[6].Value);
            editBorrower.txtBarangay.Text = Convert.ToString(getData.Cells[7].Value);
            editBorrower.txtMunicipality.Text = Convert.ToString(getData.Cells[8].Value);
            editBorrower.txtProvince.Text = Convert.ToString(getData.Cells[9].Value);
            editBorrower.txtZipCode.Text = Convert.ToString(getData.Cells[10].Value);
            editBorrower.txtPhoneNo.Text = Convert.ToString(getData.Cells[11].Value);
            editBorrower.txtOccupation.Text = Convert.ToString(getData.Cells[12].Value);

            //Edit Mode
            editBorrower.lblUpperLabel.Text = "Update Borrower Details";
            editBorrower.lblEditMode.Text = "TRUE";
            editBorrower.btnRegister.Text = "Save";

            //shows the edit form
            editBorrower.ShowDialog();
        }
    }
}
