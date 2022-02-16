using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class DoctorSPanelForm : Form
    {
        public DoctorSPanelForm()
        {
            InitializeComponent();
        }

        private void DoctorSPanelForm_Load(object sender, EventArgs e)
        {
            this.doctorsTableTableAdapter.Fill(this.hastaneProjeDataSet.doctorsTable);
            //SqlCon.Connection.Open();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From doctorsTable", SqlCon.Connection);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //SqlCon.Connection.Close();

            //Transfer the branches to the combobox
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select branchName From branchesTable", SqlCon.Connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbBranch.Items.Add(dr[0]);
            }

            SqlCon.Connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            else if (cmbBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please choose the branch");
                return;
            }
            else if (mskTc.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the TC number");
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the password");
                return;
            }
            else
            {
                SqlCon.Connection.Open();
                SqlCommand commandAdd = new SqlCommand("Insert into doctorsTable (doctorName,doctorSurname,doctorBranch,doctorTC,doctorPassword) values (@d1,@d2,@d3,@d4,@d5)", SqlCon.Connection);
                commandAdd.Parameters.AddWithValue("@d1", txtName.Text.Trim());
                commandAdd.Parameters.AddWithValue("@d2", txtSurname.Text.Trim());
                commandAdd.Parameters.AddWithValue("@d3", cmbBranch.Text.Trim());
                commandAdd.Parameters.AddWithValue("@d4", mskTc.Text.Trim());
                commandAdd.Parameters.AddWithValue("@d5", txtPassword.Text.Trim());
                commandAdd.ExecuteNonQuery();
                this.doctorsTableTableAdapter.Fill(this.hastaneProjeDataSet.doctorsTable);
                SqlCon.Connection.Close();
                MessageBox.Show(Message.Insert, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCon.Connection.Open();
            SqlCommand commandDelete = new SqlCommand("Delete from doctorsTable Where doctorTC=@p1", SqlCon.Connection);
            commandDelete.Parameters.AddWithValue("@p1", mskTc.Text);
            commandDelete.ExecuteNonQuery();
            this.doctorsTableTableAdapter.Fill(this.hastaneProjeDataSet.doctorsTable);
            SqlCon.Connection.Close();
            MessageBox.Show(Message.Delete, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            else if (cmbBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please choose the branch");
                return;
            }
            else if (mskTc.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the TC number");
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the password");
                return;
            }
            else
            {
                SqlCon.Connection.Open();
                SqlCommand commandUpdate = new SqlCommand("Update doctorsTable set doctorName=@d1,doctorSurname=@d2,doctorBranch=@d3,doctorPassword=@d5 Where doctorTC=@d4", SqlCon.Connection);
                commandUpdate.Parameters.AddWithValue("@d1", txtName.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@d2", txtSurname.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@d3", cmbBranch.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@d4", mskTc.Text.Trim());
                commandUpdate.Parameters.AddWithValue("@d5", txtPassword.Text.Trim());
                commandUpdate.ExecuteNonQuery();
                this.doctorsTableTableAdapter.Fill(this.hastaneProjeDataSet.doctorsTable);
                SqlCon.Connection.Close();
                MessageBox.Show(Message.Update, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}