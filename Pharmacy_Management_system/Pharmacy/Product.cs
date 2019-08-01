using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Pharmacy_Yasir
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            show();
            textBox1.Clear(); textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please fill the required fields");
            }
            else
            {
                try
                {   
                        
                        
                    
                    
                        Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                        bool product = db.product(comboBox1.Text, comboBox2.Text, textBox1.Text, textBox2.Text);
                        MessageBox.Show("Record Added Successfully");
                        show();
                        comboBox1.Text = ""; comboBox2.Text = ""; textBox1.Clear(); textBox2.Clear();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
          

       }
        private void show()
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Bindproduct();
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].ToString();
            textBox1.Clear(); textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please fill the required field");
            }
            else
            {
                try {
                    Pharmacy_Yasir.delete_data_base_table db = new delete_data_base_table();
                    bool Deleteuser = db.Deleteproduct(textBox1.Text);


                    textBox1.Clear(); textBox2.Clear();
                    show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please fill the Required field");
            }
            else
            { try
                {
                    Pharmacy_Yasir.update_user_database db = new update_user_database();
                    bool updateemployee = db.updateproduct(comboBox1.Text, comboBox2.Text, textBox1.Text, textBox2.Text);


                    textBox1.Clear(); textBox2.Clear();
                    show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet5.product' table. You can move, or remove it, as needed.
           
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "pharma.mdf";
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True"))


            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From cato";
                cmd.Connection = con;
                DataTable ds = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);


                IList<string> sup = new List<string>();
                foreach (DataRow dr in ds.Rows)
                {
                    sup.Add(dr.Field<string>("catogery"));

                }
                this.comboBox1.Items.AddRange(sup.ToArray<string>());
                this.comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From section";
                cmd.Connection = con;
                DataTable ds = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);


                IList<string> pro = new List<string>();
                foreach (DataRow dr in ds.Rows)
                {
                    pro.Add(dr.Field<string>("Section_no"));

                }
                this.comboBox2.Items.AddRange(pro.ToArray<string>());
                this.comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Searchproduct(textBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            show();
        }
    }

}
