using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Status : Form
    {
        static private int parameter;

        public Status()
        {
            InitializeComponent();
            para_Label.Text = parameter.ToString();

        }

        public void setParameter(int a)
        {
            parameter = a;
        }

        public void chartArea()
        {

        }

        private double fun(double x)
        {
            
            return Math.Pow(2,x)*Math.Cos(Math.Pow(2,-x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1000);
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            for (int i = 0; i < 10; i++)
            {
                chart.Series[0].Points.AddXY(i, fun(i));
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
        }
    }
}
