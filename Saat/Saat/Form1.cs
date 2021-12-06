using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat, dakika, saniye = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.Contains(":") == true) Default olarak true olmasına bakıyor. 
            if (textBox1.Text.Contains(":"))
            {
                var time = textBox1.Text.Split(':');
                
                saat = Convert.ToInt32(time[0]);
                dakika = Convert.ToInt32(time[1]);


                if (dakika >= 60 || dakika < 0 || saat < 0 || saat >= 24)
                {
                    timer1.Stop();
                    MessageBox.Show("Geçerli saat ve dakika aralığı giriniz.");
                }
                else
                {
                    label2.Text = dakika.ToString();
                    label3.Text = saat.ToString();
                    timer1.Start();
                    groupBox1.Visible = true;
                }
                label1.Text = saniye.ToString();

            }
            else
            {
                MessageBox.Show("Geçerli saat formatı giriniz (Örn: 18:56)");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                label1.Text = saniye.ToString();
                if (dakika == 60)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;
                    label2.Text = dakika.ToString();
                    if (saat == 24)
                    {
                        saat = 0;
                        label3.Text = saat.ToString();
                    }
                }
            }
        }
    }
}