
namespace Envanter_Uygulamasi
{
    partial class FrmInventories
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
            this.cmbChooseCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInventoryType = new System.Windows.Forms.TextBox();
            this.txtInventoryName = new System.Windows.Forms.TextBox();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnDeleteInventory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.envanter_Veri_TabaniDataSet7 = new Envanter_Uygulamasi.Envanter_Veri_TabaniDataSet7();
            this.ınventoryTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTypeTableAdapter = new Envanter_Uygulamasi.Envanter_Veri_TabaniDataSet7TableAdapters.InventoryTypeTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInventoryId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanter_Veri_TabaniDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoryTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChooseCompany
            // 
            this.cmbChooseCompany.FormattingEnabled = true;
            this.cmbChooseCompany.Location = new System.Drawing.Point(178, 22);
            this.cmbChooseCompany.Name = "cmbChooseCompany";
            this.cmbChooseCompany.Size = new System.Drawing.Size(148, 36);
            this.cmbChooseCompany.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Company :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inventory Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inventory Name :";
            // 
            // txtInventoryType
            // 
            this.txtInventoryType.Location = new System.Drawing.Point(178, 75);
            this.txtInventoryType.Name = "txtInventoryType";
            this.txtInventoryType.Size = new System.Drawing.Size(148, 34);
            this.txtInventoryType.TabIndex = 4;
            // 
            // txtInventoryName
            // 
            this.txtInventoryName.Location = new System.Drawing.Point(178, 129);
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.Size = new System.Drawing.Size(148, 34);
            this.txtInventoryName.TabIndex = 5;
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(6, 179);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(97, 35);
            this.btnAddInventory.TabIndex = 6;
            this.btnAddInventory.Text = "Add";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Location = new System.Drawing.Point(118, 179);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(97, 35);
            this.btnUpdateInventory.TabIndex = 7;
            this.btnUpdateInventory.Text = "Update";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // btnDeleteInventory
            // 
            this.btnDeleteInventory.Location = new System.Drawing.Point(229, 179);
            this.btnDeleteInventory.Name = "btnDeleteInventory";
            this.btnDeleteInventory.Size = new System.Drawing.Size(97, 35);
            this.btnDeleteInventory.TabIndex = 8;
            this.btnDeleteInventory.Text = "Delete";
            this.btnDeleteInventory.UseVisualStyleBackColor = true;
            this.btnDeleteInventory.Click += new System.EventHandler(this.btnDeleteInventory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ınventoryTypeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(344, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 189);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // envanter_Veri_TabaniDataSet7
            // 
            this.envanter_Veri_TabaniDataSet7.DataSetName = "Envanter_Veri_TabaniDataSet7";
            this.envanter_Veri_TabaniDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ınventoryTypeBindingSource
            // 
            this.ınventoryTypeBindingSource.DataMember = "InventoryType";
            this.ınventoryTypeBindingSource.DataSource = this.envanter_Veri_TabaniDataSet7;
            // 
            // inventoryTypeTableAdapter
            // 
            this.inventoryTypeTableAdapter.ClearBeforeFill = true;
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
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // txtInventoryId
            // 
            this.txtInventoryId.Location = new System.Drawing.Point(6, 234);
            this.txtInventoryId.Name = "txtInventoryId";
            this.txtInventoryId.Size = new System.Drawing.Size(100, 34);
            this.txtInventoryId.TabIndex = 10;
            this.txtInventoryId.Visible = false;
            // 
            // FrmInventories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 225);
            this.Controls.Add(this.txtInventoryId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteInventory);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.txtInventoryName);
            this.Controls.Add(this.txtInventoryType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChooseCompany);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInventories";
            this.Load += new System.EventHandler(this.FrmInventories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanter_Veri_TabaniDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoryTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInventoryType;
        private System.Windows.Forms.TextBox txtInventoryName;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Button btnDeleteInventory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Envanter_Veri_TabaniDataSet7 envanter_Veri_TabaniDataSet7;
        private System.Windows.Forms.BindingSource ınventoryTypeBindingSource;
        private Envanter_Veri_TabaniDataSet7TableAdapters.InventoryTypeTableAdapter inventoryTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtInventoryId;
    }
}