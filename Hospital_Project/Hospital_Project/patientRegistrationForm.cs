using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hospital_Project
{
    public partial class PatientRegistrationForm : Form
    {
        public PatientRegistrationForm()
        {
            InitializeComponent();
        }
        private void btnSingUp_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() =="")
            {
                MessageBox.Show("Please enter the name");
                return;
            }
            else if (txtSurname.Text.Trim()=="")
            {
                MessageBox.Show("Please enter the surname");
                return;
            }
            else if (txtPassword.Text.Trim() =="")
            {
                MessageBox.Show("Please enter the password");
                return;
            }
            else if (mskTC.Text.Trim() =="")
            {
                MessageBox.Show("Please enter the TC identity number");
                return;
            }
            else if (mskPhone.Text.Trim() =="")
            {
                MessageBox.Show("Please enter the phone  number");
                return;
            }
            else if (cmbGender.Text.Trim() =="")
            {
                MessageBox.Show("Please choose gender");
                return;
            }
            else
            {
                SqlCommand patientRegistrationCommand = new SqlCommand("insert into patientsTable (patientName,patientSurname,patientTC,patientPhone,patientPassword,patientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", SqlCon.Connection);

                SqlCon.Connection.Open();
                patientRegistrationCommand.Parameters.AddWithValue("@p1", txtName.Text.Trim());
                patientRegistrationCommand.Parameters.AddWithValue("@p2", txtSurname.Text.Trim());
                patientRegistrationCommand.Parameters.AddWithValue("@p3", mskTC.Text.Trim());
                patientRegistrationCommand.Parameters.AddWithValue("@p4", mskPhone.Text.Trim());
                patientRegistrationCommand.Parameters.AddWithValue("@p5", txtPassword.Text.Trim());
                patientRegistrationCommand.Parameters.AddWithValue("@p6", cmbGender.Text.Trim());
                patientRegistrationCommand.ExecuteNonQuery();
                SqlCon.Connection.Close();
                MessageBox.Show(Message.Success, "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
