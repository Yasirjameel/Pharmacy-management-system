using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Pharmacy_Yasir
{
    public partial class Order : MetroFramework.Forms.MetroForm
    {
        int order = 1;
        decimal total = 0;

        public Order()
        {
            InitializeComponent();
            textBox2.Clear(); textBox3.Clear(); //txtTotal.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //    label5.Text = incomeing;
            try
            {
                string path = Path.GetFullPath(Environment.CurrentDirectory);
                string databaseName = "pharma.mdf";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True"))
                {
                    decimal quantity = 0;
                    DataTable dt = new DataTable();
                    string sql = "Select Quantity from stock Where Product_name= '" + comboBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    quantity = Decimal.Parse(dt.Rows[0]["Quantity"].ToString());
                    int choiceyouhave = int.Parse(textBox3.Text);
                    int youdemand = int.Parse(textBox5.Text);

                    if (youdemand > choiceyouhave)
                    {
                        MessageBox.Show("Quantity is low");

                    }
                    else
                    {
                        choiceyouhave = choiceyouhave - youdemand;
                        string sql2 = "update stock set Quantity=@Quantity where Product_name=@Product_name";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.Parameters.AddWithValue("@Quantity", choiceyouhave);
                        cmd2.Parameters.AddWithValue("@Product_name", comboBox1.Text);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        //  cal();
                        int d1 = int.Parse(textBox5.Text);
                        float d2 = float.Parse(textBox2.Text);
                        Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                        bool stock = db.receipt(textBox9.Text, comboBox2.Text, comboBox1.Text, d2, d1);

                        cal();
                    }
                }




                {

                    SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
                    DataTable dt = new DataTable();
                    con1.Open();
                    SqlDataReader myReader = null;


                    SqlCommand myCommand = new SqlCommand("select stock.Selling_price_perunit,stock.Quantity from stock INNER JOIN product ON product.s_id=product.s_id where stock.Product_name= '" + comboBox1.Text + "'", con1);

                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        textBox2.Text = (myReader["Selling_price_perunit"].ToString());
                        textBox3.Text = (myReader["Quantity"].ToString());

                    }

                    con1.Close();
                }



                
                    
                
            }
            catch (Exception)
            {
                MessageBox.Show("Fill the required fields", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       



        }
       // private void show()
        //{
         //   Pharmacy_Yasir.Show_database db = new Show_database();
           // DataSet ds = new DataSet();
            //ds = db.Bindreceipt();
            //dataGridView1.DataSource = ds.Tables[0];
            //comboBox1.Text = ds.Tables[0].ToString();

        //}

        private void Order_Load(object sender, EventArgs e)
        {
            //show();
            string path = Path.GetFullPath(Environment.CurrentDirectory);

            classBindingSource.DataSource = new List<Class>();

            string databaseName = "pharma.mdf";
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


                IList<string> sup = new List<string>();
                foreach (DataRow dr in ds.Rows)
                {
                    sup.Add(dr.Field<string>("Product_name"));

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
                cmd.CommandText = "Select * From employee";
                cmd.Connection = con;
                DataTable ds = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);


                IList<string> pro = new List<string>();
                foreach (DataRow dr in ds.Rows)
                {
                    pro.Add(dr.Field<string>("Full_Name"));

                }
                this.comboBox2.Items.AddRange(pro.ToArray<string>());
                this.comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            
            
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "pharma.mdf";
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
            DataTable dt = new DataTable();
            con1.Open();
            SqlDataReader myReader = null;


            SqlCommand myCommand = new SqlCommand("select stock.Selling_price_perunit,stock.Quantity from stock INNER JOIN product ON product.s_id=product.s_id where stock.Product_name= '" + comboBox1.Text + "'", con1);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                textBox2.Text = (myReader["Selling_price_perunit"].ToString());
                textBox3.Text = (myReader["Quantity"].ToString());
             //   incomeing = textBox2.Text;

            }
            con1.Close();
        }
    


        private void button4_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "pharma.mdf";
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True"))
            {
                decimal quantity = 0;
                DataTable dt = new DataTable();
                string sql = "Select Quantity from stock Where Product_name= '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                quantity = Decimal.Parse(dt.Rows[0]["Quantity"].ToString());
                int choiceyouhave = int.Parse(textBox3.Text);
                int youdemand = int.Parse(textBox5.Text);

                if (youdemand > choiceyouhave)
                {
                    MessageBox.Show("Quantity is low");

                }
                else {
                    choiceyouhave = choiceyouhave - youdemand;
                    string sql2 = "update stock set Quantity=@Quantity where Product_name=@Product_name";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.Parameters.AddWithValue("@Quantity", choiceyouhave);
                    cmd2.Parameters.AddWithValue("@Product_name", comboBox1.Text);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    
                }
            }

            {
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
                DataTable dt = new DataTable();
                con1.Open();
                SqlDataReader myReader = null;


                SqlCommand myCommand = new SqlCommand("select stock.Selling_price_perunit,stock.Quantity from stock INNER JOIN product ON product.s_id=product.s_id where stock.Product_name= '" + comboBox1.Text + "'", con1);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    textBox2.Text = (myReader["Selling_price_perunit"].ToString());
                    textBox3.Text = (myReader["Quantity"].ToString());

                }
                con1.Close();
                
            }
        }

        private void orderdetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                using (Form2 f2 = new Form2((classBindingSource.DataSource as List<Class>),

                    string.Format("{0}", total),
               //     string.Format("{0}", txtCash.Text),
               //     string.Format("{0}", Convert.ToInt16(txtCash.Text) - total),
                    DateTime.Now.ToString("{0:d/M/yyyy HH:mm:ss}")
                    ))

                {
                    
                    f2.ShowDialog();

                }
                dataGridView2.Rows.Clear();
                this.Close();
                //txtTotal.Text = string.Empty;
                //txtDisc.Text = string.Empty;
                //txtCash.Text = string.Empty;
                Order a = new Order();
                a.Show();
            }

            catch (Exception)
            {
                MessageBox.Show("Cant print untill all data is inserted", "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void cal()
        {
            //string prop = "gm sol";
            if (!string.IsNullOrEmpty(comboBox2.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {




                Class obj = new Class()
                {
                    ProductID = order++,ProductName = comboBox1.Text,CustomerName = textBox9.Text,EmployeeName = comboBox2.Text, ProductPrice = Convert.ToDecimal(textBox2.Text), ProductQty = Convert.ToInt16(textBox5.Text), DiscountPercent=Convert.ToInt16( txtDisc.Text)
                };

                total += obj.ProductPrice * obj.ProductQty;
                classBindingSource.Add(obj);
                classBindingSource.MoveLast();
                comboBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox3.Text = string.Empty;
                txtDisc.Text = string.Empty;
             //   txtTotal.Text = string.Format("{0}", total);


            }

        }

       public static string diss;
        public static string gt;


        // cLAUL
        private void button2_Click_1(object sender, EventArgs e)
        {
            //try
            //{
           //     string tot = txtTotal.Text;
           //     diss = textBox1.Text;
        //        decimal result = decimal.Parse(tot) - decimal.Parse(diss);
         //       textBox6.Text = result.ToString();

       //         gt = textBox6.Text;

                //change
             //   string cash = txtCash.Text;
              //  decimal show = int.Parse(cash) - total;
               // textBox8.Text = show.ToString();
                //change
            //}
           // catch (Exception)
            //{
              //  MessageBox.Show("Can not calculate until data is inserted", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}




        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
    
