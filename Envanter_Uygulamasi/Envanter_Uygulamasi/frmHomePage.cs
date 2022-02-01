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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }
       
        //private SqlSqlConnection SqlCon.baglanti = new SqlSqlConnection("Data Source=DESKTOP-DIF1517\\SQLEXPRESS01;Initial Catalog=Envanter_Veri_Tabani;Integrated Security=True");
        private void btnSirketler_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnSil.Visible = true;
            btnSirketEkle.Visible = true;
            btnSirketGuncelle.Visible = true;
            txtYeniSirket.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            txtCompanyId.Visible = true;
            txtCompanyId.Enabled = false;
        }
        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Fill(this.envanter_Veri_TabaniDataSet1.Company);
        }
        private void btnSirketEkle_Click_1(object sender, EventArgs e)
        {

            SqlCon.baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Company (Name) values(@p1)", SqlCon.baglanti);

            komut.Parameters.AddWithValue("@p1", txtYeniSirket.Text);

            komut.ExecuteNonQuery();
            this.companyTableAdapter.Fill(this.envanter_Veri_TabaniDataSet1.Company);
            SqlCon.baglanti.Close();

            MessageBox.Show("Company "+Message.insert);
            txtYeniSirket.Text = "";

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCon.baglanti.Open();
            SqlCommand deleteCompany = new SqlCommand("Delete from Company Where Id=@delete", SqlCon.baglanti);
            deleteCompany.Parameters.AddWithValue("@delete", txtCompanyId.Text);
            deleteCompany.ExecuteNonQuery();
            this.companyTableAdapter.Fill(this.envanter_Veri_TabaniDataSet1.Company);
            SqlCon.baglanti.Close();
            txtCompanyId.Text = "";
            txtYeniSirket.Text = "";
            MessageBox.Show("Company " + Message.delete);

        }


        private void btnSirketGuncelle_Click(object sender, EventArgs e)
        {
            SqlCon.baglanti.Open();

            SqlCommand companyUpdate = new SqlCommand("Update Company Set Name=@s1 where Id=@s2", SqlCon.baglanti);
            companyUpdate.Parameters.AddWithValue("@s1", txtYeniSirket.Text);
            companyUpdate.Parameters.AddWithValue("@s2", txtCompanyId.Text);
            companyUpdate.ExecuteNonQuery();
            this.companyTableAdapter.Fill(this.envanter_Veri_TabaniDataSet1.Company);
            SqlCon.baglanti.Close();
            MessageBox.Show("Company information"+Message.update);
        }

        private void btnInventories_Click(object sender, EventArgs e)
        {
            FrmInventories fr = new FrmInventories();
            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtCompanyId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtYeniSirket.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }
    }
}
