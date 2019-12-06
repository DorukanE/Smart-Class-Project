namespace YazilimSinama
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barGrafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubukGrafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinavaBaslaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞYAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIsim = new MetroFramework.Controls.MetroLabel();
            this.lblSoyisim = new MetroFramework.Controls.MetroLabel();
            this.lblYas = new MetroFramework.Controls.MetroLabel();
            this.lblOkul = new MetroFramework.Controls.MetroLabel();
            this.lblCinsiyet = new MetroFramework.Controls.MetroLabel();
            this.lblIsimVeritabani = new MetroFramework.Controls.MetroLabel();
            this.lblSoyisimVeritabani = new MetroFramework.Controls.MetroLabel();
            this.lblOkulVeritabani = new MetroFramework.Controls.MetroLabel();
            this.lblYasVeritabani = new MetroFramework.Controls.MetroLabel();
            this.lblCinsiyetVeritabani = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilimToolStripMenuItem,
            this.istatiklerToolStripMenuItem,
            this.sinavaBaslaToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilimToolStripMenuItem
            // 
            this.profilimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profilimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profilimToolStripMenuItem.Image")));
            this.profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            this.profilimToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.profilimToolStripMenuItem.Text = "PROFİLİM";
            // 
            // istatiklerToolStripMenuItem
            // 
            this.istatiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barGrafikToolStripMenuItem,
            this.cubukGrafikToolStripMenuItem});
            this.istatiklerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatiklerToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.images;
            this.istatiklerToolStripMenuItem.Name = "istatiklerToolStripMenuItem";
            this.istatiklerToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.istatiklerToolStripMenuItem.Text = "İSTATİSTİKLERİM";
            // 
            // barGrafikToolStripMenuItem
            // 
            this.barGrafikToolStripMenuItem.Name = "barGrafikToolStripMenuItem";
            this.barGrafikToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.barGrafikToolStripMenuItem.Text = "BAR GRAFİĞİ";
            this.barGrafikToolStripMenuItem.Click += new System.EventHandler(this.bARGRAFİĞİToolStripMenuItem_Click);
            // 
            // cubukGrafikToolStripMenuItem
            // 
            this.cubukGrafikToolStripMenuItem.Name = "cubukGrafikToolStripMenuItem";
            this.cubukGrafikToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cubukGrafikToolStripMenuItem.Text = "ÇUBUK GRAFİĞİ";
            this.cubukGrafikToolStripMenuItem.Click += new System.EventHandler(this.çUBUKGRAFİĞİToolStripMenuItem_Click);
            // 
            // sinavaBaslaToolStripMenuItem
            // 
            this.sinavaBaslaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinavaBaslaToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.exam;
            this.sinavaBaslaToolStripMenuItem.Name = "sinavaBaslaToolStripMenuItem";
            this.sinavaBaslaToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.sinavaBaslaToolStripMenuItem.Text = "SINAVA BAŞLA";
            this.sinavaBaslaToolStripMenuItem.Click += new System.EventHandler(this.sINAVABAŞLAToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞYAPToolStripMenuItem});
            this.cikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.exit;
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.cikisToolStripMenuItem.Text = "ÇIKIŞ";
            // 
            // çIKIŞYAPToolStripMenuItem
            // 
            this.çIKIŞYAPToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.exit;
            this.çIKIŞYAPToolStripMenuItem.Name = "çIKIŞYAPToolStripMenuItem";
            this.çIKIŞYAPToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F1\'e basınız.";
            this.çIKIŞYAPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.çIKIŞYAPToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.çIKIŞYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            this.çIKIŞYAPToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞYAPToolStripMenuItem_Click);
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(25, 154);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(35, 19);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "İsim:";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(23, 186);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(56, 19);
            this.lblSoyisim.TabIndex = 2;
            this.lblSoyisim.Text = "Soyisim:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(25, 251);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(30, 19);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yas:";
            // 
            // lblOkul
            // 
            this.lblOkul.AutoSize = true;
            this.lblOkul.Location = new System.Drawing.Point(25, 220);
            this.lblOkul.Name = "lblOkul";
            this.lblOkul.Size = new System.Drawing.Size(39, 19);
            this.lblOkul.TabIndex = 4;
            this.lblOkul.Text = "Okul:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(23, 283);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(56, 19);
            this.lblCinsiyet.TabIndex = 5;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblIsimVeritabani
            // 
            this.lblIsimVeritabani.AutoSize = true;
            this.lblIsimVeritabani.Location = new System.Drawing.Point(109, 154);
            this.lblIsimVeritabani.Name = "lblIsimVeritabani";
            this.lblIsimVeritabani.Size = new System.Drawing.Size(81, 19);
            this.lblIsimVeritabani.TabIndex = 6;
            this.lblIsimVeritabani.Text = "metroLabel1";
            // 
            // lblSoyisimVeritabani
            // 
            this.lblSoyisimVeritabani.AutoSize = true;
            this.lblSoyisimVeritabani.Location = new System.Drawing.Point(107, 186);
            this.lblSoyisimVeritabani.Name = "lblSoyisimVeritabani";
            this.lblSoyisimVeritabani.Size = new System.Drawing.Size(83, 19);
            this.lblSoyisimVeritabani.TabIndex = 7;
            this.lblSoyisimVeritabani.Text = "metroLabel2";
            // 
            // lblOkulVeritabani
            // 
            this.lblOkulVeritabani.AutoSize = true;
            this.lblOkulVeritabani.Location = new System.Drawing.Point(109, 220);
            this.lblOkulVeritabani.Name = "lblOkulVeritabani";
            this.lblOkulVeritabani.Size = new System.Drawing.Size(83, 19);
            this.lblOkulVeritabani.TabIndex = 8;
            this.lblOkulVeritabani.Text = "metroLabel3";
            // 
            // lblYasVeritabani
            // 
            this.lblYasVeritabani.AutoSize = true;
            this.lblYasVeritabani.Location = new System.Drawing.Point(109, 251);
            this.lblYasVeritabani.Name = "lblYasVeritabani";
            this.lblYasVeritabani.Size = new System.Drawing.Size(83, 19);
            this.lblYasVeritabani.TabIndex = 9;
            this.lblYasVeritabani.Text = "metroLabel4";
            // 
            // lblCinsiyetVeritabani
            // 
            this.lblCinsiyetVeritabani.AutoSize = true;
            this.lblCinsiyetVeritabani.Location = new System.Drawing.Point(109, 283);
            this.lblCinsiyetVeritabani.Name = "lblCinsiyetVeritabani";
            this.lblCinsiyetVeritabani.Size = new System.Drawing.Size(83, 19);
            this.lblCinsiyetVeritabani.TabIndex = 10;
            this.lblCinsiyetVeritabani.Text = "metroLabel5";
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 443);
            this.Controls.Add(this.lblCinsiyetVeritabani);
            this.Controls.Add(this.lblYasVeritabani);
            this.Controls.Add(this.lblOkulVeritabani);
            this.Controls.Add(this.lblSoyisimVeritabani);
            this.Controls.Add(this.lblIsimVeritabani);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblOkul);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmOgrenci";
            this.Text = "Öğrenci Girişi";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barGrafikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubukGrafikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞYAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinavaBaslaToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblIsim;
        private MetroFramework.Controls.MetroLabel lblSoyisim;
        private MetroFramework.Controls.MetroLabel lblYas;
        private MetroFramework.Controls.MetroLabel lblOkul;
        private MetroFramework.Controls.MetroLabel lblCinsiyet;
        private MetroFramework.Controls.MetroLabel lblIsimVeritabani;
        private MetroFramework.Controls.MetroLabel lblSoyisimVeritabani;
        private MetroFramework.Controls.MetroLabel lblOkulVeritabani;
        private MetroFramework.Controls.MetroLabel lblYasVeritabani;
        private MetroFramework.Controls.MetroLabel lblCinsiyetVeritabani;
    }
}