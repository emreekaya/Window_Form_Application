using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMenüStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void interstellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=zSWdZVtXT7E&t=12s");
            label1.Visible = true;
            label1.Text = "Intersteller";
        }

        private void aykutEnişteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vSLqy50b0lE&t=3s");
            label1.Visible = true;
            label1.Text = "Aykut Enişte";
        }

        private void eliteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=QNwhAdrdwp0&t=5s");
            label1.Visible = true;
            label1.Text = "Elite";
        }

        private void blitzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=mhO2WJ3MNRI");
            label1.Visible = true;
            label1.Text = "Blitz";
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleVioletRed;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project developed by Emre Kaya","İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Founder:Emre Kaya\nNo: 0555 555 55 55\n","Contact İnformation", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
