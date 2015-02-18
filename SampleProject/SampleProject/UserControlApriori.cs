using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AprioriAlgorithm;
using SampleProject.Types;

namespace SampleProject
{
    public partial class UserControlApriori : UserControl
    {
        private Output output;
        private List<Item> freqList;
        private List<Item> closedItems;
        private List<Item> MaximalItemSets;
        
        public UserControlApriori()
        {
            InitializeComponent();
        }

        

        private List<int> GetSelectedStores()
        {
            List<int> selectedStoreList = new List<int>();
            foreach (var store in storeList.CheckedItems)
            {
                Store storeObj = store as Store;
                selectedStoreList.Add(storeObj.StoreId);
            }
            return selectedStoreList;
        }

        private List<int> CreateWeekdayList()
        {
            List<int> weekdaysList = new List<int>();
            if (chkMonday.Checked || chkTuesday.Checked || chkWednesday.Checked || chkThursday.Checked || chkFriday.Checked || chkSaturday.Checked | chkSunday.Checked)
            {
                var checkBoxes = new Dictionary<string, bool>();

                LoopControls(checkBoxes, this.Controls);
                foreach (var checkBox in checkBoxes)
                {
                    switch (checkBox.Key)
                    {
                        case "chkSunday":
                            bool resultSunday;
                            checkBoxes.TryGetValue("chkSunday", out resultSunday);
                            if (resultSunday)
                            {
                                weekdaysList.Add(1);
                            }
                            break;
                        case "chkMonday":
                            bool resultMonday;
                            checkBoxes.TryGetValue("chkMonday", out resultMonday);
                            if (resultMonday)
                            {
                                weekdaysList.Add(2);
                            }
                            break;
                        case "chkTuesday":
                            bool resultTuesday;
                            checkBoxes.TryGetValue("chkTuesday", out resultTuesday);
                            if (resultTuesday)
                            {
                                weekdaysList.Add(3);
                            }
                            break;
                        case "chkWednesday":
                            bool resultWednesday;
                            checkBoxes.TryGetValue("chkWednesday", out resultWednesday);
                            if (resultWednesday)
                            {
                                weekdaysList.Add(4);
                            }
                            break;
                        case "chkThursday":
                            bool resultThursday;
                            checkBoxes.TryGetValue("chkThursday", out resultThursday);
                            if (resultThursday)
                            {
                                weekdaysList.Add(5);
                            }
                            break;
                        case "chkFriday":
                            bool resultFriday;
                            checkBoxes.TryGetValue("chkFriday", out resultFriday);
                            if (resultFriday)
                            {
                                weekdaysList.Add(6);
                            }
                            break;
                        case "chkSaturday":
                            bool resultSaturday;
                            checkBoxes.TryGetValue("chkSaturday", out resultSaturday);
                            if (resultSaturday)
                            {
                                weekdaysList.Add(7);
                            }
                            break;


                    }
                }

            }
            return weekdaysList;
        }

        private bool ValidateScreen()
        {
            bool result = true;
            int support = 0;
            int confidence = 0;
            ClearValidationErrors();

            if ((dtStartDate.Checked && !dtEndDate.Checked) || (!dtStartDate.Checked && dtEndDate.Checked))
            {
                MessageBox.Show("Please select both start and end date.", "Validaton Error");
                result = false;
            }
            if (string.IsNullOrEmpty(txtSupport.Text) ||  !Int32.TryParse(txtSupport.Text,out support) || (Convert.ToInt32(txtSupport.Text) > 100) || (Convert.ToInt32(txtSupport.Text) <= 0))
            {
                txtSupport.BackColor = Color.Red;
                MessageBox.Show("Please correct missing or invalid information : Support", "Validaton Error");
                result = false;
            }

            if ((string.IsNullOrEmpty(txtConfidence.Text)) || !Int32.TryParse(txtSupport.Text, out confidence) || (Convert.ToInt32(txtConfidence.Text) > 100) || (Convert.ToInt32(txtConfidence.Text) <= 0))
            {
                txtConfidence.BackColor = Color.Red;
                MessageBox.Show("Please correct missing or invalid information : Confidence", "Validaton Error");
                result = false;
            }
            if (storeList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at-least 1 store : Select Stores", "Validaton Error");
                result = false;
            }

            return result;
        }

