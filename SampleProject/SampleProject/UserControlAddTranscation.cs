using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SampleProject.Types;

namespace SampleProject
{
    public partial class UserControlAddTranscation : UserControl
    {
        public UserControlAddTranscation()
        {
            InitializeComponent();
        }

        private List<Product> selectedProducts = new List<Product>();

        private void UserControlAddTranscation_Load(object sender, EventArgs e)
        {
            comboStore.DataSource = GetAllStores();
            comboStore.DisplayMember = "StoreName";
            comboStore.ValueMember = "StoreId";
            //cmbCategory.DataSource = GetAllCategories();
            //cmbCategory.DisplayMember = "Name";
            //cmbCategory.ValueMember = "Id";

            listBoxCategory.DataSource = GetAllCategories();
            listBoxCategory.DisplayMember = "Name";
            listBoxCategory.ValueMember = "Id";
            listBoxCategory.SelectionMode = SelectionMode.One;
            
        }

        private string GetSQLQueryForStore()
        {
            string _sql = string.Empty;
            _sql = "SELECT * FROM StoreMaster";
            return _sql;

        }

        private string GetSQLQueryForCategory()
        {
            string _sql = string.Empty;
            _sql = "SELECT * FROM Categories";
            return _sql;

        }

        private string GetSQLQueryForProducts(int categoryId)
        {
            string _sql = string.Empty;
            _sql = string.Format("SELECT * FROM Products WHERE CategoryID = {0}",categoryId.ToString());
            return _sql;

        }

        private List<Store> GetAllStores()
        {
            List<Store> allStoresList = new List<Store>();
           // string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SAMPLEPROJECT (1)\SAMPLEPROJECT\SAMPLEPROJECT\SAMPLEPROJECT\APP_DATA\DB.MDF;Integrated Security=True;User Instance=True";
            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
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


        private List<Category> GetAllCategories()
        {
            List<Category> allCategoryList = new List<Category>();
            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            
            //string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SAMPLEPROJECT (1)\SAMPLEPROJECT\SAMPLEPROJECT\SAMPLEPROJECT\APP_DATA\DB.MDF;Integrated Security=True;User Instance=True";
            string _sql = GetSQLQueryForCategory();
            SqlConnection _connection = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand(_sql, _connection);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            for (int i = 0; i < _table.Rows.Count; i++)
            {
                allCategoryList.Add(new Category()
                {
                    Id = Convert.ToInt32(_table.Rows[i]["CategoryID"]),
                    Name = Convert.ToString(_table.Rows[i]["CategoryName"])
                });


            }
            return allCategoryList;
        }

        private List<Product> GetProductsByCategory(int categoryId)
        {
            List<Product> productsList = new List<Product>();

            string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            
            //string _connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SAMPLEPROJECT (1)\SAMPLEPROJECT\SAMPLEPROJECT\SAMPLEPROJECT\APP_DATA\DB.MDF;Integrated Security=True;User Instance=True";
            string _sql = GetSQLQueryForProducts(categoryId);
            SqlConnection _connection = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand(_sql, _connection);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            for (int i = 0; i < _table.Rows.Count; i++)
            {
                productsList.Add(new Product()
                {
                    Id = Convert.ToInt32(_table.Rows[i]["ProductID"]),
                    Name = Convert.ToString(_table.Rows[i]["ProductName"])
                });


            }
            return productsList;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Category category = cmbCategory.SelectedItem as Category;
            //int categoryId = category.Id;
            //List<Product> productList = GetProductsByCategory(categoryId);
            //listBox1.DataSource = productList;
            //listBox1.DisplayMember = "Name";
            //listBox1.ValueMember = "Id";
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            
            foreach (var item  in (listBox1.SelectedItems))
            {
                Product product = item as Product;
                if(selectedProducts.FindAll(n=>n.Id == product.Id).Count == 0 )
                {
                    product.Quantity = 1;
                    product.NameQuantity = String.Format("{0} ({1})", product.Name, product.Quantity.ToString());
                    selectedProducts.Add(product);
                }
                else if(selectedProducts.FindAll(n=>n.Id == product.Id).Count > 0 )
                {
                    Product existingProduct = selectedProducts.Find(n => n.Id == product.Id);
                    existingProduct.Quantity++;
                    product.NameQuantity = String.Format("{0} ({1})", product.Name, product.Quantity.ToString());
                }

            }
            listBox2.DataSource = null;
            listBox2.DataSource = selectedProducts;
            listBox2.DisplayMember = "NameQuantity";
            listBox2.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32 newOrder = 0;
            string sql =
                "INSERT INTO Orders (CustomerID,OrderDate,StoreID) VALUES (@CustomerId,@OrderDate,@StoreId); "
                + "SELECT CAST(scope_identity() AS int)";

            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\Administrator\Desktop\SampleProject (1)\SampleProject\SampleProject\SampleProject\App_Data\DB.mdf;Integrated Security=True;User Instance=True";
            
            //string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SAMPLEPROJECT (1)\SAMPLEPROJECT\SAMPLEPROJECT\SAMPLEPROJECT\APP_DATA\DB.MDF;Integrated Security=True;User Instance=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int);
                cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@StoreId", SqlDbType.Int);
                cmd.Parameters["@CustomerId"].Value = 1;
                cmd.Parameters["@OrderDate"].Value = DateTime.Now;
                Store store = comboStore.SelectedItem as Store;
                cmd.Parameters["@StoreId"].Value = store.StoreId;
                try
                {
                    conn.Open();
                    newOrder = (Int32)cmd.ExecuteScalar();
                    foreach (var product in selectedProducts)
                    {
                        string sqlOrderDetails =
                            "INSERT INTO OrderDetails (OrderID,ProductID,Quantity) VALUES (@OrderID,@ProductID,@Quantity); ";
                        using (SqlConnection connOrderDetails = new SqlConnection(connString))
                        {
                            SqlCommand cmdOrderDetails = new SqlCommand(sqlOrderDetails, connOrderDetails);
                            cmdOrderDetails.Parameters.Add("@OrderID", SqlDbType.Int);
                            cmdOrderDetails.Parameters.Add("@ProductID", SqlDbType.Int);
                            cmdOrderDetails.Parameters.Add("@Quantity", SqlDbType.Int);
                            cmdOrderDetails.Parameters["@OrderID"].Value = newOrder;
                            cmdOrderDetails.Parameters["@ProductID"].Value = product.Id;
                            cmdOrderDetails.Parameters["@Quantity"].Value = product.Quantity;
                            try
                            {
                                connOrderDetails.Open();
                                cmdOrderDetails.ExecuteNonQuery();
                                connOrderDetails.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            MessageBox.Show(string.Format("Order Number is {0}", newOrder.ToString()));
            selectedProducts.RemoveAll(n => n.Id > 0);
            listBox2.DataSource = null;
            
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = listBoxCategory.SelectedItem as Category;
            int categoryId = category.Id;
            List<Product> productList = GetProductsByCategory(categoryId);
            listBox1.DataSource = productList;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
        }
    }
}
