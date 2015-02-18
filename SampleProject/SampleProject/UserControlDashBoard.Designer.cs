namespace SampleProject
{
    partial class UserControlDashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridMaximumSoldProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaximumSoldProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMaximumSoldProducts
            // 
            this.dataGridMaximumSoldProducts.AllowUserToAddRows = false;
            this.dataGridMaximumSoldProducts.AllowUserToDeleteRows = false;
            this.dataGridMaximumSoldProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMaximumSoldProducts.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridMaximumSoldProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMaximumSoldProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaximumSoldProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridMaximumSoldProducts.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridMaximumSoldProducts.Location = new System.Drawing.Point(32, 66);
            this.dataGridMaximumSoldProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridMaximumSoldProducts.Name = "dataGridMaximumSoldProducts";
            this.dataGridMaximumSoldProducts.ReadOnly = true;
            this.dataGridMaximumSoldProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMaximumSoldProducts.Size = new System.Drawing.Size(433, 181);
            this.dataGridMaximumSoldProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highest Selling Products accross all stores";
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 273);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(430, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(35, 16);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UserControlDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMaximumSoldProducts);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlDashBoard";
            this.Size = new System.Drawing.Size(889, 590);
            this.Load += new System.EventHandler(this.UserControlDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaximumSoldProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMaximumSoldProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonRefresh;

    }
}
