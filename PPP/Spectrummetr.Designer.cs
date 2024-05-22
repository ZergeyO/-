using MathNet.Numerics;
using System.Numerics;

namespace PPP
{
    partial class Spectrummetr
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Close_button = new System.Windows.Forms.Button();
            this.spectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spectrum)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(618, 370);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 0;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // spectrum
            // 
            chartArea2.Name = "ChartArea1";
            this.spectrum.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.spectrum.Legends.Add(legend2);
            this.spectrum.Location = new System.Drawing.Point(12, 37);
            this.spectrum.Name = "spectrum";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.spectrum.Series.Add(series2);
            this.spectrum.Size = new System.Drawing.Size(488, 356);
            this.spectrum.TabIndex = 1;
            this.spectrum.Text = "Spectrum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make Spectrum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Spectrummetr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spectrum);
            this.Controls.Add(this.Close_button);
            this.Name = "Spectrummetr";
            this.Text = "Close";
            this.Load += new System.EventHandler(this.Spectrummetr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spectrum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private oscilograph _oscilograph;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart spectrum;
        private Complex32[] spectrumSignal;
        private System.Windows.Forms.Button button1;
    }
}