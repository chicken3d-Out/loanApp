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
    public partial class AddBorrower : Form
    {
        public AddBorrower()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=reactangularvue;database=lendingSystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFIrstname.Text == "")
                {
                    MessageBox.Show("Firstname Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtLastname.Text == "")
                {
                    MessageBox.Show("Lastname Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtMiddlename.Text == "")
                {
                    MessageBox.Show("Middlename Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtBarangay.Text == "")
                {
                    MessageBox.Show("Barangay Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (collector.Text == "")
                {
                    MessageBox.Show("Age Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtGender.Text == "")
                {
                    MessageBox.Show("You Did Not Select a Gender!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtMunicipality.Text == "")
                {
                    MessageBox.Show("Municipality Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtOccupation.Text == "")
                {
                    MessageBox.Show("Occupation Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtPhoneNo.Text == "")
                {
                    MessageBox.Show("Phone Number Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtProvince.Text == "")
                {
                    MessageBox.Show("Province Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtStreet.Text == "")
                {
                    MessageBox.Show("Street Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(txtZipCode.Text == "")
                {
                    MessageBox.Show("Zip Code Field is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Classify if Action is For Inserting or Updating
                if(lblEditMode.Text == "FALSE")
                {
                    con.Open();
                    string addBorrower = "INSERT INTO borrower VALUES (NULL,'"+txtFIrstname.Text+"','"+txtLastname.Text+"','"+txtMiddlename.Text+"'" +
                        ",0,'"+txtGender.Text+"','"+txtStreet.Text+"','"+txtBarangay.Text+"','"+txtMunicipality.Text+"','"+txtProvince.Text+"'" +
                        ","+txtZipCode.Text+","+txtPhoneNo.Text+",'"+txtOccupation.Text+"','"+collector.Text+"');";
                    cmd = new MySqlCommand(addBorrower, con);
                    int success = cmd.ExecuteNonQuery();
                    con.Close();

                    if(success > 0)
                    {
                        MessageBox.Show("Record Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFIrstname.Text = "";
                        txtLastname.Text = "";
                        txtMiddlename.Text = "";
                        collector.Text = "";
                        txtGender.Text = "";
                        txtStreet.Text = "";
                        txtBarangay.Text = "";
                        txtMunicipality.Text = "";
                        txtProvince.Text = "";
                        txtZipCode.Text = "";
                        txtPhoneNo.Text = "";
                        txtOccupation.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed To Create Record!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (lblEditMode.Text == "TRUE")
                {
                    con.Open();
                    string editBorrower = "UPDATE borrower SET firstName ='" + txtFIrstname.Text + "', lastName = '" + txtLastname.Text + "', middleName = '" + txtMiddlename.Text + "'" +
                        ", collectorInCharge = " + collector.Text + ", gender = '" + txtGender.Text + "', street = '" + txtStreet.Text + "', barangay = '" + txtBarangay.Text + "', municipality = '" + txtMunicipality.Text + "', province = '" + txtProvince.Text + "'" +
                        ", zipcode = " + txtZipCode.Text + ", phoneNo = " + txtPhoneNo.Text + ", occupation = '" + txtOccupation.Text + "' WHERE borrowerID = "+borrowerID.Text+"";
                    cmd = new MySqlCommand(editBorrower, con);
                    int success = cmd.ExecuteNonQuery();
                    con.Close();

                    if (success > 0)
                    {
                        MessageBox.Show("Record Successfully Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed To Update Record!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Please Open the XAMPP Connection First!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFIrstname.Text = "";
            txtLastname.Text = "";
            txtMiddlename.Text = "";
            collector.Text = "";
            txtGender.Text = "";
            txtStreet.Text = "";
            txtBarangay.Text = "";
            txtMunicipality.Text = "";
            txtProvince.Text = "";
            txtZipCode.Text = "";
            txtPhoneNo.Text = "";
            txtOccupation.Text = "";
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void collector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false || char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