        private void ClearValidationErrors()
        {
            txtSupport.BackColor = Color.White;
            txtConfidence.BackColor = Color.White;
        }


        private void LoopControls(Dictionary<string, bool> checkBoxes, Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                    checkBoxes.Add(control.Name, ((CheckBox)control).Checked);
                if (control.Controls.Count > 0)
                    LoopControls(checkBoxes, control.Controls);
            }
        }

        private string GetSQLQueryForStore()
        {
            string _sql = string.Empty;
            _sql = "SELECT * FROM StoreMaster";
            return _sql;

        }

        private List<Store> GetAllStores()
        {
            List<Store> allStoresList = new List<Store>();
            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            
            //string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SAMPLEPROJECT (1)\SAMPLEPROJECT\SAMPLEPROJECT\SAMPLEPROJECT\APP_DATA\DB.MDF;Integrated Security=True;User Instance=True";
            string _sql = GetSQLQueryForStore();
            SqlConnection _connection = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand(_sql, _connection);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            for (int i = 0; i < _table.Rows.Count; i++)
            {
                allStoresList.Add(new Store()
                {
                    StoreId = Convert.ToInt32(_table.Rows[i]["StoreID"]),
                    StoreName = Convert.ToString(_table.Rows[i]["StoreName"])
                });


            }
            return allStoresList;
        }



        private void UserControlApriori_Load(object sender, EventArgs e)
        {
            dtStartDate.Checked = false;
            dtEndDate.Checked = false;
            List<Store> allStores = GetAllStores();
            storeList.DataSource = allStores;
            storeList.DisplayMember = "StoreName";
            storeList.ValueMember = "StoreId";
            storeList.SelectedItem = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }



        #region Result

        private Panel resultPanel;
        private string _support;
        private string _confidence;
        private string _startDate;
        private string _endDate;
        private List<int> _weekendList;
        private List<int> _storeList;
        private int grpboxFrequentHeight;
        private int grpboxClosedHeight;
        private int grpMaximalItemsHeight;
        private int grpStrongRulesHeight;
        public void Result(string support, string confidence, List<int> selectedStoresList)
        {
            
            _support = support;
            _confidence = confidence;
            _storeList = selectedStoresList;
            _startDate = string.Empty;
            _endDate = string.Empty;
            if (_weekendList != null)
            {
                _weekendList.Clear();
            }
            

        }

        public void Result(string support, string confidence,List<int> selectedStoresList,DateTime startDate,DateTime endDate,List<int> weekendList)
        {
            
            _support = support;
            _confidence = confidence;
            _startDate = startDate.Date.ToString();
            _endDate = endDate.Date.ToString();
            _weekendList = weekendList;
            _storeList = selectedStoresList;
        }

        public void Result(string support, string confidence,List<int> selectedStoresList,  List<int> weekendList)
        {
            
            _support = support;
            _confidence = confidence;
            _weekendList = weekendList;
            _storeList = selectedStoresList;
            _startDate = string.Empty;
            _endDate = string.Empty;

            
        }

        private List<Item> GetAllListItem()
        {
            List<Item> itemList = new List<Item>();

            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
                   
            
            //"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            string _sql = "SELECT * FROM [Products]";
            SqlConnection _connection = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand(_sql, _connection);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            for (int i = 0; i < _table.Rows.Count; i++)
            {
                itemList.Add(new Item() { Id = Convert.ToInt32(_table.Rows[i]["ProductID"]), Name = _table.Rows[i]["AliasName"].ToString(), Description = _table.Rows[i]["ProductName"].ToString() });
            }
            return itemList;

        }

        private string[] GetItems()
        {
            string[] itemsarray;
            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            //@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            string _sql = "SELECT * FROM [Products]";
            SqlConnection _connection = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand(_sql, _connection);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            itemsarray = new string[_table.Rows.Count];

            for (int i = 0; i < _table.Rows.Count; i++)
            {
                itemsarray[i] = _table.Rows[i]["AliasName"].ToString();
            }

            return itemsarray;

        }
        
