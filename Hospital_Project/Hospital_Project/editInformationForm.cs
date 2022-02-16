using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class EditInformationForm : Form
    {
        public EditInformationForm()
        {
            InitializeComponent();
        }

        public string TCno;
        private void EditInformationForm_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select * From patientsTable Where patientTC=@p1", SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                mskPhone.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                cmbGender.Text = dr[6].ToString();
            }
            SqlCon.Connection.Close();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the name");
                return;
            }
            else if (txtSurname.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the surname");
                return;
            }
            else if (mskPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the phone number");
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the password");
                return;
            }
            else if (cmbGender.Text.Trim() == "")
            {
                MessageBox.Show("Please choose the gender");
                return;
            }
            else
            {
                SqlCon.Connection.Open();
                SqlCommand commandUpdate = new SqlCommand("Update patientsTable set patientName=@p1, patientSurname=@p2, patientPhone=@p3, patientPassword=@p4, patientGender=@p5 Where patientTC=@p6 ", SqlCon.Connection);
                commandUpdate.Parameters.AddWithValue("@p1", txtName.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p2", txtSurname.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p3", mskPhone.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p4", txtPassword.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p5", cmbGender.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p6", mskTC.Text.Trim());
                commandUpdate.ExecuteNonQuery();
                SqlCon.Connection.Close();
                MessageBox.Show(Message.Update, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
