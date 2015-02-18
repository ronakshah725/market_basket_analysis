namespace SampleProject
{
    partial class UserControlAddTranscation
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboStore = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store :";
            // 
            // comboStore
            // 
            this.comboStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStore.FormattingEnabled = true;
            this.comboStore.Location = new System.Drawing.Point(111, 21);
            this.comboStore.Name = "comboStore";
            this.comboStore.Size = new System.Drawing.Size(153, 21);
            this.comboStore.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 199);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(294, 165);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(155, 199);
            this.listBox2.TabIndex = 5;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(199, 196);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 6;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(111, 60);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(155, 95);
            this.listBoxCategory.TabIndex = 9;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // UserControlAddTranscation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.comboStore);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAddTranscation";
            this.Size = new System.Drawing.Size(487, 470);
            this.Load += new System.EventHandler(this.UserControlAddTranscation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboStore;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxCategory;
    }
}
