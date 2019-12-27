namespace YazilimSinama
{
    partial class FrmSinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinav));
            this.lblSayac = new MetroFramework.Controls.MetroLabel();
            this.timersure = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.btnSinavaBasla = new MetroFramework.Controls.MetroButton();
            this.btnAsecenegi = new MetroFramework.Controls.MetroButton();
            this.btnBsecenegi = new MetroFramework.Controls.MetroButton();
            this.btnCsecenegi = new MetroFramework.Controls.MetroButton();
            this.btnDsecenegi = new MetroFramework.Controls.MetroButton();
            this.SürePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoruMetni = new MetroFramework.Controls.MetroLabel();
            this.btnSinaviBitir = new MetroFramework.Controls.MetroButton();
            this.btnIstatistigiGoster = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SürePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSayac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSayac.Location = new System.Drawing.Point(721, 30);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(32, 25);
            this.lblSayac.TabIndex = 11;
            this.lblSayac.Text = "60";
            this.lblSayac.Click += new System.EventHandler(this.lblSayac_Click);
            // 
            // timersure
            // 
            this.timersure.Enabled = true;
            this.timersure.Interval = 1000;
            this.timersure.Tick += new System.EventHandler(this.timersure_Tick);
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Image = global::YazilimSinama.Properties.Resources.alarm__clock__time__alert__bell__alarmicon__firealarm__siren_512;
            this.pictureBoxClock.Location = new System.Drawing.Point(679, 30);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(33, 25);
            this.pictureBoxClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClock.TabIndex = 12;
            this.pictureBoxClock.TabStop = false;
            // 
            // btnSinavaBasla
            // 
            this.btnSinavaBasla.Location = new System.Drawing.Point(240, 372);
            this.btnSinavaBasla.Name = "btnSinavaBasla";
            this.btnSinavaBasla.Size = new System.Drawing.Size(111, 55);
            this.btnSinavaBasla.TabIndex = 25;
            this.btnSinavaBasla.Text = "Sınava Başla";
            this.btnSinavaBasla.Click += new System.EventHandler(this.btnSinavaBasla_Click);
            // 
            // btnAsecenegi
            // 
            this.btnAsecenegi.Location = new System.Drawing.Point(261, 190);
            this.btnAsecenegi.Name = "btnAsecenegi";
            this.btnAsecenegi.Size = new System.Drawing.Size(135, 52);
            this.btnAsecenegi.TabIndex = 26;
            this.btnAsecenegi.Click += new System.EventHandler(this.btnAsecenegi_Click);
            this.btnAsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // btnBsecenegi
            // 
            this.btnBsecenegi.Location = new System.Drawing.Point(485, 190);
            this.btnBsecenegi.Name = "btnBsecenegi";
            this.btnBsecenegi.Size = new System.Drawing.Size(139, 52);
            this.btnBsecenegi.TabIndex = 27;
            this.btnBsecenegi.Click += new System.EventHandler(this.btnBsecenegi_Click);
            this.btnBsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // btnCsecenegi
            // 
            this.btnCsecenegi.Location = new System.Drawing.Point(261, 288);
            this.btnCsecenegi.Name = "btnCsecenegi";
            this.btnCsecenegi.Size = new System.Drawing.Size(135, 48);
            this.btnCsecenegi.TabIndex = 28;
            this.btnCsecenegi.Click += new System.EventHandler(this.btnCsecenegi_Click);
            this.btnCsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // btnDsecenegi
            // 
            this.btnDsecenegi.Location = new System.Drawing.Point(489, 288);
            this.btnDsecenegi.Name = "btnDsecenegi";
            this.btnDsecenegi.Size = new System.Drawing.Size(135, 48);
            this.btnDsecenegi.TabIndex = 29;
            this.btnDsecenegi.Click += new System.EventHandler(this.btnDsecenegi_Click);
            this.btnDsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // SürePictureBox
            // 
            this.SürePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SürePictureBox.Image")));
            this.SürePictureBox.Location = new System.Drawing.Point(44, 190);
            this.SürePictureBox.Name = "SürePictureBox";
            this.SürePictureBox.Size = new System.Drawing.Size(177, 199);
            this.SürePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SürePictureBox.TabIndex = 30;
            this.SürePictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSoruMetni
            // 
            this.lblSoruMetni.BackColor = System.Drawing.Color.White;
            this.lblSoruMetni.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSoruMetni.Location = new System.Drawing.Point(23, 93);
            this.lblSoruMetni.Name = "lblSoruMetni";
            this.lblSoruMetni.Size = new System.Drawing.Size(753, 75);
            this.lblSoruMetni.TabIndex = 33;
            this.lblSoruMetni.Click += new System.EventHandler(this.lblSoruMetni_Click);
            // 
            // btnSinaviBitir
            // 
            this.btnSinaviBitir.Location = new System.Drawing.Point(382, 372);
            this.btnSinaviBitir.Name = "btnSinaviBitir";
            this.btnSinaviBitir.Size = new System.Drawing.Size(111, 55);
            this.btnSinaviBitir.TabIndex = 34;
            this.btnSinaviBitir.Text = "Sınavı Bitir";
            this.btnSinaviBitir.Click += new System.EventHandler(this.btnSinaviBitir_Click);
            // 
            // btnIstatistigiGoster
            // 
            this.btnIstatistigiGoster.Location = new System.Drawing.Point(526, 372);
            this.btnIstatistigiGoster.Name = "btnIstatistigiGoster";
            this.btnIstatistigiGoster.Size = new System.Drawing.Size(111, 55);
            this.btnIstatistigiGoster.TabIndex = 35;
            this.btnIstatistigiGoster.Text = "İstatistiği Göster";
            this.btnIstatistigiGoster.Click += new System.EventHandler(this.btnIstatistigiGoster_Click);
            // 
            // FrmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 467);
            this.Controls.Add(this.btnIstatistigiGoster);
            this.Controls.Add(this.btnSinaviBitir);
            this.Controls.Add(this.lblSoruMetni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SürePictureBox);
            this.Controls.Add(this.btnDsecenegi);
            this.Controls.Add(this.btnCsecenegi);
            this.Controls.Add(this.btnBsecenegi);
            this.Controls.Add(this.btnAsecenegi);
            this.Controls.Add(this.btnSinavaBasla);
            this.Controls.Add(this.pictureBoxClock);
            this.Controls.Add(this.lblSayac);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "FrmSinav";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Sınav Olma Ekranı";
            this.Load += new System.EventHandler(this.FrmSinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SürePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblSayac;
        private System.Windows.Forms.Timer timersure;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private MetroFramework.Controls.MetroButton btnSinavaBasla;
        private MetroFramework.Controls.MetroButton btnAsecenegi;
        private MetroFramework.Controls.MetroButton btnBsecenegi;
        private MetroFramework.Controls.MetroButton btnCsecenegi;
        private MetroFramework.Controls.MetroButton btnDsecenegi;
        private System.Windows.Forms.PictureBox SürePictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblSoruMetni;
        private MetroFramework.Controls.MetroButton btnSinaviBitir;
        private MetroFramework.Controls.MetroButton btnIstatistigiGoster;
    }
}