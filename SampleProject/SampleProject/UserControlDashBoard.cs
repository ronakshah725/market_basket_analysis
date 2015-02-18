using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AprioriAlgorithm;
using SampleProject.Types;

namespace SampleProject
{
    public partial class UserControlDashBoard : UserControl
    {
        public UserControlDashBoard()
        {
            InitializeComponent();
        }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            LoadDashBoard();
        }

        private void LoadDashBoard()
        {
            try
            {
                IApriori target = new Apriori();
                string[] _transactions;
                double _minSupport = (5 / 100);
                double _minConfidence = (10 / 100);
                IEnumerable<string> _items = GetItems();


                List<Item> listItems = new List<Item>();
                listItems = GetAllListItem();
                //IEnumerable<string>  _items = new string[5] { "a", "b", "c", "d", "e" };
                _transactions = GetTransaction();

                //string[]  _transactions = new string[4] { "acd", "bce", "abce", "be" };
                Output output = target.ProcessTransaction(0.2, 0.2, _items, _transactions);


                List<Item> freqList = new List<Item>();
                foreach (var item in output.FrequentItems)
                {

                    if(item.Name.Length == 1)
                    { freqList.Add(new Item() { Name = item.Name, Description = string.Empty, Support = item.Support }); }
                    
                }
                GetCommaSeperatedDescription(freqList, listItems);
                dataGridMaximumSoldProducts.AutoSize = true;
                dataGridMaximumSoldProducts.DataSource = CreateProductsList(freqList, listItems);
                dataGridMaximumSoldProducts.Columns[4].Visible = false;
                dataGridMaximumSoldProducts.Columns[5].Visible = false;

                //Chart
                chart1.Series["Series1"].Points.DataBindXY(freqList, "Description", freqList, "Support");
                chart1.ChartAreas[0].AxisY.Title = "Support";
                


            }
            catch (Exception ex)
            {

                string errMessage = ex.Message;
                MessageBox.Show(errMessage);
            }
        }


        private List<Product> CreateProductsList(List<Item> transList, List<Item> listItems)
        {
            List<Product> products;
            products = new List<Product>();
            try
            {

                foreach (Item product in transList)
                {
                    if (product.Name.Length == 1)
                    {
                        Item item = listItems.Find(n => n.Name == product.Name);
                        Product prod = new Product() { Id = item.Id, Name = item.Description, Price = item.Price, Category = item.Category };
                        products.Add(prod);
                    }

                }
            }
            catch (Exception ex)
            {

                string errMessage = ex.Message;
                MessageBox.Show(errMessage);
            }


            return products;
        }

        private void GetCommaSeperatedDescription(List<Item> transList, List<Item> listItems)
        {

            foreach (Item product in transList)
            {
                if (product.Name.Length == 1)
                {
                    product.Description = listItems.Find(n => n.Name == product.Name).Description;
                    product.Price = listItems.Find(n => n.Name == product.Name).Price;
                    product.Category = listItems.Find(n => n.Name == product.Name).Category;
                }
                

            }
        }

        private List<Item> GetAllListItem()
        {
            List<Item> itemList = new List<Item>();

            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            string _sql = "SELECT        Categories.*, Products.* FROM Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID";
            SqlConnection _connection = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand(_sql, _connection);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            for (int i = 0; i < _table.Rows.Count; i++)
            {
                itemList.Add(new Item() { Id = Convert.ToInt32(_table.Rows[i]["ProductID"]), Name = _table.Rows[i]["AliasName"].ToString(), Description = _table.Rows[i]["ProductName"].ToString(), Price = Convert.ToDouble(_table.Rows[i]["UnitPrice"]), Category = _table.Rows[i]["CategoryName"].ToString() });
            }
            return itemList;

        }

        private string[] GetItems()
        {
            string[] itemsarray;
            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
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
                string _sql = GetSQLQuery();
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

        private string GetSQLQuery()
        {
            string _sql;

            {
                //_sql = "SELECT * FROM [Transaction]";

                _sql =
                   "SELECT  OrderDetails.OrderID, OrderDetails.ProductID, Products.AliasName FROM OrderDetails INNER JOIN Orders ON OrderDetails.OrderID = Orders.OrderID  INNER JOIN Products ON OrderDetails.ProductID = Products.ProductID  ";

            }
            return _sql;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDashBoard();
        }

    }
}
