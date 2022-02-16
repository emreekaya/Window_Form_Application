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
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneProjeDataSet.branchesTable' table. You can move, or remove it, as needed.
            this.branchesTableTableAdapter.Fill(this.hastaneProjeDataSet.branchesTable);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * from branchesTable", SqlCon.Connection);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the branch name");
                return;
            }
            SqlCon.Connection.Open();
            SqlCommand commandAdd = new SqlCommand("Insert into branchesTable (branchName) values(@b1)", SqlCon.Connection);
            commandAdd.Parameters.AddWithValue("@b1",txtBranch.Text);
            commandAdd.ExecuteNonQuery();
            this.branchesTableTableAdapter.Fill(this.hastaneProjeDataSet.branchesTable);
            SqlCon.Connection.Close();
            MessageBox.Show(Message.Insert, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtBranch.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCon.Connection.Open();
            SqlCommand commandDelete = new SqlCommand("Delete from branchesTable Where branchId=@b1", SqlCon.Connection);
            commandDelete.Parameters.AddWithValue("@b1", txtId.Text);
            commandDelete.ExecuteNonQuery();
            this.branchesTableTableAdapter.Fill(this.hastaneProjeDataSet.branchesTable);
            SqlCon.Connection.Close();
            MessageBox.Show(Message.Delete, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtId.Text = "";
            txtBranch.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the branch name");
                return;
            }
            SqlCon.Connection.Open();
            SqlCommand commandUpdate = new SqlCommand("Update branchesTable set branchName=@b1 Where branchId=@b2", SqlCon.Connection);
            commandUpdate.Parameters.AddWithValue("@b1", txtBranch.Text.Trim());
            commandUpdate.Parameters.AddWithValue("@b2", txtId.Text.Trim());
            commandUpdate.ExecuteNonQuery();
            this.branchesTableTableAdapter.Fill(this.hastaneProjeDataSet.branchesTable);
            SqlCon.Connection.Close();
            MessageBox.Show(Message.Update, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
