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
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.pictureBoxOgretmen = new System.Windows.Forms.PictureBox();
            this.pictureBoxOgrenci = new System.Windows.Forms.PictureBox();
            this.pictureBoxCikis = new System.Windows.Forms.PictureBox();
            this.groupBoxgiris = new System.Windows.Forms.GroupBox();
            this.rdnBtnOgretmen = new MetroFramework.Controls.MetroRadioButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.rdnBtnOgrenci = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCikis)).BeginInit();
            this.groupBoxgiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(138, 123);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(114, 43);
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "GİRİS";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBoxOgretmen
            // 
            this.pictureBoxOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgretmen.Image")));
            this.pictureBoxOgretmen.Location = new System.Drawing.Point(321, 63);
            this.pictureBoxOgretmen.Name = "pictureBoxOgretmen";
            this.pictureBoxOgretmen.Size = new System.Drawing.Size(140, 126);
            this.pictureBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgretmen.TabIndex = 1;
            this.pictureBoxOgretmen.TabStop = false;
            // 
            // pictureBoxOgrenci
            // 
            this.pictureBoxOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgrenci.Image")));
            this.pictureBoxOgrenci.Location = new System.Drawing.Point(105, 63);
            this.pictureBoxOgrenci.Name = "pictureBoxOgrenci";
            this.pictureBoxOgrenci.Size = new System.Drawing.Size(147, 126);
            this.pictureBoxOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgrenci.TabIndex = 0;
            this.pictureBoxOgrenci.TabStop = false;
            // 
            // pictureBoxCikis
            // 
            this.pictureBoxCikis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCikis.Image")));
            this.pictureBoxCikis.Location = new System.Drawing.Point(501, 365);
            this.pictureBoxCikis.Name = "pictureBoxCikis";
            this.pictureBoxCikis.Size = new System.Drawing.Size(66, 51);
            this.pictureBoxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCikis.TabIndex = 13;
            this.pictureBoxCikis.TabStop = false;
            this.pictureBoxCikis.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBoxgiris
            // 
            this.groupBoxgiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBoxgiris.Controls.Add(this.rdnBtnOgretmen);
            this.groupBoxgiris.Controls.Add(this.txtSifre);
            this.groupBoxgiris.Controls.Add(this.txtKullanici);
            this.groupBoxgiris.Controls.Add(this.btnGiris);
            this.groupBoxgiris.Controls.Add(this.lblSifre);
            this.groupBoxgiris.Controls.Add(this.lblKullaniciAdi);
            this.groupBoxgiris.Location = new System.Drawing.Point(76, 217);
            this.groupBoxgiris.Name = "groupBoxgiris";
            this.groupBoxgiris.Size = new System.Drawing.Size(397, 172);
            this.groupBoxgiris.TabIndex = 14;
            this.groupBoxgiris.TabStop = false;
            // 
            // rdnBtnOgretmen
            // 
            this.rdnBtnOgretmen.AutoSize = true;
            this.rdnBtnOgretmen.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rdnBtnOgretmen.Location = new System.Drawing.Point(267, 0);
            this.rdnBtnOgretmen.Name = "rdnBtnOgretmen";
            this.rdnBtnOgretmen.Size = new System.Drawing.Size(112, 15);
            this.rdnBtnOgretmen.TabIndex = 16;
            this.rdnBtnOgretmen.TabStop = true;
            this.rdnBtnOgretmen.Text = "Öğretmen Girişi";
            this.rdnBtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(194, 77);
            this.txtSifre.MaxLength = 15;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(142, 22);
            this.txtSifre.TabIndex = 16;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(194, 41);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(142, 20);
            this.txtKullanici.TabIndex = 15;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSifre.Location = new System.Drawing.Point(11, 77);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(91, 19);
            this.lblSifre.TabIndex = 14;
            this.lblSifre.Text = "Şifre Giriniz:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(11, 41);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(155, 19);
            this.lblKullaniciAdi.TabIndex = 13;
            this.lblKullaniciAdi.Text = "Kullanıcı Adını Giriniz:";
            // 
            // rdnBtnOgrenci
            // 
            this.rdnBtnOgrenci.AutoSize = true;
            this.rdnBtnOgrenci.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rdnBtnOgrenci.Location = new System.Drawing.Point(129, 217);
            this.rdnBtnOgrenci.Name = "rdnBtnOgrenci";
            this.rdnBtnOgrenci.Size = new System.Drawing.Size(98, 15);
            this.rdnBtnOgrenci.TabIndex = 15;
            this.rdnBtnOgrenci.TabStop = true;
            this.rdnBtnOgrenci.Text = "Öğrenci Girişi";
            this.rdnBtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 425);
            this.ControlBox = false;
            this.Controls.Add(this.rdnBtnOgrenci);
            this.Controls.Add(this.groupBoxgiris);
            this.Controls.Add(this.pictureBoxCikis);
            this.Controls.Add(this.pictureBoxOgretmen);
            this.Controls.Add(this.pictureBoxOgrenci);
            this.Name = "FrmGiris";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.Text = "Akıllı Sınıf Uygulaması";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGiris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCikis)).EndInit();
            this.groupBoxgiris.ResumeLayout(false);
            this.groupBoxgiris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOgrenci;
        private System.Windows.Forms.PictureBox pictureBoxOgretmen;
        private MetroFramework.Controls.MetroButton btnGiris;
        private System.Windows.Forms.PictureBox pictureBoxCikis;
        private System.Windows.Forms.GroupBox groupBoxgiris;
        private MetroFramework.Controls.MetroRadioButton rdnBtnOgretmen;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private MetroFramework.Controls.MetroLabel lblSifre;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroRadioButton rdnBtnOgrenci;
    }
}