        private string[] GetTransaction()
        {
            string[] itemsarray;
            try
            {

                string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";

                //string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
                string _sql = GetSQLQuery(_startDate, _endDate, _weekendList);
                SqlConnection _connection = new SqlConnection(_connectionstring);
                SqlCommand _command = new SqlCommand(_sql, _connection);
                SqlDataAdapter _adapter = new SqlDataAdapter(_command);
                DataTable _table = new DataTable();
                _adapter.Fill(_table);


                var distinctOrderIdList = (from row in _table.AsEnumerable()
                                           select row.Field<int>("OrderID")).Distinct();
                itemsarray = new string[distinctOrderIdList.Count()];
                int i = 0;
                foreach (var order in distinctOrderIdList)
                {
                    var transcation = (from row in _table.AsEnumerable()
                                       where row.Field<int>("OrderID") == Convert.ToInt32(order)
                                       select row.Field<string>("AliasName")).ToList();
                    StringBuilder s = new StringBuilder();
                    foreach (var item in transcation)
                    {
                        s.Append(item);
                    }

                    //string transactionString = string.Join(",", transcation.Select(n => n.ToString()).ToArray());
                    itemsarray[i] = s.ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {

                string errorMessage = ex.Message;
                throw;
            }
            

            return itemsarray;

        }

        private string GetSQLQuery(string startDate,string endDate,List<int> weekdayList)
       {
           string _sql = string.Empty;
           if ((!string.IsNullOrEmpty(startDate)) && (weekdayList !=null && weekdayList.Count == 0))
           {
               //_sql = string.Format("SELECT * FROM [Transaction] WHERE (DateTime BETWEEN '{0}' AND '{1}') ", startDate, endDate);
               _sql = string.Format(
                  "SELECT  OrderDetails.OrderID, OrderDetails.ProductID, Products.AliasName FROM OrderDetails INNER JOIN Orders ON OrderDetails.OrderID = Orders.OrderID  INNER JOIN Products ON OrderDetails.ProductID = Products.ProductID WHERE Orders.StoreID IN ({0}) AND (Orders.OrderDate BETWEEN '{1}' AND '{2}')",
                  string.Join(",", _storeList.Select(n => n.ToString()).ToArray()), startDate, endDate);
               return _sql;
           }
           else if ((!string.IsNullOrEmpty(startDate)) && (weekdayList != null && weekdayList.Count > 0))
           {
               string weekdays = string.Join(",", weekdayList);
               //_sql = string.Format("SELECT * FROM [Transaction] WHERE ( (DateTime BETWEEN '{0}' AND '{1}') AND (DatePart(DW, DateTime) IN ({2})) )", startDate, endDate, weekdays);
              _sql =  string.Format(
                   "SELECT  OrderDetails.OrderID, OrderDetails.ProductID, Products.AliasName FROM OrderDetails INNER JOIN Orders ON OrderDetails.OrderID = Orders.OrderID  INNER JOIN Products ON OrderDetails.ProductID = Products.ProductID WHERE Orders.StoreID IN ({0}) AND (Orders.OrderDate BETWEEN '{1}' AND '{2}') AND (DatePart(DW, Orders.OrderDate) IN ({3}))",
                   string.Join(",", _storeList.Select(n => n.ToString()).ToArray()), startDate, endDate, weekdays);
               return _sql;
           }
           else if ((string.IsNullOrEmpty(startDate)) && (weekdayList != null && weekdayList.Count > 0))
           {
               string weekdays = string.Join(",", weekdayList);
               //_sql = string.Format("SELECT * FROM [Transaction] WHERE ( (DatePart(DW,DateTime) IN ({0})) )", weekdays);
               _sql = string.Format(
                   "SELECT  OrderDetails.OrderID, OrderDetails.ProductID, Products.AliasName FROM OrderDetails INNER JOIN Orders ON OrderDetails.OrderID = Orders.OrderID  INNER JOIN Products ON OrderDetails.ProductID = Products.ProductID WHERE Orders.StoreID IN ({0}) AND  (DatePart(DW,Orders.OrderDate) IN ({1}))  ",
                   string.Join(",", _storeList.Select(n => n.ToString()).ToArray()), weekdays);
               return _sql;
           }
           else
           {
               //_sql = "SELECT * FROM [Transaction]";

               _sql =  string.Format(
                   "SELECT  OrderDetails.OrderID, OrderDetails.ProductID, Products.AliasName FROM OrderDetails INNER JOIN Orders ON OrderDetails.OrderID = Orders.OrderID  INNER JOIN Products ON OrderDetails.ProductID = Products.ProductID WHERE (Orders.StoreID IN ({0}))",
                   string.Join(",", _storeList.Select(n => n.ToString()).ToArray()));
           }
           return _sql;

       }

        private void Result_Load()
        {
            IApriori target = new Apriori();
            string[] _transactions;
            double _minSupport = Convert.ToDouble(_support) / 100;
            double _minConfidence = Convert.ToDouble(_confidence) / 100;
            IEnumerable<string> _items = GetItems();
            

            List<Item> listItems ;
            listItems = GetAllListItem();
            //IEnumerable<string>  _items = new string[5] { "a", "b", "c", "d", "e" };
            _transactions = GetTransaction(); 

            //string[]  _transactions = new string[4] { "acd", "bce", "abce", "be" };
            output = target.ProcessTransaction(_minSupport, _minConfidence, _items, _transactions);

           
            CreateBackButton();

            //Frequent Items Section
            CreateFrequentItemsList(listItems,output);

            //Closed Items Section
            CreateClosedItemsSection(output, listItems);

            //Strong Rules Section
            CreateStrongRulesSection(output, listItems);

            //Maximal Items Section
            //To stop displaying Maximal Items section just comment out the below line i.e put "//" before CreateMaximalItemsSection(output, listItems);
            CreateMaximalItemsSection(output, listItems);

            

        }

        private void CreateBackButton()
        {
            Button btnBack = new Button(){Name = "btnBack",Text = "Back",Location = new Point(12,10)};
            btnBack.Click += new EventHandler(this.btn_Click);
            this.Controls.Add(btnBack);

            resultPanel = new Panel()
            {
                Name = "grpFrequentItems",
                Text = "Frequent Items",
                AutoSize = true,
                Location = new Point(12, 10)
            };
            this.Controls.Add(resultPanel);

        }
        void btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            resultPanel.Visible = false;
            resultPanel = null;


        }

        void btnViewPieGraphFrequentItems_Click(object sender, EventArgs e)
        {
           Graph graph = new Graph(freqList, "Pie","FrequentItems");
           graph.Width = 500;
           graph.Height = 400; 
           graph.StartPosition = FormStartPosition.CenterParent;
           graph.ShowDialog();

        }


        void btnViewBarGraphFrequentItems_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(freqList, "Bar", "FrequentItems");
            graph.Width = 500;
            graph.Height = 400;
            graph.StartPosition = FormStartPosition.CenterParent;
            graph.ShowDialog();

        }

