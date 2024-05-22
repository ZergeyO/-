using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PPP
{
    partial class oscilograph
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSignal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signalMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.единичныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меандрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гармоническийИмпульсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.косинусоидальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синусоидальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольныйИмпульсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пилообразныйИмпульсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectrummetrButton = new System.Windows.Forms.Button();
            this.numericUpDownAmplitude = new System.Windows.Forms.NumericUpDown();
            this.labelAmplitude = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.labelPhase = new System.Windows.Forms.Label();
            this.numericUpDownPhase = new System.Windows.Forms.NumericUpDown();
            this.buttonRegen = new System.Windows.Forms.Button();
            this.buttonAM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSignal
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSignal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSignal.Legends.Add(legend2);
            this.chartSignal.Location = new System.Drawing.Point(12, 86);
            this.chartSignal.Name = "chartSignal";
            this.chartSignal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSignal.Series.Add(series2);
            this.chartSignal.Size = new System.Drawing.Size(533, 385);
            this.chartSignal.TabIndex = 0;
            this.chartSignal.Text = "chart1";
            this.chartSignal.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signalMenuToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signalMenuToolStripMenuItem
            // 
            this.signalMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectToolStripMenuItem,
            this.гармоническийИмпульсToolStripMenuItem,
            this.треугольныйИмпульсToolStripMenuItem,
            this.пилообразныйИмпульсToolStripMenuItem});
            this.signalMenuToolStripMenuItem.Name = "signalMenuToolStripMenuItem";
            this.signalMenuToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.signalMenuToolStripMenuItem.Text = "Тип Сигнала";
            this.signalMenuToolStripMenuItem.Click += new System.EventHandler(this.signalMenuToolStripMenuItem_Click);
            // 
            // rectToolStripMenuItem
            // 
            this.rectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.единичныйToolStripMenuItem,
            this.меандрToolStripMenuItem});
            this.rectToolStripMenuItem.Name = "rectToolStripMenuItem";
            this.rectToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.rectToolStripMenuItem.Text = "Прямоугольный импульс";
            this.rectToolStripMenuItem.Click += new System.EventHandler(this.осцилографToolStripMenuItem_Click);
            // 
            // единичныйToolStripMenuItem
            // 
            this.единичныйToolStripMenuItem.Name = "единичныйToolStripMenuItem";
            this.единичныйToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.единичныйToolStripMenuItem.Text = "Дельта-Функция";
            this.единичныйToolStripMenuItem.Click += new System.EventHandler(this.единичныйToolStripMenuItem_Click);
            // 
            // меандрToolStripMenuItem
            // 
            this.меандрToolStripMenuItem.Name = "меандрToolStripMenuItem";
            this.меандрToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.меандрToolStripMenuItem.Text = "Меандр нечётный";
            this.меандрToolStripMenuItem.Click += new System.EventHandler(this.меандрToolStripMenuItem_Click);
            // 
            // гармоническийИмпульсToolStripMenuItem
            // 
            this.гармоническийИмпульсToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.косинусоидальныйToolStripMenuItem,
            this.синусоидальныйToolStripMenuItem});
            this.гармоническийИмпульсToolStripMenuItem.Name = "гармоническийИмпульсToolStripMenuItem";
            this.гармоническийИмпульсToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.гармоническийИмпульсToolStripMenuItem.Text = "Гармонический импульс";
            // 
            // косинусоидальныйToolStripMenuItem
            // 
            this.косинусоидальныйToolStripMenuItem.Name = "косинусоидальныйToolStripMenuItem";
            this.косинусоидальныйToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.косинусоидальныйToolStripMenuItem.Text = "Косинусоидальный";
            this.косинусоидальныйToolStripMenuItem.Click += new System.EventHandler(this.косинусоидальныйToolStripMenuItem_Click);
            // 
            // синусоидальныйToolStripMenuItem
            // 
            this.синусоидальныйToolStripMenuItem.Name = "синусоидальныйToolStripMenuItem";
            this.синусоидальныйToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.синусоидальныйToolStripMenuItem.Text = "Синусоидальный";
            this.синусоидальныйToolStripMenuItem.Click += new System.EventHandler(this.синусоидальныйToolStripMenuItem_Click);
            // 
            // треугольныйИмпульсToolStripMenuItem
            // 
            this.треугольныйИмпульсToolStripMenuItem.Name = "треугольныйИмпульсToolStripMenuItem";
            this.треугольныйИмпульсToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.треугольныйИмпульсToolStripMenuItem.Text = "Треугольный импульс";
            this.треугольныйИмпульсToolStripMenuItem.Click += new System.EventHandler(this.треугольныйИмпульсToolStripMenuItem_Click);
            // 
            // пилообразныйИмпульсToolStripMenuItem
            // 
            this.пилообразныйИмпульсToolStripMenuItem.Name = "пилообразныйИмпульсToolStripMenuItem";
            this.пилообразныйИмпульсToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.пилообразныйИмпульсToolStripMenuItem.Text = "Пилообразный импульс";
            this.пилообразныйИмпульсToolStripMenuItem.Click += new System.EventHandler(this.пилообразныйИмпульсToolStripMenuItem_Click);
            // 
            // spectrummetrButton
            // 
            this.spectrummetrButton.Location = new System.Drawing.Point(798, 448);
            this.spectrummetrButton.Name = "spectrummetrButton";
            this.spectrummetrButton.Size = new System.Drawing.Size(237, 23);
            this.spectrummetrButton.TabIndex = 2;
            this.spectrummetrButton.Text = "Go to Spectrummetr";
            this.spectrummetrButton.UseVisualStyleBackColor = true;
            this.spectrummetrButton.Click += new System.EventHandler(this.spectrummetrButton_Click);
            // 
            // numericUpDownAmplitude
            // 
            this.numericUpDownAmplitude.Location = new System.Drawing.Point(693, 113);
            this.numericUpDownAmplitude.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAmplitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmplitude.Name = "numericUpDownAmplitude";
            this.numericUpDownAmplitude.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAmplitude.TabIndex = 3;
            this.numericUpDownAmplitude.Tag = "_amplitude";
            this.numericUpDownAmplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmplitude.ValueChanged += new System.EventHandler(this.numericUpDownAmplitude_ValueChanged);
            // 
            // labelAmplitude
            // 
            this.labelAmplitude.AutoSize = true;
            this.labelAmplitude.Location = new System.Drawing.Point(724, 136);
            this.labelAmplitude.Name = "labelAmplitude";
            this.labelAmplitude.Size = new System.Drawing.Size(53, 13);
            this.labelAmplitude.TabIndex = 4;
            this.labelAmplitude.Text = "Amplitude";
            this.labelAmplitude.Click += new System.EventHandler(this.label1_Click);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(873, 136);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.frequencyLabel.TabIndex = 6;
            this.frequencyLabel.Text = "Frequency";
            this.frequencyLabel.Click += new System.EventHandler(this.frequencyLabel_Click);
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Location = new System.Drawing.Point(842, 113);
            this.numericUpDownFrequency.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFrequency.TabIndex = 5;
            this.numericUpDownFrequency.Tag = "_frequency";
            this.numericUpDownFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.numericUpDownFrequency_ValueChanged);
            // 
            // labelPhase
            // 
            this.labelPhase.AutoSize = true;
            this.labelPhase.Location = new System.Drawing.Point(1021, 136);
            this.labelPhase.Name = "labelPhase";
            this.labelPhase.Size = new System.Drawing.Size(37, 13);
            this.labelPhase.TabIndex = 8;
            this.labelPhase.Text = "Phase";
            this.labelPhase.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDownPhase
            // 
            this.numericUpDownPhase.Location = new System.Drawing.Point(990, 113);
            this.numericUpDownPhase.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPhase.Name = "numericUpDownPhase";
            this.numericUpDownPhase.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPhase.TabIndex = 7;
            this.numericUpDownPhase.Tag = "_amplitude";
            this.numericUpDownPhase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPhase.ValueChanged += new System.EventHandler(this.numericUpDownPhase_ValueChanged);
            // 
            // buttonRegen
            // 
            this.buttonRegen.Location = new System.Drawing.Point(855, 177);
            this.buttonRegen.Name = "buttonRegen";
            this.buttonRegen.Size = new System.Drawing.Size(107, 66);
            this.buttonRegen.TabIndex = 9;
            this.buttonRegen.Text = "Regenerate";
            this.buttonRegen.UseVisualStyleBackColor = true;
            this.buttonRegen.Click += new System.EventHandler(this.buttonRegen_Click);
            // 
            // buttonAM
            // 
            this.buttonAM.Location = new System.Drawing.Point(855, 301);
            this.buttonAM.Name = "buttonAM";
            this.buttonAM.Size = new System.Drawing.Size(107, 59);
            this.buttonAM.TabIndex = 10;
            this.buttonAM.Text = "AM";
            this.buttonAM.UseVisualStyleBackColor = true;
            this.buttonAM.Click += new System.EventHandler(this.buttonAM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Frequency_AM";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(852, 366);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Tag = "_amplitude";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // oscilograph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAM);
            this.Controls.Add(this.buttonRegen);
            this.Controls.Add(this.labelPhase);
            this.Controls.Add(this.numericUpDownPhase);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.numericUpDownFrequency);
            this.Controls.Add(this.labelAmplitude);
            this.Controls.Add(this.numericUpDownAmplitude);
            this.Controls.Add(this.spectrummetrButton);
            this.Controls.Add(this.chartSignal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "oscilograph";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSignal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signalMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem;
        private System.Windows.Forms.Button spectrummetrButton;
        private Spectrummetr _spectrummetr;
        private double[] signal;
        private double _amplitude;
        private double _frequency;
        private double _phase;
        private double _frhigh;
        private string adres;
        private FunctionForSignals _function;
        private int lastOperation;
        private System.Windows.Forms.ToolStripMenuItem единичныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem меандрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гармоническийИмпульсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem косинусоидальныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синусоидальныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треугольныйИмпульсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пилообразныйИмпульсToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude;
        private System.Windows.Forms.Label labelAmplitude;
        private Label frequencyLabel;
        private NumericUpDown numericUpDownFrequency;
        private Label labelPhase;
        private NumericUpDown numericUpDownPhase;
        private Button buttonRegen;
        private Button buttonAM;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;

       
    }
}

