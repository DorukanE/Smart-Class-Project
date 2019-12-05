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
            this.lblSayac = new MetroFramework.Controls.MetroLabel();
            this.timersure = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.btnASecenegi = new MetroFramework.Controls.MetroButton();
            this.btnBSecenegi = new MetroFramework.Controls.MetroButton();
            this.btnCSecenegi = new MetroFramework.Controls.MetroButton();
            this.btnDSecenegi = new MetroFramework.Controls.MetroButton();
            this.btnESecenegi = new MetroFramework.Controls.MetroButton();
            this.txtASecenegi = new MetroFramework.Controls.MetroTextBox();
            this.txtBSecenegi = new MetroFramework.Controls.MetroTextBox();
            this.txtCSecenegi = new MetroFramework.Controls.MetroTextBox();
            this.txtDSecenegi = new MetroFramework.Controls.MetroTextBox();
            this.txtESecenegi = new MetroFramework.Controls.MetroTextBox();
            this.txtSoruMetni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSayac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSayac.Location = new System.Drawing.Point(745, 72);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YazilimSinama.Properties.Resources.alarm__clock__time__alert__bell__alarmicon__firealarm__siren_512;
            this.pictureBox1.Location = new System.Drawing.Point(703, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(18, 78);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(659, 19);
            this.metroProgressBar1.TabIndex = 13;
            this.metroProgressBar1.Value = 50;
            // 
            // btnASecenegi
            // 
            this.btnASecenegi.Location = new System.Drawing.Point(238, 209);
            this.btnASecenegi.Name = "btnASecenegi";
            this.btnASecenegi.Size = new System.Drawing.Size(42, 23);
            this.btnASecenegi.TabIndex = 14;
            this.btnASecenegi.Text = "A)";
            // 
            // btnBSecenegi
            // 
            this.btnBSecenegi.Location = new System.Drawing.Point(238, 238);
            this.btnBSecenegi.Name = "btnBSecenegi";
            this.btnBSecenegi.Size = new System.Drawing.Size(42, 23);
            this.btnBSecenegi.TabIndex = 15;
            this.btnBSecenegi.Text = "B)";
            // 
            // btnCSecenegi
            // 
            this.btnCSecenegi.Location = new System.Drawing.Point(238, 267);
            this.btnCSecenegi.Name = "btnCSecenegi";
            this.btnCSecenegi.Size = new System.Drawing.Size(42, 23);
            this.btnCSecenegi.TabIndex = 16;
            this.btnCSecenegi.Text = "C)";
            // 
            // btnDSecenegi
            // 
            this.btnDSecenegi.Location = new System.Drawing.Point(238, 296);
            this.btnDSecenegi.Name = "btnDSecenegi";
            this.btnDSecenegi.Size = new System.Drawing.Size(42, 23);
            this.btnDSecenegi.TabIndex = 17;
            this.btnDSecenegi.Text = "D)";
            // 
            // btnESecenegi
            // 
            this.btnESecenegi.Location = new System.Drawing.Point(238, 325);
            this.btnESecenegi.Name = "btnESecenegi";
            this.btnESecenegi.Size = new System.Drawing.Size(42, 23);
            this.btnESecenegi.TabIndex = 18;
            this.btnESecenegi.Text = "E)";
            // 
            // txtASecenegi
            // 
            this.txtASecenegi.Location = new System.Drawing.Point(317, 208);
            this.txtASecenegi.Name = "txtASecenegi";
            this.txtASecenegi.Size = new System.Drawing.Size(102, 23);
            this.txtASecenegi.TabIndex = 19;
            // 
            // txtBSecenegi
            // 
            this.txtBSecenegi.Location = new System.Drawing.Point(317, 238);
            this.txtBSecenegi.Name = "txtBSecenegi";
            this.txtBSecenegi.Size = new System.Drawing.Size(102, 23);
            this.txtBSecenegi.TabIndex = 20;
            // 
            // txtCSecenegi
            // 
            this.txtCSecenegi.Location = new System.Drawing.Point(317, 267);
            this.txtCSecenegi.Name = "txtCSecenegi";
            this.txtCSecenegi.Size = new System.Drawing.Size(102, 23);
            this.txtCSecenegi.TabIndex = 21;
            // 
            // txtDSecenegi
            // 
            this.txtDSecenegi.Location = new System.Drawing.Point(317, 296);
            this.txtDSecenegi.Name = "txtDSecenegi";
            this.txtDSecenegi.Size = new System.Drawing.Size(102, 23);
            this.txtDSecenegi.TabIndex = 22;
            // 
            // txtESecenegi
            // 
            this.txtESecenegi.Location = new System.Drawing.Point(317, 325);
            this.txtESecenegi.Name = "txtESecenegi";
            this.txtESecenegi.Size = new System.Drawing.Size(102, 23);
            this.txtESecenegi.TabIndex = 23;
            // 
            // txtSoruMetni
            // 
            this.txtSoruMetni.Location = new System.Drawing.Point(141, 152);
            this.txtSoruMetni.Name = "txtSoruMetni";
            this.txtSoruMetni.Size = new System.Drawing.Size(450, 20);
            this.txtSoruMetni.TabIndex = 24;
            // 
            // FrmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSoruMetni);
            this.Controls.Add(this.txtESecenegi);
            this.Controls.Add(this.txtDSecenegi);
            this.Controls.Add(this.txtCSecenegi);
            this.Controls.Add(this.txtBSecenegi);
            this.Controls.Add(this.txtASecenegi);
            this.Controls.Add(this.btnESecenegi);
            this.Controls.Add(this.btnDSecenegi);
            this.Controls.Add(this.btnCSecenegi);
            this.Controls.Add(this.btnBSecenegi);
            this.Controls.Add(this.btnASecenegi);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSayac);
            this.Name = "FrmSinav";
            this.Text = "Sınav";
            this.Load += new System.EventHandler(this.FrmSinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblSayac;
        private System.Windows.Forms.Timer timersure;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton btnASecenegi;
        private MetroFramework.Controls.MetroButton btnBSecenegi;
        private MetroFramework.Controls.MetroButton btnCSecenegi;
        private MetroFramework.Controls.MetroButton btnDSecenegi;
        private MetroFramework.Controls.MetroButton btnESecenegi;
        private MetroFramework.Controls.MetroTextBox txtASecenegi;
        private MetroFramework.Controls.MetroTextBox txtBSecenegi;
        private MetroFramework.Controls.MetroTextBox txtCSecenegi;
        private MetroFramework.Controls.MetroTextBox txtDSecenegi;
        private MetroFramework.Controls.MetroTextBox txtESecenegi;
        private System.Windows.Forms.TextBox txtSoruMetni;
    }
}