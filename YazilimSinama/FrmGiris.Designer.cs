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
            this.rdnBtnOgrenci = new MetroFramework.Controls.MetroRadioButton();
            this.rdnBtnOgretmen = new MetroFramework.Controls.MetroRadioButton();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.pictureBoxOgretmen = new System.Windows.Forms.PictureBox();
            this.pictureBoxOgrenci = new System.Windows.Forms.PictureBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // rdnBtnOgrenci
            // 
            this.rdnBtnOgrenci.AutoSize = true;
            this.rdnBtnOgrenci.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rdnBtnOgrenci.Location = new System.Drawing.Point(218, 167);
            this.rdnBtnOgrenci.Name = "rdnBtnOgrenci";
            this.rdnBtnOgrenci.Size = new System.Drawing.Size(98, 15);
            this.rdnBtnOgrenci.TabIndex = 2;
            this.rdnBtnOgrenci.TabStop = true;
            this.rdnBtnOgrenci.Text = "Öğrenci Girişi";
            this.rdnBtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // rdnBtnOgretmen
            // 
            this.rdnBtnOgretmen.AutoSize = true;
            this.rdnBtnOgretmen.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rdnBtnOgretmen.Location = new System.Drawing.Point(453, 167);
            this.rdnBtnOgretmen.Name = "rdnBtnOgretmen";
            this.rdnBtnOgretmen.Size = new System.Drawing.Size(112, 15);
            this.rdnBtnOgretmen.TabIndex = 3;
            this.rdnBtnOgretmen.TabStop = true;
            this.rdnBtnOgretmen.Text = "Öğretmen Girişi";
            this.rdnBtnOgretmen.UseVisualStyleBackColor = true;
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
            // pictureBoxOgretmen
            // 
            this.pictureBoxOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgretmen.Image")));
            this.pictureBoxOgretmen.Location = new System.Drawing.Point(441, 63);
            this.pictureBoxOgretmen.Name = "pictureBoxOgretmen";
            this.pictureBoxOgretmen.Size = new System.Drawing.Size(140, 97);
            this.pictureBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgretmen.TabIndex = 1;
            this.pictureBoxOgretmen.TabStop = false;
            // 
            // pictureBoxOgrenci
            // 
            this.pictureBoxOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgrenci.Image")));
            this.pictureBoxOgrenci.Location = new System.Drawing.Point(195, 63);
            this.pictureBoxOgrenci.Name = "pictureBoxOgrenci";
            this.pictureBoxOgrenci.Size = new System.Drawing.Size(147, 97);
            this.pictureBoxOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgrenci.TabIndex = 0;
            this.pictureBoxOgrenci.TabStop = false;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(488, 229);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(142, 20);
            this.txtKullanici.TabIndex = 11;
            this.txtKullanici.TextChanged += new System.EventHandler(this.txtBoxKullanici_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(488, 291);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(142, 20);
            this.txtSifre.TabIndex = 12;
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.rdnBtnOgretmen);
            this.Controls.Add(this.rdnBtnOgrenci);
            this.Controls.Add(this.pictureBoxOgretmen);
            this.Controls.Add(this.pictureBoxOgrenci);
            this.Name = "FrmGiris";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOgrenci;
        private System.Windows.Forms.PictureBox pictureBoxOgretmen;
        private MetroFramework.Controls.MetroRadioButton rdnBtnOgrenci;
        private MetroFramework.Controls.MetroRadioButton rdnBtnOgretmen;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroLabel lblSifre;
        private MetroFramework.Controls.MetroButton btnGiris;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

