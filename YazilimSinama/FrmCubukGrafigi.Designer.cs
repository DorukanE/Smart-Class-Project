namespace YazilimSinama
{
    partial class FrmCubukGrafigi
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartZamanBasari = new DevExpress.XtraCharts.ChartControl();
            this.cmbTarih = new MetroFramework.Controls.MetroComboBox();
            this.btnGrafikGoster = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartZamanBasari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartZamanBasari
            // 
            this.chartZamanBasari.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.chartZamanBasari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(179)))), ((int)(((byte)(226)))));
            this.chartZamanBasari.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartZamanBasari.BorderOptions.Thickness = 2;
            this.chartZamanBasari.DataBindings = null;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartZamanBasari.Diagram = xyDiagram2;
            this.chartZamanBasari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartZamanBasari.Legend.Name = "Default Legend";
            this.chartZamanBasari.Location = new System.Drawing.Point(20, 60);
            this.chartZamanBasari.Name = "chartZamanBasari";
            this.chartZamanBasari.PaletteName = "Equity";
            series2.Name = "Doğru Cevap Sayısı";
            series2.View = lineSeriesView2;
            this.chartZamanBasari.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartZamanBasari.Size = new System.Drawing.Size(760, 370);
            this.chartZamanBasari.TabIndex = 1;
            // 
            // cmbTarih
            // 
            this.cmbTarih.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTarih.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cmbTarih.FormattingEnabled = true;
            this.cmbTarih.ItemHeight = 19;
            this.cmbTarih.Items.AddRange(new object[] {
            "sadsa",
            "sadsa",
            "sadas",
            "dsad",
            "adsa"});
            this.cmbTarih.Location = new System.Drawing.Point(646, 115);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(121, 25);
            this.cmbTarih.TabIndex = 2;
            this.cmbTarih.SelectedIndexChanged += new System.EventHandler(this.cmbTarih_SelectedIndexChanged);
            // 
            // btnGrafikGoster
            // 
            this.btnGrafikGoster.Highlight = true;
            this.btnGrafikGoster.Location = new System.Drawing.Point(646, 161);
            this.btnGrafikGoster.Name = "btnGrafikGoster";
            this.btnGrafikGoster.Size = new System.Drawing.Size(121, 23);
            this.btnGrafikGoster.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnGrafikGoster.TabIndex = 3;
            this.btnGrafikGoster.Text = "Tüm Grafiği Göster";
            this.btnGrafikGoster.Click += new System.EventHandler(this.btnGrafikGoster_Click);
            // 
            // FrmCubukGrafigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrafikGoster);
            this.Controls.Add(this.cmbTarih);
            this.Controls.Add(this.chartZamanBasari);
            this.Name = "FrmCubukGrafigi";
            this.Text = "Zaman Bazlı Başarı Grafiği";
            this.Load += new System.EventHandler(this.FrmCubukGrafigi_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZamanBasari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartZamanBasari;
        private MetroFramework.Controls.MetroComboBox cmbTarih;
        private MetroFramework.Controls.MetroButton btnGrafikGoster;
    }
}