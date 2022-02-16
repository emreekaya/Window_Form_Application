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
    public partial class DoctorDetailForm : Form
    {
        public DoctorDetailForm()
        {
            InitializeComponent();
        }

        public string TC_No;
        private void DoctorDetailForm_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC_No;

            //Doctor Name Surname
            SqlCon.Connection.Open();
            SqlCommand command = new SqlCommand("Select doctorName,doctorSurname From doctorsTable Where doctorTC=@p1",SqlCon.Connection);
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr[0] + " " + dr[1];
            }
            SqlCon.Connection.Close();

            //Appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From appointmentsTable Where appointmentDoctor='" + lblName.Text + "'",SqlCon.Connection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DoctorInformationUpdateForm fr = new DoctorInformationUpdateForm();
            fr.TCNO = lblTC.Text;
            fr.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            AnnouncementsForm fr = new AnnouncementsForm();
            fr.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            rchComplaint.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
