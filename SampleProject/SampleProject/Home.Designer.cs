namespace SampleProject
{
    partial class Home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabApriori = new System.Windows.Forms.TabPage();
            this.userControlApriori1 = new SampleProject.UserControlApriori();
            this.tabAddTransaction = new System.Windows.Forms.TabPage();
            this.userControlAddTranscation1 = new SampleProject.UserControlAddTranscation();
            this.userControlDashBoard1 = new SampleProject.UserControlDashBoard();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabApriori.SuspendLayout();
            this.tabAddTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabApriori);
            this.tabControl1.Controls.Add(this.tabAddTransaction);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 659);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.PowderBlue;
            this.tabDashboard.BackgroundImage = global::SampleProject.Properties.Resources.original;
            this.tabDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDashboard.Controls.Add(this.userControlDashBoard1);
            this.tabDashboard.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDashboard.Location = new System.Drawing.Point(4, 23);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDashboard.Size = new System.Drawing.Size(1037, 632);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.Click += new System.EventHandler(this.tabDashboard_Click_1);
            // 
            // tabApriori
            // 
            this.tabApriori.AutoScroll = true;
            this.tabApriori.BackColor = System.Drawing.Color.PowderBlue;
            this.tabApriori.Controls.Add(this.userControlApriori1);
            this.tabApriori.Location = new System.Drawing.Point(4, 23);
            this.tabApriori.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabApriori.Name = "tabApriori";
            this.tabApriori.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabApriori.Size = new System.Drawing.Size(1037, 632);
            this.tabApriori.TabIndex = 1;
            this.tabApriori.Text = "Apriori";
            // 
            // userControlApriori1
            // 
            this.userControlApriori1.AutoSize = true;
            this.userControlApriori1.BackColor = System.Drawing.Color.PowderBlue;
            this.userControlApriori1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlApriori1.Location = new System.Drawing.Point(11, 4);
            this.userControlApriori1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlApriori1.Name = "userControlApriori1";
            this.userControlApriori1.Size = new System.Drawing.Size(903, 540);
            this.userControlApriori1.TabIndex = 0;
            // 
            // tabAddTransaction
            // 
            this.tabAddTransaction.BackColor = System.Drawing.Color.PowderBlue;
            this.tabAddTransaction.Controls.Add(this.userControlAddTranscation1);
            this.tabAddTransaction.Location = new System.Drawing.Point(4, 23);
            this.tabAddTransaction.Name = "tabAddTransaction";
            this.tabAddTransaction.Size = new System.Drawing.Size(1037, 632);
            this.tabAddTransaction.TabIndex = 2;
            this.tabAddTransaction.Text = "Add Transaction";
            // 
            // userControlAddTranscation1
            // 
            this.userControlAddTranscation1.Location = new System.Drawing.Point(9, 16);
            this.userControlAddTranscation1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlAddTranscation1.Name = "userControlAddTranscation1";
            this.userControlAddTranscation1.Size = new System.Drawing.Size(710, 470);
            this.userControlAddTranscation1.TabIndex = 0;
            // 
            // userControlDashBoard1
            // 
            this.userControlDashBoard1.AutoSize = true;
            this.userControlDashBoard1.BackColor = System.Drawing.Color.PowderBlue;
            this.userControlDashBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashBoard1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashBoard1.Location = new System.Drawing.Point(4, 3);
            this.userControlDashBoard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlDashBoard1.Name = "userControlDashBoard1";
            this.userControlDashBoard1.Size = new System.Drawing.Size(1029, 626);
            this.userControlDashBoard1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1045, 659);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabApriori.ResumeLayout(false);
            this.tabApriori.PerformLayout();
            this.tabAddTransaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabApriori;
        private UserControlApriori userControlApriori1;
        private System.Windows.Forms.TabPage tabAddTransaction;
        private UserControlAddTranscation userControlAddTranscation1;
        private UserControlDashBoard userControlDashBoard1;
    }
}