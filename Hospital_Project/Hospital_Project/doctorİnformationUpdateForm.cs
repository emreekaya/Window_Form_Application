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
    public partial class DoctorInformationUpdateForm : Form
    {
        public DoctorInformationUpdateForm()
        {
            InitializeComponent();
        }

        public string TCNO;
        private void DoctorInformationUpdateForm_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCNO;
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select * From doctorsTable Where doctorTc=@p1", SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
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
            if (txtSurname.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the Surname");
                return;
            }
            if (cmbBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please choose the branch");
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the password");
                return;
            }
            else
            {
                SqlCon.Connection.Open();
                SqlCommand commandUpdate = new SqlCommand("Update doctorsTable Set doctorName=@p1, doctorSurname=@p2, doctorBranch=@p3, doctorPassword=@p4 Where doctorTC=@p5", SqlCon.Connection);
                commandUpdate.Parameters.AddWithValue("@p1", txtName.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p2", txtSurname.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p3", cmbBranch.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p4", txtPassword.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@p5", mskTC.Text.Trim());
                commandUpdate.ExecuteNonQuery();
                SqlCon.Connection.Close();
                MessageBox.Show(Message.Update, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
