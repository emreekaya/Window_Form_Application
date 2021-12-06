using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Uçuş_Rezervasyon_Sistemi : Form
    {
        public Uçuş_Rezervasyon_Sistemi()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: "+comboBox1.Text+" "+comboBox2.Text+" Tarih: "+dateTimePicker1.Text+" Saat: "+maskedTextBox2.Text+" Yolcu Bilgileri ~ Ad: "+textBox1.Text+" TC: "+maskedTextBox3.Text+" Telefon: "+maskedTextBox4.Text);
            MessageBox.Show("Yolcu Kaydı yapıldı\nİyi uçuşlar :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
