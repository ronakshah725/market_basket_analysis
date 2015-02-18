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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabApriori)
            {
                tabDashboard.Controls.Add(new UserControlApriori());
                this.userControlAddTranscation1.Visible = false;
                this.userControlApriori1.Visible = true;
                this.userControlDashBoard1.Visible = false;
            }
            if (tabControl1.SelectedTab == tabDashboard)
            {
                tabDashboard.Controls.Add(new UserControlDashBoard());
                this.userControlAddTranscation1.Visible = false;
                this.userControlApriori1.Visible = false;
                this.userControlDashBoard1.Visible = true;
            }
            if (tabControl1.SelectedTab == tabAddTransaction)
            {
                tabAddTransaction.Controls.Add(new UserControlAddTranscation());
                this.userControlAddTranscation1.Visible = true;
                this.userControlApriori1.Visible = false;
                this.userControlDashBoard1.Visible = false;
            }


        }

        private void Home_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabDashboard;
            tabDashboard.Controls.Add(new UserControlDashBoard());
        }

        private void tabDashboard_Click(object sender, EventArgs e)
        {

        }

        private void tabDashboard_Click_1(object sender, EventArgs e)
        {

        }
    }
}
