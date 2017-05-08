namespace test
{
    partial class Status
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.testBtton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.para_Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Turbidity";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(718, 416);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Water Value";
            this.chart.Titles.Add(title1);
            // 
            // testBtton
            // 
            this.testBtton.Location = new System.Drawing.Point(373, 473);
            this.testBtton.Name = "testBtton";
            this.testBtton.Size = new System.Drawing.Size(75, 23);
            this.testBtton.TabIndex = 1;
            this.testBtton.Text = "Test";
            this.testBtton.UseVisualStyleBackColor = true;
            this.testBtton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parameter = ";
            // 
            // para_Label
            // 
            this.para_Label.AutoSize = true;
            this.para_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_Label.Location = new System.Drawing.Point(121, 465);
            this.para_Label.Name = "para_Label";
            this.para_Label.Size = new System.Drawing.Size(23, 24);
            this.para_Label.TabIndex = 1;
            this.para_Label.Text = "P";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pahang",
            "Sintok",
            "Kampung"});
            this.comboBox1.Location = new System.Drawing.Point(224, 473);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 514);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.para_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testBtton);
            this.Controls.Add(this.chart);
            this.Name = "Status";
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button testBtton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label para_Label;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}