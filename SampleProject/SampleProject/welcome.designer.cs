namespace SampleProject
{
    partial class welcome
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(111, 80);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(339, 33);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome Administrator";
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 378);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "     Copyright 2013 \r\nApriori Algorithm Based";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your software will now commence";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SampleProject.Properties.Resources.original;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWelcome);
            this.Name = "welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}