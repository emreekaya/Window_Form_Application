using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class SecretaryDetailForm : Form
    {
        public SecretaryDetailForm()
        {
            InitializeComponent();
        }
        public string TC_number;
        private void SecretaryDetailForm_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC_number;

            // Name Surname
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select secretaryNameSurname From secretariesTable Where secretaryTC=@p1",SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr[0].ToString();
            }
            SqlCon.Connection.Close();

            //brachesData
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From branchesTable", SqlCon.Connection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doctorsData
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doctorName + ' ' + doctorSurname) as 'Doctors', doctorBranch From doctorsTable",SqlCon.Connection);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Transfer the branches to the combobox
            SqlCon.Connection.Open();
            SqlCommand command2 = new SqlCommand("Select branchName From branchesTable", SqlCon.Connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            SqlCon.Connection.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mskDate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the date");
                return;
            }
            else if (mskTime.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the time");
                return;
            }
            else if (cmbBranch.Text.Trim() == "")
            {
                MessageBox.Show("Please choose the branch");
                return;
            }
            else if (cmbDoctor.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the doctor");
                return;
            }
            else
            {
                SqlCon.Connection.Open();
                SqlCommand commandSave = new SqlCommand("Insert into appointmentsTable (appointmentDate,appointmentTime,appointmentBranch,appointmentDoctor) values (@ap1,@ap2,@ap3,@ap4)",SqlCon.Connection);
                commandSave.Parameters.AddWithValue("@ap1",mskDate.Text.Trim());
                commandSave.Parameters.AddWithValue("@ap2",mskTime.Text.Trim());
                commandSave.Parameters.AddWithValue("@ap3",cmbBranch.Text.Trim());
                commandSave.Parameters.AddWithValue("@ap4",cmbDoctor.Text.Trim());
                commandSave.ExecuteReader();
                SqlCon.Connection.Close();
                MessageBox.Show(Message.appointmentSuccess);
            }
        }
        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select doctorName,doctorSurname From doctorsTable Where doctorBranch=@p1", SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            SqlCon.Connection.Close();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (rchAnnouncements.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the announcements");
                return;
            }
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Insert into announcementsTable (announcement) values(@an1)",SqlCon.Connection);
            command.Parameters.AddWithValue("@an1", rchAnnouncements.Text.Trim());
            command.ExecuteNonQuery();
            SqlCon.Connection.Close();
            MessageBox.Show(Message.Insert);
        }
        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            DoctorSPanelForm dcp = new DoctorSPanelForm();
            dcp.Show();
        }
        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            BranchForm frb = new BranchForm();
            frb.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AppointmentListForm fra = new AppointmentListForm();
            fra.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            AnnouncementsForm fra = new AnnouncementsForm();
            fra.Show();
        }
    }
}