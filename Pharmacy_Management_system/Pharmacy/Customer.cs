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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            show();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the required fields");
            }
            else
            {
                try
                {
                    {
                        Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                        bool customer = db.customer(textBox1.Text, textBox2.Text, textBox3.Text);
                        MessageBox.Show("Record Added Successfully");
                        textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                        show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void show()
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
        DataSet ds = new DataSet();
        ds = db.BindUsers();
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].ToString();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet2.customer' table. You can move, or remove it, as needed.
          

        }
    }
}
