using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PPP
{
    public partial class oscilograph : Form
    {
        public oscilograph()
        {
            signal = new double[1024];
            _amplitude = 1;
            _frequency = 2;
            _phase = 0;
            _frhigh = _frequency * 10;
            _function = new FunctionForSignals(_amplitude, _frequency, 0, _phase);
            lastOperation = 1;
            InitializeComponent();
        }
        public double[] Signal => signal;
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void осцилографToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Spectrummetr_Click(object sender, EventArgs e)
        {

        }

        private void spectrummetrButton_Click(object sender, EventArgs e)
        {
            Spectrummetr spectrummetr = new Spectrummetr(this);
            spectrummetr.ShowDialog();
        }

        private void signalMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public string Adres { get => adres; set => adres = value; }

        private void DrawSignal(Series series, double[] signal)
        {
            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < signal.Length; i++)
            {
                series.Points.AddXY(i, signal[i]);
            }
            chartSignal.Series.Add(series);
        }

        private void меандр()
        {
            signal[0] = -1.0 * _amplitude;
            for (int i = 1; i < signal.Length; i++)
            {
                signal[i] = _function.Meandr(i, Convert.ToInt32(signal[i - 1] / _amplitude));
            }
            chartSignal.Series.Clear();
            Series series = new Series("Meandr");
            DrawSignal(series, signal);
        }
        private void единичный() {
            for (int i = 0; i < signal.Length; i++)
            {
                signal[i] = i == 100 ? 1 : 0;
            }
            chartSignal.Series.Clear();
            Series series = new Series("Deltha");
            DrawSignal(series, signal);
        }

        private void косинусоидальный()
        {
            for (int i = 0; i < signal.Length; i++)
            {
                signal[i] = _function.CosSignal(i);
            }
            chartSignal.Series.Clear();
            Series series = new Series("Cosinus");
            DrawSignal(series, signal);
        }

        private void синусоидальный()
        {
            for (int i = 0; i < signal.Length; i++)
            {
                signal[i] = _function.SinSignal(i);
            }
            chartSignal.Series.Clear();
            Series series = new Series("Sinus");
            DrawSignal(series, signal);
        }

        private void треугольный()
        {
            for (int i = 0; i < signal.Length; i++)
            {
                signal[i] = _function.TriangleSignal(i);
            }
            chartSignal.Series.Clear();
            Series series = new Series("Sinus");
            DrawSignal(series, signal);
        }

        private void пилообразный()
        {
            for (int i = 0; i < signal.Length; i++)
            {
                signal[i] = _function.SawtoothSignal(i);
            }
            chartSignal.Series.Clear();
            Series series = new Series("Sinus");
            DrawSignal(series, signal);
        }

        private void AmplitudeModulation(double oR)
        {
            _function.Frequency = _frhigh;
            _function.Phase = 0;
            for (int i = 0; i < signal.Length; i++)
            {
                signal[i] = signal[i] * _function.CosSignal(i);
            }
            _function.Frequency = _frequency;
            _function.Phase = _phase;
            chartSignal.Series.Clear();
            Series series = new Series("AM");
            DrawSignal(series, signal);
        }

        private void единичныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            единичный();
            lastOperation = 0;
        }

        private void меандрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            меандр();
            lastOperation = 1;
        }

        private void косинусоидальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            косинусоидальный();
            lastOperation = 2;
        }

        private void синусоидальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            синусоидальный();
            lastOperation = 3;
        }

        private void треугольныйИмпульсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            треугольный();
            lastOperation = 4;
        }

       
        private void пилообразныйИмпульсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            пилообразный();
            lastOperation = 5;
        }

        private void doLastOperation(int lastOperation)
        {
            switch(lastOperation)
            {
                case (0): 
                    this.единичный();
                    break;
                case 1:
                    this.меандр();
                    break;
                case 2:
                    this.косинусоидальный();
                    break;
                case 3:
                    this.синусоидальный();
                    break;
                case 4:
                    this.треугольный();
                    break;
                case 5:
                    this.пилообразный();
                    break;

            }
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDownAmplitude_ValueChanged(object sender, EventArgs e)
        {
            _amplitude = (double)numericUpDownAmplitude.Value;
            _function.Amplitude = _amplitude;
            chartSignal.ChartAreas[0].AxisY.Minimum = -1.5 * _amplitude;
            chartSignal.ChartAreas[0].AxisY.Maximum = 1.5 * _amplitude;
        }
        private void numericUpDownFrequency_ValueChanged(object sender, EventArgs e)
        {
            _frequency = (double)numericUpDownFrequency.Value;
            _function.Frequency = _frequency;
        }

        private void numericUpDownPhase_ValueChanged(object sender, EventArgs e)
        {
            _phase = (double)numericUpDownPhase.Value;
            _function.Phase = _phase;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frequencyLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegen_Click(object sender, EventArgs e)
        {
            doLastOperation(lastOperation);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _frhigh = (double)numericUpDown1.Value;
        }

        private void buttonAM_Click(object sender, EventArgs e)
        {
            AmplitudeModulation(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmplitudeModulation(-1);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Admin\\source\\repos\\project\\PPP\\PPP\\documents\\signal.txt"))
            {
                foreach (double value in signal)
                {
                    writer.WriteLine(value);
                }
                writer.Close();
            } 
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm zagruz = new openForm(this);
            zagruz.ShowDialog();
            using (StreamReader reader = new StreamReader(Adres))
            { 
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null || i < Signal.Length)
                {
                    Signal[i]=(double.Parse(line));
                    i++;
                }
                reader.Close();
                chartSignal.Series.Clear();
                Series series = new Series("Cosinus");
                DrawSignal(series, signal);
            }
        }
        
    }
}
