
namespace Envanter_Uygulamasi
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYeniKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtYeniParola = new System.Windows.Forms.TextBox();
            this.btnKullaniciOlustur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.Info;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(181, 19);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(196, 34);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.SystemColors.Info;
            this.txtParola.Location = new System.Drawing.Point(181, 68);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(196, 34);
            this.txtParola.TabIndex = 3;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory App Entry system";
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackColor = System.Drawing.SystemColors.Info;
            this.btnKaydol.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydol.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydol.Location = new System.Drawing.Point(181, 123);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(95, 40);
            this.btnKaydol.TabIndex = 5;
            this.btnKaydol.Text = "Sign up";
            this.btnKaydol.UseVisualStyleBackColor = false;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            this.btnKaydol.MouseLeave += new System.EventHandler(this.btnKaydol_MouseLeave);
            this.btnKaydol.MouseHover += new System.EventHandler(this.btnKaydol_MouseHover);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.Info;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiris.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGiris.Location = new System.Drawing.Point(282, 123);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(95, 40);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Login";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            this.btnGiris.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            this.btnGiris.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name/Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(49, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(54, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password :";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.Info;
            this.txtAd.Location = new System.Drawing.Point(183, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(94, 34);
            this.txtAd.TabIndex = 10;
            // 
            // txtYeniKullaniciAd
            // 
            this.txtYeniKullaniciAd.BackColor = System.Drawing.SystemColors.Info;
            this.txtYeniKullaniciAd.Location = new System.Drawing.Point(181, 48);
            this.txtYeniKullaniciAd.Name = "txtYeniKullaniciAd";
            this.txtYeniKullaniciAd.Size = new System.Drawing.Size(196, 34);
            this.txtYeniKullaniciAd.TabIndex = 11;
            // 
            // txtYeniParola
            // 
            this.txtYeniParola.BackColor = System.Drawing.SystemColors.Info;
            this.txtYeniParola.Location = new System.Drawing.Point(181, 90);
            this.txtYeniParola.Name = "txtYeniParola";
            this.txtYeniParola.Size = new System.Drawing.Size(196, 34);
            this.txtYeniParola.TabIndex = 12;
            // 
            // btnKullaniciOlustur
            // 
            this.btnKullaniciOlustur.BackColor = System.Drawing.SystemColors.Info;
            this.btnKullaniciOlustur.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciOlustur.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnKullaniciOlustur.Location = new System.Drawing.Point(282, 129);
            this.btnKullaniciOlustur.Name = "btnKullaniciOlustur";
            this.btnKullaniciOlustur.Size = new System.Drawing.Size(95, 38);
            this.btnKullaniciOlustur.TabIndex = 13;
            this.btnKullaniciOlustur.Text = "Create";
            this.btnKullaniciOlustur.UseVisualStyleBackColor = false;
            this.btnKullaniciOlustur.Click += new System.EventHandler(this.btnKullaniciOlustur_Click);
            this.btnKullaniciOlustur.MouseLeave += new System.EventHandler(this.btnKullaniciOlustur_MouseLeave);
            this.btnKullaniciOlustur.MouseHover += new System.EventHandler(this.kullaniciOlustur_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtParola);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnKaydol);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Location = new System.Drawing.Point(175, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 172);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSoyad);
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtYeniKullaniciAd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnKullaniciOlustur);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtYeniParola);
            this.panel2.Location = new System.Drawing.Point(175, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 170);
            this.panel2.TabIndex = 18;
            this.panel2.Visible = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoyad.Location = new System.Drawing.Point(283, 6);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(94, 34);
            this.txtSoyad.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "Giriş Paneli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYeniKullaniciAd;
        private System.Windows.Forms.TextBox txtYeniParola;
        private System.Windows.Forms.Button btnKullaniciOlustur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}

