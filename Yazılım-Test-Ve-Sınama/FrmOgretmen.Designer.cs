namespace Yazılım_Test_Ve_Sınama
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
            this.lblSoru = new MetroFramework.Controls.MetroLabel();
            this.lblKonu = new MetroFramework.Controls.MetroLabel();
            this.lblDogruCevap = new MetroFramework.Controls.MetroLabel();
            this.txtSoru = new MetroFramework.Controls.MetroTextBox();
            this.txtKonu = new MetroFramework.Controls.MetroTextBox();
            this.txtDogruCevap = new MetroFramework.Controls.MetroTextBox();
            this.btnSoruEkle = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(117, 167);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(91, 19);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Soruyu giriniz:";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(117, 99);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(93, 19);
            this.lblKonu.TabIndex = 1;
            this.lblKonu.Text = "Konuyu giriniz:";
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(117, 222);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(129, 19);
            this.lblDogruCevap.TabIndex = 2;
            this.lblDogruCevap.Text = "Doğru cevabı giriniz:";
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(298, 95);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(139, 23);
            this.txtSoru.TabIndex = 3;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(298, 163);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(139, 23);
            this.txtKonu.TabIndex = 4;
            // 
            // txtDogruCevap
            // 
            this.txtDogruCevap.Location = new System.Drawing.Point(298, 222);
            this.txtDogruCevap.Name = "txtDogruCevap";
            this.txtDogruCevap.Size = new System.Drawing.Size(139, 23);
            this.txtDogruCevap.TabIndex = 5;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Highlight = true;
            this.btnSoruEkle.Location = new System.Drawing.Point(228, 285);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(100, 36);
            this.btnSoruEkle.TabIndex = 6;
            this.btnSoruEkle.Text = "Soruyu Ekle";
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.txtDogruCevap);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.lblSoru);
            this.Name = "FrmOgretmen";
            this.Text = "Öğretmen Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblSoru;
        private MetroFramework.Controls.MetroLabel lblKonu;
        private MetroFramework.Controls.MetroLabel lblDogruCevap;
        private MetroFramework.Controls.MetroTextBox txtSoru;
        private MetroFramework.Controls.MetroTextBox txtKonu;
        private MetroFramework.Controls.MetroTextBox txtDogruCevap;
        private MetroFramework.Controls.MetroButton btnSoruEkle;
    }
}