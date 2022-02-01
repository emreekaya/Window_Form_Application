
namespace Envanter_Uygulamasi
{
    partial class frmHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSirketler = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.companyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.envanterVeriTabaniDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.envanter_Veri_TabaniDataSet1 = new Envanter_Uygulamasi.Envanter_Veri_TabaniDataSet1();
            this.envanterVeriTabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.envanter_Veri_TabaniDataSet = new Envanter_Uygulamasi.Envanter_Veri_TabaniDataSet();
            this.btnSirketEkle = new System.Windows.Forms.Button();
            this.btnSirketGuncelle = new System.Windows.Forms.Button();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new Envanter_Uygulamasi.Envanter_Veri_TabaniDataSet1TableAdapters.CompanyTableAdapter();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniSirket = new System.Windows.Forms.TextBox();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInventories = new System.Windows.Forms.Button();
            this.companyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterVeriTabaniDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanter_Veri_TabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterVeriTabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanter_Veri_TabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSirketler
            // 
            this.btnSirketler.Location = new System.Drawing.Point(12, 12);
            this.btnSirketler.Name = "btnSirketler";
            this.btnSirketler.Size = new System.Drawing.Size(123, 36);
            this.btnSirketler.TabIndex = 2;
            this.btnSirketler.Text = "Companies";
            this.btnSirketler.UseVisualStyleBackColor = true;
            this.btnSirketler.Click += new System.EventHandler(this.btnSirketler_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(350, 138);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 36);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Delete";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // companyBindingSource2
            // 
            this.companyBindingSource2.DataMember = "Company";
            this.companyBindingSource2.DataSource = this.envanterVeriTabaniDataSet1BindingSource;
            // 
            // envanterVeriTabaniDataSet1BindingSource
            // 
            this.envanterVeriTabaniDataSet1BindingSource.DataSource = this.envanter_Veri_TabaniDataSet1;
            this.envanterVeriTabaniDataSet1BindingSource.Position = 0;
            // 
            // envanter_Veri_TabaniDataSet1
            // 
            this.envanter_Veri_TabaniDataSet1.DataSetName = "Envanter_Veri_TabaniDataSet1";
            this.envanter_Veri_TabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // envanterVeriTabaniDataSetBindingSource
            // 
            this.envanterVeriTabaniDataSetBindingSource.DataSource = this.envanter_Veri_TabaniDataSet;
            this.envanterVeriTabaniDataSetBindingSource.Position = 0;
            // 
            // envanter_Veri_TabaniDataSet
            // 
            this.envanter_Veri_TabaniDataSet.DataSetName = "Envanter_Veri_TabaniDataSet";
            this.envanter_Veri_TabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSirketEkle
            // 
            this.btnSirketEkle.Location = new System.Drawing.Point(350, 54);
            this.btnSirketEkle.Name = "btnSirketEkle";
            this.btnSirketEkle.Size = new System.Drawing.Size(110, 36);
            this.btnSirketEkle.TabIndex = 6;
            this.btnSirketEkle.Text = "Add";
            this.btnSirketEkle.UseVisualStyleBackColor = true;
            this.btnSirketEkle.Visible = false;
            this.btnSirketEkle.Click += new System.EventHandler(this.btnSirketEkle_Click_1);
            // 
            // btnSirketGuncelle
            // 
            this.btnSirketGuncelle.Location = new System.Drawing.Point(350, 96);
            this.btnSirketGuncelle.Name = "btnSirketGuncelle";
            this.btnSirketGuncelle.Size = new System.Drawing.Size(110, 36);
            this.btnSirketGuncelle.TabIndex = 7;
            this.btnSirketGuncelle.Text = "Update";
            this.btnSirketGuncelle.UseVisualStyleBackColor = true;
            this.btnSirketGuncelle.Visible = false;
            this.btnSirketGuncelle.Click += new System.EventHandler(this.btnSirketGuncelle_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.envanterVeriTabaniDataSet1BindingSource;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            this.companyBindingSource1.DataSource = this.envanterVeriTabaniDataSet1BindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Company Name:";
            this.label1.Visible = false;
            // 
            // txtYeniSirket
            // 
            this.txtYeniSirket.Location = new System.Drawing.Point(176, 180);
            this.txtYeniSirket.Name = "txtYeniSirket";
            this.txtYeniSirket.Size = new System.Drawing.Size(168, 34);
            this.txtYeniSirket.TabIndex = 10;
            this.txtYeniSirket.Visible = false;
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Location = new System.Drawing.Point(176, 220);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(100, 34);
            this.txtCompanyId.TabIndex = 11;
            this.txtCompanyId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Company ID:";
            this.label2.Visible = false;
            // 
            // btnInventories
            // 
            this.btnInventories.Location = new System.Drawing.Point(141, 12);
            this.btnInventories.Name = "btnInventories";
            this.btnInventories.Size = new System.Drawing.Size(123, 36);
            this.btnInventories.TabIndex = 13;
            this.btnInventories.Text = "Inventories";
            this.btnInventories.UseVisualStyleBackColor = true;
            this.btnInventories.Click += new System.EventHandler(this.btnInventories_Click);
            // 
            // companyBindingSource3
            // 
            this.companyBindingSource3.DataMember = "Company";
            this.companyBindingSource3.DataSource = this.envanterVeriTabaniDataSet1BindingSource;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(332, 120);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 319);
            this.Controls.Add(this.btnInventories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyId);
            this.Controls.Add(this.txtYeniSirket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSirketGuncelle);
            this.Controls.Add(this.btnSirketEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSirketler);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterVeriTabaniDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanter_Veri_TabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterVeriTabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanter_Veri_TabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnSirketler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSirketEkle;
        private System.Windows.Forms.Button btnSirketGuncelle;
        private System.Windows.Forms.BindingSource envanterVeriTabaniDataSetBindingSource;
        private Envanter_Veri_TabaniDataSet envanter_Veri_TabaniDataSet;
        private System.Windows.Forms.BindingSource envanterVeriTabaniDataSet1BindingSource;
        private Envanter_Veri_TabaniDataSet1 envanter_Veri_TabaniDataSet1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Envanter_Veri_TabaniDataSet1TableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource2;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniSirket;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInventories;
        private System.Windows.Forms.BindingSource companyBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}