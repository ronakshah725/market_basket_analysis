using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SampleProject
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        public welcome(String welcomeString)
        {
            InitializeComponent();
            labelWelcome.Text = welcomeString;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
