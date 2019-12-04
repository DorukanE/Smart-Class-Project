namespace Yazılım_Test_Ve_Sınama
{
    partial class frmGiris
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
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.txtKullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdnBtnOgretmen = new MetroFramework.Controls.MetroRadioButton();
            this.rdnBtnOgrenci = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Highlight = true;
            this.btnGiris.Location = new System.Drawing.Point(349, 312);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 23);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSifre.Location = new System.Drawing.Point(274, 260);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(91, 19);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre Giriniz:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(222, 212);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(143, 19);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı Giriniz:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(420, 212);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(135, 23);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(420, 256);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(135, 23);
            this.txtSifre.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(232, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(395, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // rdnBtnOgretmen
            // 
            this.rdnBtnOgretmen.AutoSize = true;
            this.rdnBtnOgretmen.Location = new System.Drawing.Point(232, 140);
            this.rdnBtnOgretmen.Name = "rdnBtnOgretmen";
            this.rdnBtnOgretmen.Size = new System.Drawing.Size(106, 15);
            this.rdnBtnOgretmen.TabIndex = 8;
            this.rdnBtnOgretmen.TabStop = true;
            this.rdnBtnOgretmen.Text = "Öğretmen Girişi";
            this.rdnBtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // rdnBtnOgrenci
            // 
            this.rdnBtnOgrenci.AutoSize = true;
            this.rdnBtnOgrenci.Location = new System.Drawing.Point(420, 140);
            this.rdnBtnOgrenci.Name = "rdnBtnOgrenci";
            this.rdnBtnOgrenci.Size = new System.Drawing.Size(94, 15);
            this.rdnBtnOgrenci.TabIndex = 9;
            this.rdnBtnOgrenci.TabStop = true;
            this.rdnBtnOgrenci.Text = "Öğrenci Girişi";
            this.rdnBtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdnBtnOgrenci);
            this.Controls.Add(this.rdnBtnOgretmen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnGiris);
            this.Name = "frmGiris";
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGiris;
        private MetroFramework.Controls.MetroLabel lblSifre;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroRadioButton rdnBtnOgretmen;
        private MetroFramework.Controls.MetroRadioButton rdnBtnOgrenci;
    }
}

