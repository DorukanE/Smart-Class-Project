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
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.txtKonu = new MetroFramework.Controls.MetroTextBox();
            this.txtSoru = new MetroFramework.Controls.MetroTextBox();
            this.txtDogruCevap = new MetroFramework.Controls.MetroTextBox();
            this.btnSoruEkle = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOgretmen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(368, 189);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(83, 17);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Soru Giriniz:";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonu.Location = new System.Drawing.Point(368, 147);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(87, 17);
            this.lblKonu.TabIndex = 1;
            this.lblKonu.Text = "Konu Giriniz:";
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruCevap.Location = new System.Drawing.Point(368, 240);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(136, 17);
            this.lblDogruCevap.TabIndex = 2;
            this.lblDogruCevap.Text = "Doğru Cevap Giriniz:";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(510, 147);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(75, 23);
            this.txtKonu.TabIndex = 3;
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(510, 189);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(75, 23);
            this.txtSoru.TabIndex = 4;
            // 
            // txtDogruCevap
            // 
            this.txtDogruCevap.Location = new System.Drawing.Point(510, 240);
            this.txtDogruCevap.Name = "txtDogruCevap";
            this.txtDogruCevap.Size = new System.Drawing.Size(75, 23);
            this.txtDogruCevap.TabIndex = 5;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Highlight = true;
            this.btnSoruEkle.Location = new System.Drawing.Point(413, 293);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(91, 45);
            this.btnSoruEkle.TabIndex = 6;
            this.btnSoruEkle.Text = "Soru Ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YazilimSinama.Properties.Resources._32210569_exit_icon;
            this.pictureBox1.Location = new System.Drawing.Point(712, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxOgretmen
            // 
            this.pictureBoxOgretmen.Image = global::YazilimSinama.Properties.Resources.hoca;
            this.pictureBoxOgretmen.Location = new System.Drawing.Point(90, 118);
            this.pictureBoxOgretmen.Name = "pictureBoxOgretmen";
            this.pictureBoxOgretmen.Size = new System.Drawing.Size(174, 191);
            this.pictureBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgretmen.TabIndex = 7;
            this.pictureBoxOgretmen.TabStop = false;
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxOgretmen);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.txtDogruCevap);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.lblSoru);
            this.Name = "FrmOgretmen";
            this.Text = "Öğretmen Girişi";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblDogruCevap;
        private MetroFramework.Controls.MetroTextBox txtKonu;
        private MetroFramework.Controls.MetroTextBox txtSoru;
        private MetroFramework.Controls.MetroTextBox txtDogruCevap;
        private MetroFramework.Controls.MetroButton btnSoruEkle;
        private System.Windows.Forms.PictureBox pictureBoxOgretmen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}