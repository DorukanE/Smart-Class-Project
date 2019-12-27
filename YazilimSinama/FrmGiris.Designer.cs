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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdnBtnOgrenci
            // 
            this.rdnBtnOgrenci.AutoSize = true;
            this.rdnBtnOgrenci.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rdnBtnOgrenci.Location = new System.Drawing.Point(98, 178);
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
            this.rdnBtnOgretmen.Location = new System.Drawing.Point(333, 178);
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
            this.lblKullaniciAdi.Location = new System.Drawing.Point(60, 242);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(155, 19);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adını Giriniz:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSifre.Location = new System.Drawing.Point(60, 303);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(91, 19);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "Şifre Giriniz:";
            // 
            // btnGiris
            // 
            this.btnGiris.Highlight = true;
            this.btnGiris.Location = new System.Drawing.Point(216, 345);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(114, 43);
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "GİRİS";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBoxOgretmen
            // 
            this.pictureBoxOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgretmen.Image")));
            this.pictureBoxOgretmen.Location = new System.Drawing.Point(321, 74);
            this.pictureBoxOgretmen.Name = "pictureBoxOgretmen";
            this.pictureBoxOgretmen.Size = new System.Drawing.Size(140, 97);
            this.pictureBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgretmen.TabIndex = 1;
            this.pictureBoxOgretmen.TabStop = false;
            // 
            // pictureBoxOgrenci
            // 
            this.pictureBoxOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgrenci.Image")));
            this.pictureBoxOgrenci.Location = new System.Drawing.Point(75, 74);
            this.pictureBoxOgrenci.Name = "pictureBoxOgrenci";
            this.pictureBoxOgrenci.Size = new System.Drawing.Size(147, 97);
            this.pictureBoxOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgrenci.TabIndex = 0;
            this.pictureBoxOgrenci.TabStop = false;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(368, 240);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(142, 20);
            this.txtKullanici.TabIndex = 11;
            this.txtKullanici.TextChanged += new System.EventHandler(this.txtBoxKullanici_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(368, 302);
            this.txtSifre.MaxLength = 15;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(142, 22);
            this.txtSifre.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 425);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGiris_FormClosing);
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

