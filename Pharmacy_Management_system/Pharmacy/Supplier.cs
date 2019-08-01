using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Yasir
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            show();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the required fields");
            }
            else
            {
                
                    Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                    bool customer = db.supplier(textBox1.Text, textBox2.Text, textBox3.Text);
                    MessageBox.Show("Record Added Successfully");
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                    show();
                
                
            }
        }
        private void show()
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Bindsupplier();
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].ToString();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Please type the correct name");
            }
            else
            {
                try
                {
                    Pharmacy_Yasir.delete_data_base_table db = new delete_data_base_table();
                    bool Deletesupplier = db.Deletesupplier(textBox4.Text);
                    textBox4.Clear();

                    
                    show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {    try

            {
                Pharmacy_Yasir.update_user_database db = new update_user_database();
                
               
                bool updatesupplier = db.updatesupplier(textBox1.Text, textBox2.Text,textBox3.Text);


               
                show();
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Fill all the required fields", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet8.supplier' table. You can move, or remove it, as needed.
          

        }
    }
}
