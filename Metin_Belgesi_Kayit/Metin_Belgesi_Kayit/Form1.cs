using System;
using System.IO;
using System.Windows.Forms;

namespace Metin_Belgesi_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları |*txt";
            saveFileDialog1.Title = "Metin Belgesi Kayıt";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Kayıt Oluşturuldu");
        }
    }
}
