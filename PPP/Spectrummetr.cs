using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;

namespace PPP
{
    public partial class Spectrummetr : Form
    {
        public Spectrummetr(oscilograph oscilograph_)
        {
            InitializeComponent();
            _oscilograph= oscilograph_;
            this.spectrumSignal = new Complex32[oscilograph_.Signal.Length];
            for (int i=0; i< oscilograph_.Signal.Length; i++)
            {
                this.spectrumSignal[i] = new Complex32((float)oscilograph_.Signal[i], 0);
            }
        }
        
        private void Spectrummetr_Load(object sender, EventArgs e)
        {

        }

        private void DrawSpectrum()
        {
            //for(int i = 0; i < spectrumSignal.Length; i++)
            //{
                Fourier.Forward(this.spectrumSignal);
            //}

            double[] magnitudes = new double[3*spectrumSignal.Length];
            for (int i = 0; i < spectrumSignal.Length; i++)
            {
                magnitudes[spectrumSignal.Length+i] = spectrumSignal[i].Real;
            }

            spectrum.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < magnitudes.Length; i++)
            {
                series.Points.AddXY(i, magnitudes[i]);
            }
            spectrum.Series.Add(series);
        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawSpectrum();
        }
    }
}
