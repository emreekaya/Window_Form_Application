using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
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
        string dosyaAdi;
        private void button1_Click(object sender, EventArgs e)
        {
            dosyaAdi = textBox1.Text;

            Directory.CreateDirectory(@"C:\Users\Emre\Desktop\Udemy Dersleri\Ödev2\"+dosyaAdi);

            klasörler.Items.Add(dosyaAdi);
        }
    }
}
