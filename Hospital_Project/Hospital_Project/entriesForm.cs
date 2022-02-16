using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class EntriesForm : Form
    {
        public EntriesForm()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.ForestGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.ForestGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.ForestGreen;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void btnPatientAdmission_Click(object sender, EventArgs e)
        {
            PatientEntranceForm fr = new PatientEntranceForm();
            fr.Show();
            this.Hide();
        }

        private void btnDoctorAdmission_Click(object sender, EventArgs e)
        {
            DoctorEntranceForm fr = new DoctorEntranceForm();
            fr.Show();
            this.Hide();
        }

        private void btnSecretaryAdmission_Click(object sender, EventArgs e)
        {
            SecretaryEntranceForm fr = new SecretaryEntranceForm();
            fr.Show();
            this.Hide();
        }
    }
}
