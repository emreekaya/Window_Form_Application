using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int kasatutari= 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir = txtmisir.Text=="" ? misir=0 : Convert.ToInt16(txtmisir.Text);
            int su = txtsu.Text == "" ? su = 0 : Convert.ToInt16(txtsu.Text);
            int cay = txtcay.Text == "" ? cay = 0 : Convert.ToInt16(txtcay.Text);
            int bilet = txtbilet.Text == "" ? bilet = 0 : Convert.ToInt16(txtbilet.Text);

            int toplam = misir * 8 + su * 2 + cay * 3 + bilet * 15;
            lbltoplam.Text = toplam.ToString()+ " TL";
            kasatutari = kasatutari + toplam;
            lblkasa.Text = kasatutari.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbltoplam.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtcay.Text = "";
            txtbilet.Text = "";
            txtmisir.Focus();
        }
    }
}
