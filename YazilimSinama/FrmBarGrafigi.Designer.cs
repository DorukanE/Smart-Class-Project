namespace YazilimSinama
{
    partial class FrmBarGrafigi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBasari = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGrafKonu = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartBasari)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBasari
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBasari.ChartAreas.Add(chartArea1);
            this.chartBasari.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBasari.Legends.Add(legend1);
            this.chartBasari.Location = new System.Drawing.Point(20, 60);
            this.chartBasari.Name = "chartBasari";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=LightToDark";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "DoğruCevap";
            series1.YValuesPerPoint = 2;
            this.chartBasari.Series.Add(series1);
            this.chartBasari.Size = new System.Drawing.Size(1007, 339);
            this.chartBasari.TabIndex = 0;
            this.chartBasari.Text = "chart1";
            // 
            // lblGrafKonu
            // 
            this.lblGrafKonu.AutoSize = true;
            this.lblGrafKonu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGrafKonu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGrafKonu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrafKonu.Location = new System.Drawing.Point(903, 345);
            this.lblGrafKonu.Name = "lblGrafKonu";
            this.lblGrafKonu.Size = new System.Drawing.Size(79, 25);
            this.lblGrafKonu.TabIndex = 1;
            this.lblGrafKonu.Text = "Konular";
            // 
            // FrmBarGrafigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 419);
            this.Controls.Add(this.lblGrafKonu);
            this.Controls.Add(this.chartBasari);
            this.Name = "FrmBarGrafigi";
            this.Text = "Öğrenci Bar Grafiği";
            this.Load += new System.EventHandler(this.FrmBarGrafigi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBasari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBasari;
        private MetroFramework.Controls.MetroLabel lblGrafKonu;
    }
}