        void btnViewBarGraphMaximalItems_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(MaximalItemSets, "Bar", "MaximalItems");
            graph.Width = 500;
            graph.Height = 400;
            graph.StartPosition = FormStartPosition.CenterParent;
            graph.ShowDialog();

        }


        void btnViewPieGraphMaximalItems_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(MaximalItemSets, "Pie", "MaximalItems");
            graph.Width = 500;
            graph.Height = 400; 
            graph.StartPosition = FormStartPosition.CenterParent;
            graph.ShowDialog();

        }
        


        private void CreateFrequentItemsList(List<Item> listItems, Output output)
        {
            freqList = new List<Item>();
            foreach (var item in output.FrequentItems)
            {

                freqList.Add(new Item() { Name = item.Name, Description = string.Empty, Support = item.Support });
            }
            GetCommaSeperatedDescription(freqList, listItems);
            
            GroupBox grpFrequentItems = new GroupBox()
                                            {
                                                Name = "grpFrequentItems",
                                                Text = "Frequent Items",
                                                AutoSize = true,
                                                Location = new Point(12,25)
                                              
                                            };

            resultPanel.Controls.Add(grpFrequentItems);
            if(freqList.Count > 0 )
            {
                Button btnViewPieGraphFrequentItems = new Button() { AutoSize = true, Name = "btnViewPieGraphFrequentItems", Text = "View Pie Chart", Location = new Point(grpFrequentItems.Location.X, (15)) };
                btnViewPieGraphFrequentItems.Click += new EventHandler(this.btnViewPieGraphFrequentItems_Click);
                grpFrequentItems.Controls.Add(btnViewPieGraphFrequentItems);


                Button btnViewBarGraphFrequentItems = new Button() { AutoSize = true, Name = "btnViewBarGraphFrequentItems", Text = "View Bar Graph", Location = new Point(grpFrequentItems.Location.X + 200, (15)) };
                btnViewBarGraphFrequentItems.Click += new EventHandler(this.btnViewBarGraphFrequentItems_Click);
                grpFrequentItems.Controls.Add(btnViewBarGraphFrequentItems);

                Label frequentItemslbl = new Label()
                {
                    Name = "frequentItemslbl",
                    Text = "Following are the products that are most frequently sold:",
                    Location = new Point(grpFrequentItems.Location.X, (grpFrequentItems.Location.Y + 30)),
                    AutoSize = true
                };

                grpFrequentItems.Controls.Add(frequentItemslbl);
                for (int i = 0; i < freqList.Count; i++)
                {
                    int x = grpFrequentItems.Location.X + 10;
                    int y = (frequentItemslbl.Location.Y + ((i + 1) * 20));
                    Label lbl = new Label()
                    {
                        Name = string.Format("lbl_{0}", i.ToString()),
                        Text = string.Format("{0}. {1}", (i + 1).ToString(), freqList[i].Description),
                        Location = new Point(x, y),
                        AutoSize = true,
                        Visible = true,
                    };

                    grpFrequentItems.Controls.Add(lbl);

                }
            }
            else
            {
                Label frequentItemslbl = new Label()
                {
                    Name = "frequentItemslbl",
                    Text = "No results found, please change search criteria",
                    Location = new Point(grpFrequentItems.Location.X, (grpFrequentItems.Location.Y + 30)),
                    AutoSize = true
                };

                grpFrequentItems.Controls.Add(frequentItemslbl);
            }

            this.grpboxFrequentHeight = (grpFrequentItems.Height+20);

            


        }
          
        //private void CreateTransactionSection(string[] transactions,List<Item> listItems)
        //{
        //    List<Item> transList = new List<Item>();
        //    foreach (var item in transactions)
        //    {
        //        transList.Add(new Item() { Name = item.Replace(",", ""), Description = string.Empty });
        //    }
        //    GetCommaSeperatedDescription(transList, listItems);
        //    listBox5.DataSource = transList;
        //    listBox5.DisplayMember = "Description";
        //}

        private void CreateClosedItemsSection(Output output,List<Item> listItems)
        {
            closedItems = new List<Item>();
            foreach (var item in output.ClosedItemSets.Keys)
            {
                closedItems.Add(new Item() { Name = item });
            }
            GetCommaSeperatedDescription(closedItems, listItems);
            //listBox2.DataSource = closedItems;
            GroupBox grpClosedItems = new GroupBox()
                                            {
                                                Name = "grpClosedItems",
                                                Text = "Closed Items",
                                                AutoSize = true,
                                                Location = new Point(12,(grpboxFrequentHeight+30))
                                              
                                            };

            resultPanel.Controls.Add(grpClosedItems);
            if(closedItems.Count > 0)
            {
                Label closedItemslbl = new Label()
                {
                    Name = "closedItemslbl",
                    Text = "Following are the closed items :",
                    Location = new Point(grpClosedItems.Location.X, 15),
                    AutoSize = true
                };

                grpClosedItems.Controls.Add(closedItemslbl);
                for (int i = 0; i < closedItems.Count; i++)
                {
                    int x = grpClosedItems.Location.X + 10;
                    int y = (closedItemslbl.Location.Y + ((i + 1) * 20));
                    Label lbl = new Label()
                    {
                        Name = string.Format("lbl_{0}", i.ToString()),
                        Text = string.Format("{0}. {1}", (i + 1).ToString(), closedItems[i].Description),
                        Location = new Point(x, y),
                        AutoSize = true,
                        Visible = true,
                    };

                    grpClosedItems.Controls.Add(lbl);
                }
            }
            else
            {
                Label closedItemslbl = new Label()
                {
                    Name = "closedItemslbl",
                    Text = "No results found, please change search criteria",
                    Location = new Point(grpClosedItems.Location.X, 15),
                    AutoSize = true
                };

                grpClosedItems.Controls.Add(closedItemslbl);
            }
            
            this.grpboxClosedHeight = (grpboxFrequentHeight+grpClosedItems.Height+20);


        }

        

        private void CreateStrongRulesSection(Output output, List<Item> listItems)
        {
            IList<string> strongRules = new List<string>();
            foreach (var item in output.StrongRules)
            {
                Item X = listItems.Find(n => n.Name == item.X);
                Item Y = listItems.Find(n => n.Name == item.Y);
                if(X != null && Y !=null)
                {
                    strongRules.Add(string.Concat(X.Description, "--->", Y.Description));
                }

                
            }
            //listBox4.DataSource = strongRules;
            //listBox4.DisplayMember = "Keys";
            GroupBox grpStrongRules = new GroupBox()
            {
                Name = "grpStrongRules",
                Text = "Strong Rules",
                AutoSize = true,
                Location = new Point(12, (grpboxClosedHeight + 30))    

            };

            resultPanel.Controls.Add(grpStrongRules);

            if(strongRules.Count > 0)
            {

                Label maximalItemslbl = new Label()
                {
                    Name = "strongRuleslbl",
                    Text = "Following are the most frequently sold product combinations:",
                    Location = new Point(grpStrongRules.Location.X, 15),
                    AutoSize = true
                };

                grpStrongRules.Controls.Add(maximalItemslbl);
                for (int i = 0; i < strongRules.Count; i++)
                {
                    int x = grpStrongRules.Location.X + 10;
                    int y = (maximalItemslbl.Location.Y + ((i + 1) * 20));
                    Label lbl = new Label()
                    {
                        Name = string.Format("lbl_{0}", i.ToString()),
                        Text = string.Format("{0}. {1}", (i + 1).ToString(), strongRules[i]),
                        Location = new Point(x, y),
                        AutoSize = true,
                        Visible = true,
                    };

                    grpStrongRules.Controls.Add(lbl);
                }
            }
            else
            {
                Label maximalItemslbl = new Label()
                {
                    Name = "strongRuleslbl",
                    Text = "No results found, please change search criteria",
                    Location = new Point(grpStrongRules.Location.X, 15),
                    AutoSize = true
                };

                grpStrongRules.Controls.Add(maximalItemslbl);
            }

            this.grpStrongRulesHeight = (grpboxClosedHeight + grpStrongRules.Height + 20);

        }


        private void CreateMaximalItemsSection(Output output, List<Item> listItems)
        {
            MaximalItemSets = new List<Item>();
            foreach (var item in output.MaximalItemSets)
            {
                if (!(item.Length > 1))
                { MaximalItemSets.Add(new Item() { Name = item }); }

            }
            GetCommaSeperatedDescription(MaximalItemSets, listItems);
            GroupBox grpMaximalItems = new GroupBox()
            {
                Name = "grpMaximalItems",
                Text = "Maximal Items",
                AutoSize = true,
                Location = new Point(12, (grpStrongRulesHeight + 30))

            };

            resultPanel.Controls.Add(grpMaximalItems);
            if (MaximalItemSets.Count > 0)
            {
                foreach (var maximalItemSet in MaximalItemSets)
                {
                    string query =
                        string.Format(
                            "SELECT Products.AliasName, COUNT(OrderDetails.ProductID) AS Count FROM OrderDetails INNER JOIN Products ON OrderDetails.ProductID = Products.ProductID WHERE  (Products.AliasName = '{0}') GROUP BY Products.AliasName",
                            maximalItemSet.Name);

                    string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";

                    SqlConnection _connection = new SqlConnection(_connectionstring);
                    SqlCommand _command = new SqlCommand(query, _connection);
                    SqlDataAdapter _adapter = new SqlDataAdapter(_command);
                    DataTable _table = new DataTable();
                    _adapter.Fill(_table);

                    if (_table.Rows.Count > 0)
                    {
                        maximalItemSet.Support = Convert.ToInt32(_table.Rows[0]["Count"]);
                    }


                }


                //listBox3.DataSource = MaximalItemSets;
                //listBox3.DisplayMember = "Description";



                Button btnViewPieGraphMaximalItems = new Button() { AutoSize = true, Name = "btnViewPieGraphMaximalItems", Text = "View Pie Chart", Location = new Point(grpMaximalItems.Location.X, (15)) };
                btnViewPieGraphMaximalItems.Click += new EventHandler(this.btnViewPieGraphMaximalItems_Click);
                grpMaximalItems.Controls.Add(btnViewPieGraphMaximalItems);


                Button btnViewBarGraphMaximalItems = new Button() { AutoSize = true, Name = "btnViewBarGraphMaximalItems", Text = "View Bar Graph", Location = new Point(grpMaximalItems.Location.X + 200, (15)) };
                btnViewBarGraphMaximalItems.Click += new EventHandler(this.btnViewBarGraphMaximalItems_Click);
                grpMaximalItems.Controls.Add(btnViewBarGraphMaximalItems);


                Label maximalItemslbl = new Label()
                {
                    Name = "maximalItemslbl",
                    Text = "Following are the maximal items :",
                    Location = new Point(grpMaximalItems.Location.X, 50),
                    AutoSize = true
                };

                grpMaximalItems.Controls.Add(maximalItemslbl);
                for (int i = 0; i < MaximalItemSets.Count; i++)
                {
                    if (!(MaximalItemSets[i].Name.Length > 1))
                    {
                        int x = grpMaximalItems.Location.X + 10;
                        int y = (maximalItemslbl.Location.Y + ((i + 1) * 20));
                        Label lbl = new Label()
                        {
                            Name = string.Format("lbl_{0}", i.ToString()),
                            Text = string.Format("{0}. {1}", (i + 1).ToString(), MaximalItemSets[i].Description),
                            Location = new Point(x, y),
                            AutoSize = true,
                            Visible = true,
                        };

                        grpMaximalItems.Controls.Add(lbl);
                    }

                }
            }
            else
            {
                Label maximalItemslbl = new Label()
                {
                    Name = "maximalItemslbl",
                    Text = "No results found, please change search criteria",
                    Location = new Point(grpMaximalItems.Location.X, 50),
                    AutoSize = true
                };

                grpMaximalItems.Controls.Add(maximalItemslbl);
            }

            this.grpMaximalItemsHeight = (grpStrongRulesHeight + grpMaximalItems.Height + 20);

        }

        private void GetCommaSeperatedDescription(List<Item> transList, List<Item> listItems)
        {
            foreach (Item product in transList)
            {
                if (product.Name.Length == 1)
                {
                    product.Description = listItems.Find(n => n.Name == product.Name).Description;
                }
                else
                {
                    for (int i = 0; i < product.Name.Length; i++)
                    {
                        product.Description = product.Description + listItems.Find(n => n.Name == product.Name.Substring((0 + i), 1)).Description + ",";


                    }

                    if (product.Description.EndsWith(","))
                    {
                        product.Description = product.Description.Remove(product.Description.Length - 1);
                    }
                }

            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateScreen())
                {
                    List<int> selectedStoresList = GetSelectedStores();

                    if (dtStartDate.Checked)
                    {
                        List<int> weekdaysSelectedList = CreateWeekdayList();
                        Result(txtSupport.Text, txtConfidence.Text, selectedStoresList, dtStartDate.Value, dtEndDate.Value, weekdaysSelectedList);
                        panel1.Visible = false;
                        Result_Load();
                    }
                    else if (chkMonday.Checked || chkTuesday.Checked || chkWednesday.Checked || chkThursday.Checked || chkFriday.Checked || chkSaturday.Checked | chkSunday.Checked)
                    {
                        List<int> weekdaysSelectedList = CreateWeekdayList();
                        Result(txtSupport.Text, txtConfidence.Text, selectedStoresList, weekdaysSelectedList);
                        panel1.Visible = false;

                        Result_Load();
                    }
                    else
                    {

                        Result(txtSupport.Text, txtConfidence.Text, selectedStoresList);
                        panel1.Visible = false;
                        Result_Load();

                    }


                }
            }
            catch (Exception ex)
            {
                  
                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSelectAll.Checked)
            {
                for(int i=0;i<storeList.Items.Count;i++)
                {
                    storeList.SetItemChecked(i,true);
                }
            }
            else
            {
                for (int i = 0; i < storeList.Items.Count; i++)
                {
                    storeList.SetItemChecked(i, false);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



    }
}
