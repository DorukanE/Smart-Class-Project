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
            this.lblIsim = new MetroFramework.Controls.MetroLabel();
            this.lblSoyisim = new MetroFramework.Controls.MetroLabel();
            this.lblYas = new MetroFramework.Controls.MetroLabel();
            this.lblOkul = new MetroFramework.Controls.MetroLabel();
            this.lblCinsiyet = new MetroFramework.Controls.MetroLabel();
            this.pROFİLİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICIBİLGİLERİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSTATİSTİKLERİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARGRAFİĞİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çUBUKGRAFİĞİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sINAVABAŞLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞYAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROFİLİMToolStripMenuItem,
            this.iSTATİSTİKLERİMToolStripMenuItem,
            this.sINAVABAŞLAToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // pROFİLİMToolStripMenuItem
            // 
            this.pROFİLİMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kULLANICIBİLGİLERİMToolStripMenuItem});
            this.pROFİLİMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pROFİLİMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pROFİLİMToolStripMenuItem.Image")));
            this.pROFİLİMToolStripMenuItem.Name = "pROFİLİMToolStripMenuItem";
            this.pROFİLİMToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.pROFİLİMToolStripMenuItem.Text = "PROFİLİM";
            // 
            // kULLANICIBİLGİLERİMToolStripMenuItem
            // 
            this.kULLANICIBİLGİLERİMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kULLANICIBİLGİLERİMToolStripMenuItem.Image")));
            this.kULLANICIBİLGİLERİMToolStripMenuItem.Name = "kULLANICIBİLGİLERİMToolStripMenuItem";
            this.kULLANICIBİLGİLERİMToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.kULLANICIBİLGİLERİMToolStripMenuItem.Text = "KULLANICI BİLGİLERİM";
            this.kULLANICIBİLGİLERİMToolStripMenuItem.Click += new System.EventHandler(this.kULLANICIBİLGİLERİMToolStripMenuItem_Click);
            // 
            // iSTATİSTİKLERİMToolStripMenuItem
            // 
            this.iSTATİSTİKLERİMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bARGRAFİĞİToolStripMenuItem,
            this.çUBUKGRAFİĞİToolStripMenuItem});
            this.iSTATİSTİKLERİMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iSTATİSTİKLERİMToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.images;
            this.iSTATİSTİKLERİMToolStripMenuItem.Name = "iSTATİSTİKLERİMToolStripMenuItem";
            this.iSTATİSTİKLERİMToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.iSTATİSTİKLERİMToolStripMenuItem.Text = "İSTATİSTİKLERİM";
            // 
            // bARGRAFİĞİToolStripMenuItem
            // 
            this.bARGRAFİĞİToolStripMenuItem.Name = "bARGRAFİĞİToolStripMenuItem";
            this.bARGRAFİĞİToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.bARGRAFİĞİToolStripMenuItem.Text = "BAR GRAFİĞİ";
            this.bARGRAFİĞİToolStripMenuItem.Click += new System.EventHandler(this.bARGRAFİĞİToolStripMenuItem_Click);
            // 
            // çUBUKGRAFİĞİToolStripMenuItem
            // 
            this.çUBUKGRAFİĞİToolStripMenuItem.Name = "çUBUKGRAFİĞİToolStripMenuItem";
            this.çUBUKGRAFİĞİToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.çUBUKGRAFİĞİToolStripMenuItem.Text = "ÇUBUK GRAFİĞİ";
            this.çUBUKGRAFİĞİToolStripMenuItem.Click += new System.EventHandler(this.çUBUKGRAFİĞİToolStripMenuItem_Click);
            // 
            // sINAVABAŞLAToolStripMenuItem
            // 
            this.sINAVABAŞLAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sINAVABAŞLAToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.exam;
            this.sINAVABAŞLAToolStripMenuItem.Name = "sINAVABAŞLAToolStripMenuItem";
            this.sINAVABAŞLAToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.sINAVABAŞLAToolStripMenuItem.Text = "SINAVA BAŞLA";
            this.sINAVABAŞLAToolStripMenuItem.Click += new System.EventHandler(this.sINAVABAŞLAToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞYAPToolStripMenuItem});
            this.çIKIŞToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çIKIŞToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.exit;
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
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
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 443);
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
        private System.Windows.Forms.ToolStripMenuItem pROFİLİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICIBİLGİLERİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSTATİSTİKLERİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bARGRAFİĞİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çUBUKGRAFİĞİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞYAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sINAVABAŞLAToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblIsim;
        private MetroFramework.Controls.MetroLabel lblSoyisim;
        private MetroFramework.Controls.MetroLabel lblYas;
        private MetroFramework.Controls.MetroLabel lblOkul;
        private MetroFramework.Controls.MetroLabel lblCinsiyet;
    }
}