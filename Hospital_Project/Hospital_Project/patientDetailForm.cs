using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class PatientDetailForm : Form
    {
        public PatientDetailForm()
        {
            InitializeComponent();
        }

        public string tc;
        private void patientDetailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneProjeDataSet.appointmentsTable' table. You can move, or remove it, as needed.
            this.appointmentsTableTableAdapter.Fill(this.hastaneProjeDataSet.appointmentsTable);
            try
            {
                lblTC.Text = tc;

                // Transferring name and surname data
                SqlCon.Connection.Open();
                SqlCommand command = new SqlCommand("Select patientName, patientSurname From patientsTable Where patientTC=@p1;", SqlCon.Connection);
                command.Parameters.AddWithValue("@p1", lblTC.Text);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    lblName.Text = dr[0] + " " + dr[1];
                }
            }
            catch
            {
                SqlCon.Connection.Close();
            }
            SqlCon.Connection.Close();

            //Appointment history
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From appointmentsTable Where patientTC=" +lblTC.Text, SqlCon.Connection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Trasferring Branches
            SqlCon.Connection.Open();
            SqlCommand command2 = new SqlCommand("Select branchName from branchesTable", SqlCon.Connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            SqlCon.Connection.Close();
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCon.Connection.Open();
            cmbDoctor.Items.Clear();
            SqlCommand command3= new SqlCommand("Select doctorName,doctorSurname from doctorsTable Where doctorBranch=@p1",SqlCon.Connection);
            command3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            SqlCon.Connection.Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * From appointmentsTable Where appointmentBranch='" + cmbBranch.Text + "'" + " and appointmentDoctor='" + cmbDoctor.Text + "' and appointmentStatus=0", SqlCon.Connection);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkEditİnfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditInformationForm fr = new EditInformationForm();
            fr.TCno = lblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Update appointmentsTable Set appointmentStatus=1, patientTC=@p1, patientComplaint=@p2 Where appointmentId=@p3",SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            command.Parameters.AddWithValue("@p2", rchComplaint.Text);
            command.Parameters.AddWithValue("@p3", txtId.Text);
            command.ExecuteNonQuery();
            SqlCon.Connection.Close();
            MessageBox.Show(Message.appointmentSuccess, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}