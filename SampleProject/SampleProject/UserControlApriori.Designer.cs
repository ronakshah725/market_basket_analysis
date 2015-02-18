namespace SampleProject
{
    partial class UserControlApriori
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.storeList = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtSupport = new System.Windows.Forms.TextBox();
            this.txtConfidence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConfidence = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtSupport);
            this.panel1.Controls.Add(this.txtConfidence);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblConfidence);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 532);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 34;
            this.button1.Text = "Show Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSelectAll);
            this.groupBox2.Controls.Add(this.storeList);
            this.groupBox2.Location = new System.Drawing.Point(21, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(619, 164);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "* Select Store";
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(363, 25);
            this.checkBoxSelectAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(89, 18);
            this.checkBoxSelectAll.TabIndex = 1;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // storeList
            // 
            this.storeList.CheckOnClick = true;
            this.storeList.FormattingEnabled = true;
            this.storeList.Location = new System.Drawing.Point(12, 25);
            this.storeList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.storeList.Name = "storeList";
            this.storeList.ScrollAlwaysVisible = true;
            this.storeList.Size = new System.Drawing.Size(327, 89);
            this.storeList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSunday);
            this.groupBox1.Controls.Add(this.chkSaturday);
            this.groupBox1.Controls.Add(this.chkFriday);
            this.groupBox1.Controls.Add(this.chkThursday);
            this.groupBox1.Controls.Add(this.chkWednesday);
            this.groupBox1.Controls.Add(this.chkTuesday);
            this.groupBox1.Controls.Add(this.chkMonday);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Location = new System.Drawing.Point(21, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(619, 165);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Location = new System.Drawing.Point(412, 107);
            this.chkSunday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(52, 18);
            this.chkSunday.TabIndex = 35;
            this.chkSunday.Text = "Sun";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(348, 107);
            this.chkSaturday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(47, 18);
            this.chkSaturday.TabIndex = 34;
            this.chkSaturday.Text = "Sat";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Location = new System.Drawing.Point(291, 107);
            this.chkFriday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(45, 18);
            this.chkFriday.TabIndex = 33;
            this.chkFriday.Text = "Fri";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Location = new System.Drawing.Point(224, 107);
            this.chkThursday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(57, 18);
            this.chkThursday.TabIndex = 32;
            this.chkThursday.Text = "Thur";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Location = new System.Drawing.Point(151, 107);
            this.chkWednesday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(54, 18);
            this.chkWednesday.TabIndex = 31;
            this.chkWednesday.Text = "Wed";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Location = new System.Drawing.Point(83, 107);
            this.chkTuesday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(50, 18);
            this.chkTuesday.TabIndex = 30;
            this.chkTuesday.Text = "Tue";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Location = new System.Drawing.Point(12, 107);
            this.chkMonday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(55, 18);
            this.chkMonday.TabIndex = 29;
            this.chkMonday.Text = "Mon";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(316, 59);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.ShowCheckBox = true;
            this.dtEndDate.Size = new System.Drawing.Size(265, 22);
            this.dtEndDate.TabIndex = 28;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(287, 59);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 14);
            this.lblTo.TabIndex = 27;
            this.lblTo.Text = "to";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(12, 59);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.ShowCheckBox = true;
            this.dtStartDate.Size = new System.Drawing.Size(265, 22);
            this.dtStartDate.TabIndex = 26;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(8, 28);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(124, 14);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "Select Date Range";
            // 
            // txtSupport
            // 
            this.txtSupport.Location = new System.Drawing.Point(116, 13);
            this.txtSupport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSupport.Name = "txtSupport";
            this.txtSupport.Size = new System.Drawing.Size(132, 22);
            this.txtSupport.TabIndex = 36;
            // 
            // txtConfidence
            // 
            this.txtConfidence.Location = new System.Drawing.Point(116, 44);
            this.txtConfidence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfidence.Name = "txtConfidence";
            this.txtConfidence.Size = new System.Drawing.Size(132, 22);
            this.txtConfidence.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "* Support";
            // 
            // lblConfidence
            // 
            this.lblConfidence.AutoSize = true;
            this.lblConfidence.Location = new System.Drawing.Point(17, 44);
            this.lblConfidence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfidence.Name = "lblConfidence";
            this.lblConfidence.Size = new System.Drawing.Size(91, 14);
            this.lblConfidence.TabIndex = 37;
            this.lblConfidence.Text = "* Confidence";
            // 
            // UserControlApriori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlApriori";
            this.Size = new System.Drawing.Size(985, 582);
            this.Load += new System.EventHandler(this.UserControlApriori_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox storeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtSupport;
        private System.Windows.Forms.TextBox txtConfidence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConfidence;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;

    }
}
