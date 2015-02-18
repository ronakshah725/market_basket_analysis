using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleProject
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = ("E:\\Dell\\index.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayImage()
        {
            PictureBox imageControl = new PictureBox();
            imageControl.Width =0 ;
            imageControl.Height = 0;

            Bitmap image = new Bitmap("E:\\Dell\\index.jpg");
            imageControl.Dock = DockStyle.Fill;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
