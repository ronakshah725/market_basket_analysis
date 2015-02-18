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
    public partial class login : Form
    {

        
        public login()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag = false;

           if (textBox1.Text.Equals(""))
            {

                MessageBox.Show("Please enter a valid user name!");
                flag = true;
                this.Refresh();                


            }
            if (textBox2.Text.Equals(""))
            {

                MessageBox.Show("Please enter a valid password!");
                flag = true;
                this.Refresh();

            }
            
            

            string username = textBox1.Text;

            string password = textBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True");

            con.Open();



            SqlCommand cmd = new SqlCommand("Select * from Registration where Username='" + username + "' and Password='" + password + "'", con);

            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            int i = dataSet.Tables[0].Rows.Count;

            int k = 0;

            
            while (k < i)
            {
               // flag = false;
                if (dataSet.Tables[k].Rows[k]["Username"].Equals(username) && dataSet.Tables[k].Rows[k]["Password"].Equals(password))
                {
                   
                        MessageBox.Show("Login successful!");
                        flag = true;
                        String strWelcome = "Welcome " + dataSet.Tables[k].Rows[k]["FirstName"].ToString() + " " + dataSet.Tables[k].Rows[k]["LastName"].ToString() + "!";
                        //MessageBox.Show(username);
                        welcome objWelcome= new welcome(strWelcome);
                       // welcome objWelcome = new welcome();
                        //objWelcome.
                    
                   // welcome.ActiveForm.Text = username;
                        this.Hide();
                        objWelcome.Show();
                        break;
                  
                }
                                   
                 else
                    
                {
                   
                    flag = false;
                                                          
                }

                k++;
               
            }


            if (flag == false)
            {
                MessageBox.Show("Login failed. Please try again!");
                textBox1.Clear();
                textBox2.Clear();
                
            }
            


               /* if (dataSet.Tables[0].Rows.Count > 0)
                {

                    //string username = dataSet.Tables[0].Rows[0]["FirstName"].ToString() + " " + dataSet.Tables[0].Rows[0]["LastName"].ToString();

                    //welcome.TextBlockName.Text = username; //Sending value from one form to another form.
                    //Navigates to Welcome Page//
                    // welcome.Show();
                    //MessageBox.Show("Welcome Mr. Vinit");
                    //Close();
                    this.Hide();


                    //MessageBox.Show("Welcome Manager!");



                    new welcome().Show();

                }*/

            

                con.Close();
                this.Refresh();
        }







        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
    }

