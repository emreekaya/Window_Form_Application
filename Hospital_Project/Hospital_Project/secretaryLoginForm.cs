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
    public partial class SecretaryEntranceForm : Form
    {
        public SecretaryEntranceForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select * From secretariesTable Where secretaryTC=@p1 and secretaryPassword=@p2",SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                SecretaryDetailForm frs = new SecretaryDetailForm();
                frs.TC_number = mskTC.Text;
                SqlCon.Connection.Close();
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Message.Incorrect, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SqlCon.Connection.Close();
            }
        }
    }
}
