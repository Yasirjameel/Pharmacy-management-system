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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            show();
            textBox3.Clear(); textBox7.Clear(); textBox4.Clear(); textBox5.Clear();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet7.stock' table. You can move, or remove it, as needed.
        
            show();
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "pharma.mdf";
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True"))


            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From supplier";
                cmd.Connection = con;
                DataTable ds = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);


                IList<string> sup = new List<string>();
                foreach (DataRow dr in ds.Rows)
                {
                    sup.Add(dr.Field<string>("Name"));

                }
                this.comboBox2.Items.AddRange(sup.ToArray<string>());
                this.comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From product";
                cmd.Connection = con;
                DataTable ds = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);


                IList<string> pro = new List<string>();
                foreach (DataRow dr in ds.Rows)
                {
                    pro.Add(dr.Field<string>("Product_name"));

                }
                this.comboBox1.Items.AddRange(pro.ToArray<string>());
                this.comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
            show();
        }
        private void add()
        {
            if (textBox7.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the required fields");
            }
            else
            {
                
                    {
                        int d1 = int.Parse(textBox3.Text);
                        float d2 = float.Parse(textBox4.Text);
                        float d3 = float.Parse(textBox5.Text);
                        DateTime dt1 = DateTime.Parse(dateTimePicker1.Text);
                        Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                        bool stock = db.stock(textBox7.Text, comboBox1.Text, d1, d2, d3, dt1);
                        textBox3.Clear(); textBox7.Clear(); textBox4.Clear(); textBox5.Clear(); 
                        show();

                    }
                }
                
            
        }
        private void show()
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Bindstock();
            dataGridView1.DataSource = ds.Tables[0];
            textBox7.Text = ds.Tables[0].ToString();
            textBox3.Clear(); textBox7.Clear(); textBox4.Clear(); textBox5.Clear(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();

        }
        #region function to update stock
        private void update()
        {
            if (textBox7.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty )
            {
                MessageBox.Show("Please fill all the required fields");
            }
            else
            {
                try
                {
                    {

                        int d1 = int.Parse(textBox3.Text);
                        float d2 = float.Parse(textBox4.Text);
                        float d3 = float.Parse(textBox5.Text);
                        DateTime dt1 = DateTime.Parse(dateTimePicker1.Text);
                        Pharmacy_Yasir.update_user_database db = new update_user_database();
                        bool updatestock = db.updatestock(textBox7.Text,comboBox1.Text, d1, d2, d3, dt1);
                        MessageBox.Show("Record Updated Successfully");
                        textBox3.Clear(); textBox7.Clear(); textBox4.Clear(); textBox5.Clear(); 
                        show();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 8", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        private void delete()
        {
            if (textBox7.Text == string.Empty)
            {
                MessageBox.Show("Please fill the required field");
            }
            else
            {
                try
                {
                    Pharmacy_Yasir.delete_data_base_table db = new delete_data_base_table();
                    bool Deleteuser = db.Deletestock(textBox7.Text);
                    MessageBox.Show("Record Deleted Successfully");
                    textBox7.Clear();

                    show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int d1 = int.Parse(textBox3.Text);
                UpdateQuantity(comboBox1.Text, d1);
                show();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Product name to update", "Error Code 15", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void UpdateQuantity(String Product_name, int Quantity)
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "pharma.mdf";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
            
            int OldQuantity = GetQuantity(comboBox1.Text, Quantity);

            int NewQuantity = OldQuantity + int.Parse(textBox3.Text);

            string sql = "update stock set Quantity=@Quantity where Product_name=@Product_name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Quantity", NewQuantity);//textbox6=Quantity;
            cmd.Parameters.AddWithValue("@Product_name", comboBox1.Text);//Textbox5=ProductID;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Quantity Updated");

            con.Close();
        }
        public int GetQuantity(String Product_name, int quantit)
        {


            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "pharma.mdf";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
  
            int quantity = 0;
            DataTable dt = new DataTable();
           
            string sql = "Select Quantity from stock Where Product_name=@Product_name";
           
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@Product_name", SqlDbType.VarChar).Value = Product_name;
            cmd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = quantit;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            con.Open(); 
            adapter.Fill(dt);
            quantity = int.Parse(dt.Rows[0]["Quantity"].ToString());
           

            return quantity;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Searchstock(comboBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
            textBox7.Text = ds.Tables[0].ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
    
