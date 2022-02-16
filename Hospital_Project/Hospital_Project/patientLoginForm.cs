using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class PatientEntranceForm : Form
    {
        public PatientEntranceForm()
        {
            InitializeComponent();
        }

        private void lnkSingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegistrationForm fr = new PatientRegistrationForm();
            fr.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select * from patientsTable Where patientTC=@p1 and patientPassword=@p2",SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                PatientDetailForm fr = new PatientDetailForm();
                fr.tc = mskTC.Text;
                SqlCon.Connection.Close();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Message.Incorrect);
                SqlCon.Connection.Close();
            }
        }
    }
}