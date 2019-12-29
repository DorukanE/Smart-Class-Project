namespace YazilimSinama
{
    partial class FrmOgretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmen));
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.groupBoxOgretmen = new System.Windows.Forms.GroupBox();
            this.btnSoruEkle = new MetroFramework.Controls.MetroButton();
            this.txtDogruCevap = new MetroFramework.Controls.MetroTextBox();
            this.txtSoru = new MetroFramework.Controls.MetroTextBox();
            this.txtKonu = new MetroFramework.Controls.MetroTextBox();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.pictureBoxOgretmen = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.groupBoxOgretmen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(712, 366);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(74, 61);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 8;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBoxOgretmen
            // 
            this.groupBoxOgretmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxOgretmen.Controls.Add(this.btnSoruEkle);
            this.groupBoxOgretmen.Controls.Add(this.txtDogruCevap);
            this.groupBoxOgretmen.Controls.Add(this.txtSoru);
            this.groupBoxOgretmen.Controls.Add(this.txtKonu);
            this.groupBoxOgretmen.Controls.Add(this.lblDogruCevap);
            this.groupBoxOgretmen.Controls.Add(this.lblKonu);
            this.groupBoxOgretmen.Controls.Add(this.lblSoru);
            this.groupBoxOgretmen.Location = new System.Drawing.Point(336, 130);
            this.groupBoxOgretmen.Name = "groupBoxOgretmen";
            this.groupBoxOgretmen.Size = new System.Drawing.Size(359, 273);
            this.groupBoxOgretmen.TabIndex = 9;
            this.groupBoxOgretmen.TabStop = false;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Highlight = true;
            this.btnSoruEkle.Location = new System.Drawing.Point(125, 210);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(91, 45);
            this.btnSoruEkle.TabIndex = 13;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click_1);
            // 
            // txtDogruCevap
            // 
            this.txtDogruCevap.Location = new System.Drawing.Point(157, 172);
            this.txtDogruCevap.Name = "txtDogruCevap";
            this.txtDogruCevap.Size = new System.Drawing.Size(163, 23);
            this.txtDogruCevap.TabIndex = 12;
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(153, 85);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(163, 65);
            this.txtSoru.TabIndex = 11;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(153, 29);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(167, 23);
            this.txtKonu.TabIndex = 10;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruCevap.Location = new System.Drawing.Point(11, 178);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(136, 17);
            this.lblDogruCevap.TabIndex = 9;
            this.lblDogruCevap.Text = "Doğru Cevap Giriniz:";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonu.Location = new System.Drawing.Point(11, 29);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(87, 17);
            this.lblKonu.TabIndex = 8;
            this.lblKonu.Text = "Konu Giriniz:";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(15, 85);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(83, 17);
            this.lblSoru.TabIndex = 7;
            this.lblSoru.Text = "Soru Giriniz:";
            // 
            // pictureBoxOgretmen
            // 
            this.pictureBoxOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgretmen.Image")));
            this.pictureBoxOgretmen.Location = new System.Drawing.Point(70, 130);
            this.pictureBoxOgretmen.Name = "pictureBoxOgretmen";
            this.pictureBoxOgretmen.Size = new System.Drawing.Size(246, 273);
            this.pictureBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgretmen.TabIndex = 10;
            this.pictureBoxOgretmen.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(253, 60);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(289, 40);
            this.lblBaslik.TabIndex = 11;
            this.lblBaslik.Text = "SORU EKLEME EKRANI";
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.pictureBoxOgretmen);
            this.Controls.Add(this.groupBoxOgretmen);
            this.Controls.Add(this.pictureBoxExit);
            this.Name = "FrmOgretmen";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.groupBoxOgretmen.ResumeLayout(false);
            this.groupBoxOgretmen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.GroupBox groupBoxOgretmen;
        private MetroFramework.Controls.MetroButton btnSoruEkle;
        private MetroFramework.Controls.MetroTextBox txtDogruCevap;
        private MetroFramework.Controls.MetroTextBox txtSoru;
        private MetroFramework.Controls.MetroTextBox txtKonu;
        private System.Windows.Forms.Label lblDogruCevap;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.PictureBox pictureBoxOgretmen;
        private System.Windows.Forms.Label lblBaslik;
    }
}