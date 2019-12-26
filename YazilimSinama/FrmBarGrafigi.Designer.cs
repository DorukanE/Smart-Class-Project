﻿namespace YazilimSinama
{
    partial class FrmBasariGrafigi
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView1 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            this.chartBasari = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartBasari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBasari
            // 
            this.chartBasari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.chartBasari.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartBasari.BorderOptions.Thickness = 2;
            this.chartBasari.DataBindings = null;
            xyDiagram3D1.HorizontalScrollPercent = 3.0065015596226852D;
            xyDiagram3D1.RotationMatrixSerializable = "0.832363923225189;-0.103311080484192;0.544515491021493;0;0.00961894000972918;0.98" +
    "5017858088284;0.172183899480389;0;-0.554145987359176;-0.138082004245203;0.820887" +
    "071890753;0;0;0;0;1";
            xyDiagram3D1.VerticalScrollPercent = -0.80201037266748709D;
            xyDiagram3D1.ZoomPercent = 120;
            this.chartBasari.Diagram = xyDiagram3D1;
            this.chartBasari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBasari.Legend.Name = "Default Legend";
            this.chartBasari.Location = new System.Drawing.Point(20, 60);
            this.chartBasari.Name = "chartBasari";
            this.chartBasari.Padding.Bottom = 20;
            this.chartBasari.Padding.Left = 20;
            this.chartBasari.Padding.Right = 20;
            this.chartBasari.Padding.Top = 20;
            this.chartBasari.PaletteName = "Equity";
            series1.Name = "Doğru Cevap";
            sideBySideBar3DSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(55)))), ((int)(((byte)(52)))));
            series1.View = sideBySideBar3DSeriesView1;
            this.chartBasari.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartBasari.Size = new System.Drawing.Size(497, 333);
            this.chartBasari.TabIndex = 0;
            // 
            // FrmBasariGrafigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 413);
            this.Controls.Add(this.chartBasari);
            this.Name = "FrmBasariGrafigi";
            this.Text = "Öğrenci Başarı Grafiği";
            this.Load += new System.EventHandler(this.FrmBarGrafigi_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBasari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartBasari;
    }
}