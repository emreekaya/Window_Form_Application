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
    public partial class AppointmentListForm : Form
    {
        public AppointmentListForm()
        {
            InitializeComponent();
        }
        private void AppointmentListForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From appointmentsTable", SqlCon.Connection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
