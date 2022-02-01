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
    public partial class FrmInventories : Form
    {
        public FrmInventories()
        {
            InitializeComponent();
        }
        private void FrmInventories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'envanter_Veri_TabaniDataSet7.InventoryType' table. You can move, or remove it, as needed.
            this.inventoryTypeTableAdapter.Fill(this.envanter_Veri_TabaniDataSet7.InventoryType);

            SqlCommand show = new SqlCommand("Select * from Company", SqlCon.baglanti);

            SqlDataReader dr;
            SqlCon.baglanti.Open();
            dr = show.ExecuteReader();
            while (dr.Read())
            {
                cmbChooseCompany.Items.Add(dr["Name"]);
            }
            SqlCon.baglanti.Close();
        }
        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            SqlCon.baglanti.Open();
            SqlCommand addInventory = new SqlCommand("Insert into InventoryType (type,name) values (@i1,@i2)", SqlCon.baglanti);

            addInventory.Parameters.AddWithValue("@i1", txtInventoryType.Text);
            addInventory.Parameters.AddWithValue("@i2", txtInventoryName.Text);
            addInventory.ExecuteNonQuery();
            this.inventoryTypeTableAdapter.Fill(this.envanter_Veri_TabaniDataSet7.InventoryType);
            SqlCon.baglanti.Close();
            txtInventoryName.Text = "";
            txtInventoryType.Text = "";
            MessageBox.Show(Message.success);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _selected = dataGridView1.SelectedCells[0].RowIndex;
            txtInventoryId.Text = dataGridView1.Rows[_selected].Cells[0].Value.ToString();
            txtInventoryType.Text = dataGridView1.Rows[_selected].Cells[1].Value.ToString();
            txtInventoryName.Text = dataGridView1.Rows[_selected].Cells[2].Value.ToString();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            SqlCon.baglanti.Open();
            SqlCommand updateInventory = new SqlCommand("Update InventoryType Set Type=@i1,Name=@i2 Where Id=@i3", SqlCon.baglanti);
            updateInventory.Parameters.AddWithValue("@i1", txtInventoryType.Text);
            updateInventory.Parameters.AddWithValue("@i2", txtInventoryName.Text);
            updateInventory.Parameters.AddWithValue("@i3", txtInventoryId.Text);
            updateInventory.ExecuteNonQuery();
            this.inventoryTypeTableAdapter.Fill(this.envanter_Veri_TabaniDataSet7.InventoryType);
            SqlCon.baglanti.Close();
            MessageBox.Show(Message.update);
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            SqlCon.baglanti.Open();
            SqlCommand deleteInventory = new SqlCommand("Delete From InventoryType Where Id=@_delete", SqlCon.baglanti);
            deleteInventory.Parameters.AddWithValue("@_delete", txtInventoryId.Text);
            deleteInventory.ExecuteNonQuery();
            this.inventoryTypeTableAdapter.Fill(this.envanter_Veri_TabaniDataSet7.InventoryType);
            SqlCon.baglanti.Close();
            txtInventoryType.Text = "";
            txtInventoryName.Text = "";
            MessageBox.Show(Message.delete);
        }
    }
}
