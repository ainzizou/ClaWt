namespace test
{
    partial class Database
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.recordTable = new System.Windows.Forms.DataGridView();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.FinishDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.sort = new System.Windows.Forms.Button();
            this.cheSintok = new System.Windows.Forms.CheckBox();
            this.chePenang = new System.Windows.Forms.CheckBox();
            this.cheKampong = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // recordTable
            // 
            this.recordTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordTable.Location = new System.Drawing.Point(12, 12);
            this.recordTable.Name = "recordTable";
            this.recordTable.Size = new System.Drawing.Size(798, 267);
            this.recordTable.TabIndex = 0;
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "yyyy-MM-dd";
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(20, 287);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(81, 20);
            this.StartDate.TabIndex = 1;
            // 
            // FinishDate
            // 
            this.FinishDate.CustomFormat = "yyyy-MM-dd";
            this.FinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FinishDate.Location = new System.Drawing.Point(145, 287);
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.Size = new System.Drawing.Size(79, 20);
            this.FinishDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "to";
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(576, 282);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 4;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // cheSintok
            // 
            this.cheSintok.AutoSize = true;
            this.cheSintok.Location = new System.Drawing.Point(247, 288);
            this.cheSintok.Name = "cheSintok";
            this.cheSintok.Size = new System.Drawing.Size(56, 17);
            this.cheSintok.TabIndex = 5;
            this.cheSintok.Text = "Sintok";
            this.cheSintok.UseVisualStyleBackColor = true;
            // 
            // chePenang
            // 
            this.chePenang.AutoSize = true;
            this.chePenang.Location = new System.Drawing.Point(333, 288);
            this.chePenang.Name = "chePenang";
            this.chePenang.Size = new System.Drawing.Size(63, 17);
            this.chePenang.TabIndex = 6;
            this.chePenang.Text = "Penang";
            this.chePenang.UseVisualStyleBackColor = true;
            // 
            // cheKampong
            // 
            this.cheKampong.AutoSize = true;
            this.cheKampong.Location = new System.Drawing.Point(419, 287);
            this.cheKampong.Name = "cheKampong";
            this.cheKampong.Size = new System.Drawing.Size(71, 17);
            this.cheKampong.TabIndex = 7;
            this.cheKampong.Text = "Kampong";
            this.cheKampong.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 339);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Penang";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Sintok";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Kampong";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(763, 288);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cheKampong);
            this.Controls.Add(this.chePenang);
            this.Controls.Add(this.cheSintok);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.recordTable);
            this.MaximizeBox = false;
            this.Name = "Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recordTable;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker FinishDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.CheckBox cheSintok;
        private System.Windows.Forms.CheckBox chePenang;
        private System.Windows.Forms.CheckBox cheKampong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}