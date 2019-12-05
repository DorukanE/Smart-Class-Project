namespace YazilimSinama
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.rdnbtnogrenci = new MetroFramework.Controls.MetroRadioButton();
            this.rdnbtnogretmen = new MetroFramework.Controls.MetroRadioButton();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.txtKullanici = new MetroFramework.Controls.MetroTextBox();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdnbtnogrenci
            // 
            this.rdnbtnogrenci.AutoSize = true;
            this.rdnbtnogrenci.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rdnbtnogrenci.Location = new System.Drawing.Point(218, 167);
            this.rdnbtnogrenci.Name = "rdnbtnogrenci";
            this.rdnbtnogrenci.Size = new System.Drawing.Size(98, 15);
            this.rdnbtnogrenci.TabIndex = 2;
            this.rdnbtnogrenci.TabStop = true;
            this.rdnbtnogrenci.Text = "Öğrenci Girişi";
            this.rdnbtnogrenci.UseVisualStyleBackColor = true;
            this.rdnbtnogrenci.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // rdnbtnogretmen
            // 
            this.rdnbtnogretmen.AutoSize = true;
            this.rdnbtnogretmen.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rdnbtnogretmen.Location = new System.Drawing.Point(453, 167);
            this.rdnbtnogretmen.Name = "rdnbtnogretmen";
            this.rdnbtnogretmen.Size = new System.Drawing.Size(112, 15);
            this.rdnbtnogretmen.TabIndex = 3;
            this.rdnbtnogretmen.TabStop = true;
            this.rdnbtnogretmen.Text = "Öğretmen Girişi";
            this.rdnbtnogretmen.UseVisualStyleBackColor = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(180, 231);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(155, 19);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adını Giriniz:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(394, 231);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(150, 23);
            this.txtKullanici.TabIndex = 6;
            this.txtKullanici.Click += new System.EventHandler(this.txtKullanici_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSifre.Location = new System.Drawing.Point(180, 292);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(91, 19);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "Şifre Giriniz:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(394, 288);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(150, 23);
            this.txtSifre.TabIndex = 9;
            // 
            // btnGiris
            // 
            this.btnGiris.Highlight = true;
            this.btnGiris.Location = new System.Drawing.Point(336, 346);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(84, 28);
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "GİRİS";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.rdnbtnogretmen);
            this.Controls.Add(this.rdnbtnogrenci);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmGiris";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroRadioButton rdnbtnogrenci;
        private MetroFramework.Controls.MetroRadioButton rdnbtnogretmen;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtKullanici;
        private MetroFramework.Controls.MetroLabel lblSifre;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroButton btnGiris;
    }
}

