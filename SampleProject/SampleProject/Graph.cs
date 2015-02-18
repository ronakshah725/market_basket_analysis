using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AprioriAlgorithm;

namespace SampleProject
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private List<Item> _output;
        private string graphType;
        private string graphFor;
        public Graph(List<Item> output,String graphType,String graphFor)
        {
            _output = output;
            if(graphFor == "FrequentItems")
            {
                if (graphType == "Pie")
                {
                    CreatePieChart();
                }
                else if (graphType == "Bar")
                {
                    CreateBarChart();
                }
            }
            else if (graphFor == "MaximalItems")
            {
                if (graphType == "Pie")
                {
                    CreatePieChart();
                }
                else if (graphType == "Bar")
                {
                    CreateBarChart();
                }
            }





        }
        private void CreatePieChart()
        {
            var chart1 = new Chart();

            // Create Chart Area
            ChartArea chartArea1 = new ChartArea();
            chartArea1.Area3DStyle.Enable3D = true;

            // Add Chart Area to the Chart
            chart1.ChartAreas.Add(chartArea1);

            // Create a data series
            Series series1 = new Series();
            series1.Label = "#PERCENT{P1}";

            for (int i = 0; i < _output.Count; i++)
            {
                var dataPoint = new DataPoint();
                dataPoint.YValues[0] = _output[i].Support;
                dataPoint.LegendText = _output[i].Description;


                dataPoint.IsValueShownAsLabel = true;

                series1.Points.Add(dataPoint);

                chart1.Legends.Add(new Legend(Text = _output[i].Description));
            }
            series1.ChartType = SeriesChartType.Pie;

            // Add series to the chart
            chart1.Series.Add(series1);

            // Set chart control location
            chart1.Location = new System.Drawing.Point(16, 48);

            // Set Chart control size
            chart1.Size = new System.Drawing.Size(400, 300);


            // Add chart control to the form
            this.Controls.AddRange(new System.Windows.Forms.Control[] { chart1 });
        }

        private void CreateBarChart()
        {
            


            // Create a Chart
            var chart2 = new Chart();
            chart2.BorderDashStyle = ChartDashStyle.Solid;
            chart2.BackSecondaryColor = Color.White;
            chart2.BackGradientStyle = GradientStyle.TopBottom;
            chart2.ForeColor = Color.LightBlue;
            chart2.BackColor = Color.PowderBlue;
            chart2.BorderColor = Color.Black;

            // Create Chart Area
            ChartArea chartArea1 = new ChartArea();
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisY.Title = "Support";

            // Add Chart Area to the Chart
            chart2.ChartAreas.Add(chartArea1);

            // Create a data series
            Series series1 = new Series();
            series1.Name = "Result";

            for (int i = 0; i < _output.Count; i++)
            {
                var dataPoint = new DataPoint();
                dataPoint.YValues[0] = Convert.ToInt32(_output[i].Support);
                dataPoint.AxisLabel = _output[i].Description;
                dataPoint.IsValueShownAsLabel = true;

                series1.Points.Add(dataPoint);
               
            }


            

            // Add series to the chart
            chart2.Series.Add(series1);
            //chart1.Series.Add(series2);

            // Set chart control location
            chart2.Location = new System.Drawing.Point(16, 48);

            // Set Chart control size
            chart2.Size = new System.Drawing.Size(400, 300);

            // Add chart control to the form
            this.Controls.AddRange(new System.Windows.Forms.Control[] { chart2 });








        }

        private void Graph_Load(object sender, EventArgs e)
        {
            
        }



    }
}
