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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripOgrenci = new System.Windows.Forms.MenuStrip();
            this.profilimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barGrafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubukGrafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinavaBaslaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞYAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblOgrenciBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciOkulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinavTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listViewProfilim = new System.Windows.Forms.ListView();
            this.columnHeaderAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOkul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSinavTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxProfilim = new System.Windows.Forms.PictureBox();
            this.menuStripOgrenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilim)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripOgrenci
            // 
            this.menuStripOgrenci.BackColor = System.Drawing.Color.LightGreen;
            this.menuStripOgrenci.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStripOgrenci.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilimToolStripMenuItem,
            this.sinavaBaslaToolStripMenuItem,
            this.istatiklerToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStripOgrenci.Location = new System.Drawing.Point(20, 60);
            this.menuStripOgrenci.Name = "menuStripOgrenci";
            this.menuStripOgrenci.Size = new System.Drawing.Size(890, 29);
            this.menuStripOgrenci.TabIndex = 0;
            this.menuStripOgrenci.Text = "menuStrip1";
            this.menuStripOgrenci.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripOgrenci_ItemClicked);
            // 
            // profilimToolStripMenuItem
            // 
            this.profilimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profilimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profilimToolStripMenuItem.Image")));
            this.profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            this.profilimToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.profilimToolStripMenuItem.Text = "PROFİLİM";
            this.profilimToolStripMenuItem.Click += new System.EventHandler(this.profilimToolStripMenuItem_Click);
            // 
            // istatiklerToolStripMenuItem
            // 
            this.istatiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barGrafikToolStripMenuItem,
            this.cubukGrafikToolStripMenuItem});
            this.istatiklerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatiklerToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.images;
            this.istatiklerToolStripMenuItem.Name = "istatiklerToolStripMenuItem";
            this.istatiklerToolStripMenuItem.Size = new System.Drawing.Size(164, 25);
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
            this.sinavaBaslaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinavaBaslaToolStripMenuItem.Image = global::YazilimSinama.Properties.Resources.exam;
            this.sinavaBaslaToolStripMenuItem.Name = "sinavaBaslaToolStripMenuItem";
            this.sinavaBaslaToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
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
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
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
            // tblOgrenciBilgiBindingSource
            // 
            this.tblOgrenciBilgiBindingSource.DataMember = "tbl_OgrenciBilgi";
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "ogrenciID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.ogrenciIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "ogrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "ogrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "ogrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // ogrenciOkulDataGridViewTextBoxColumn
            // 
            this.ogrenciOkulDataGridViewTextBoxColumn.DataPropertyName = "ogrenciOkul";
            this.ogrenciOkulDataGridViewTextBoxColumn.HeaderText = "ogrenciOkul";
            this.ogrenciOkulDataGridViewTextBoxColumn.Name = "ogrenciOkulDataGridViewTextBoxColumn";
            // 
            // ogrenciCinsiyetDataGridViewTextBoxColumn
            // 
            this.ogrenciCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "ogrenciCinsiyet";
            this.ogrenciCinsiyetDataGridViewTextBoxColumn.HeaderText = "ogrenciCinsiyet";
            this.ogrenciCinsiyetDataGridViewTextBoxColumn.Name = "ogrenciCinsiyetDataGridViewTextBoxColumn";
            // 
            // sinavTarihiDataGridViewTextBoxColumn
            // 
            this.sinavTarihiDataGridViewTextBoxColumn.DataPropertyName = "sinavTarihi";
            this.sinavTarihiDataGridViewTextBoxColumn.HeaderText = "sinavTarihi";
            this.sinavTarihiDataGridViewTextBoxColumn.Name = "sinavTarihiDataGridViewTextBoxColumn";
            // 
            // ogrenciDTarihDataGridViewTextBoxColumn
            // 
            this.ogrenciDTarihDataGridViewTextBoxColumn.DataPropertyName = "ogrenciDTarih";
            this.ogrenciDTarihDataGridViewTextBoxColumn.HeaderText = "ogrenciDTarih";
            this.ogrenciDTarihDataGridViewTextBoxColumn.Name = "ogrenciDTarihDataGridViewTextBoxColumn";
            // 
            // listViewProfilim
            // 
            this.listViewProfilim.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewProfilim.BackColor = System.Drawing.Color.LightGreen;
            this.listViewProfilim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAd,
            this.columnHeaderSoyad,
            this.columnHeaderOkul,
            this.columnHeaderCinsiyet,
            this.columnHeaderSinavTarihi,
            this.columnHeaderDogumTarihi});
            this.listViewProfilim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewProfilim.HideSelection = false;
            this.listViewProfilim.HoverSelection = true;
            this.listViewProfilim.Location = new System.Drawing.Point(186, 193);
            this.listViewProfilim.Name = "listViewProfilim";
            this.listViewProfilim.Size = new System.Drawing.Size(724, 204);
            this.listViewProfilim.TabIndex = 1;
            this.listViewProfilim.UseCompatibleStateImageBehavior = false;
            this.listViewProfilim.View = System.Windows.Forms.View.Details;
            this.listViewProfilim.SelectedIndexChanged += new System.EventHandler(this.listViewProfilim_SelectedIndexChanged);
            // 
            // columnHeaderAd
            // 
            this.columnHeaderAd.Text = "Öğrenci Ad";
            this.columnHeaderAd.Width = 115;
            // 
            // columnHeaderSoyad
            // 
            this.columnHeaderSoyad.Text = "Öğrenci Soyad";
            this.columnHeaderSoyad.Width = 139;
            // 
            // columnHeaderOkul
            // 
            this.columnHeaderOkul.Text = "Okul";
            this.columnHeaderOkul.Width = 73;
            // 
            // columnHeaderCinsiyet
            // 
            this.columnHeaderCinsiyet.Text = "Cinsiyet";
            this.columnHeaderCinsiyet.Width = 109;
            // 
            // columnHeaderSinavTarihi
            // 
            this.columnHeaderSinavTarihi.Text = "Sınav Tarihi";
            this.columnHeaderSinavTarihi.Width = 122;
            // 
            // columnHeaderDogumTarihi
            // 
            this.columnHeaderDogumTarihi.Text = "Doğum Tarihi";
            this.columnHeaderDogumTarihi.Width = 138;
            // 
            // pictureBoxProfilim
            // 
            this.pictureBoxProfilim.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfilim.Image")));
            this.pictureBoxProfilim.Location = new System.Drawing.Point(20, 193);
            this.pictureBoxProfilim.Name = "pictureBoxProfilim";
            this.pictureBoxProfilim.Size = new System.Drawing.Size(160, 204);
            this.pictureBoxProfilim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilim.TabIndex = 2;
            this.pictureBoxProfilim.TabStop = false;
            this.pictureBoxProfilim.Click += new System.EventHandler(this.pictureBoxProfilim_Click);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 516);
            this.Controls.Add(this.pictureBoxProfilim);
            this.Controls.Add(this.listViewProfilim);
            this.Controls.Add(this.menuStripOgrenci);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStripOgrenci;
            this.Name = "FrmOgrenci";
            this.Text = "Öğrenci Girişi";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            this.menuStripOgrenci.ResumeLayout(false);
            this.menuStripOgrenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOgrenci;
        private System.Windows.Forms.ToolStripMenuItem profilimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barGrafikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubukGrafikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞYAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinavaBaslaToolStripMenuItem;
        
        private System.Windows.Forms.BindingSource tblOgrenciBilgiBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciOkulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinavTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView listViewProfilim;
        private System.Windows.Forms.ColumnHeader columnHeaderAd;
        private System.Windows.Forms.ColumnHeader columnHeaderSoyad;
        private System.Windows.Forms.ColumnHeader columnHeaderOkul;
        private System.Windows.Forms.ColumnHeader columnHeaderCinsiyet;
        private System.Windows.Forms.ColumnHeader columnHeaderSinavTarihi;
        private System.Windows.Forms.ColumnHeader columnHeaderDogumTarihi;
        private System.Windows.Forms.PictureBox pictureBoxProfilim;
    }
}