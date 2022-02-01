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

namespace Envanter_Uygulamasi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
            label3.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
        }
        private System.Data.SqlClient.SqlConnection baglanti = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-DIF1517\\SQLEXPRESS01;Initial Catalog=Envanter_Veri_Tabani;Integrated Security=True");
        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.ForestGreen;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Cornsilk;
        }

        private void btnKaydol_MouseHover(object sender, EventArgs e)
        {
            btnKaydol.BackColor = Color.ForestGreen;
        }

        private void btnKaydol_MouseLeave(object sender, EventArgs e)
        {
            btnKaydol.BackColor = Color.Cornsilk;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Select * From [User] Where UserName=@k1 AND Password=@k2", baglanti);

           
                
                komut.Parameters.Add("@k1", SqlDbType.NVarChar).Value =  txtKullaniciAdi.Text;
                komut.Parameters.Add("@k2", SqlDbType.NVarChar).Value = txtParola.Text;

                var hasResult = false;
                var uName = "";
                var uPass = "";
                using (SqlDataReader rdr = komut.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        uName = rdr["UserName"].ToString();
                        uPass = rdr["Password"].ToString();
                        hasResult = true;
                    }

                }

                if (uName != txtKullaniciAdi.Text || uPass != txtParola.Text)
                    hasResult = false;

                if (hasResult)
                {
                    MessageBox.Show("Welcome " + uName);
                    frmHomePage fr = new frmHomePage();
                    fr.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
                baglanti.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void kullaniciOlustur_MouseHover(object sender, EventArgs e)
        {
            btnKullaniciOlustur.BackColor = Color.ForestGreen;
        }

        private void btnKullaniciOlustur_MouseLeave(object sender, EventArgs e)
        {
            btnKullaniciOlustur.BackColor = Color.Cornsilk;
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            txtKullaniciAdi.Text = "";
            txtParola.Text = "";
            txtKullaniciAdi.Enabled = false;
            txtParola.Enabled = false;
            txtAd.Focus();
        }

        private void btnKullaniciOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kullaniciEkle = new SqlCommand("insert into [User] (FirstName,LastName,UserName,Password) values (@a1,@a2,@a3,@a4)", baglanti);
            kullaniciEkle.Parameters.AddWithValue("@a1", txtAd.Text);
            kullaniciEkle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            kullaniciEkle.Parameters.AddWithValue("@a3", txtYeniKullaniciAd.Text);
            kullaniciEkle.Parameters.AddWithValue("@a4", txtYeniParola.Text);
            kullaniciEkle.ExecuteNonQuery();
            baglanti.Close();
            panel2.Visible = false;
            txtKullaniciAdi.Enabled = true;
            txtParola.Enabled = true;
            MessageBox.Show(Message.success);
            txtKullaniciAdi.Focus();
        }
    }
}
