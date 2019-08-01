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
    public partial class DrugCatogery : Form
    {
        public DrugCatogery()
        {
            InitializeComponent();
            show();
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void show()
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Bindcatogory();
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].ToString();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty )
            {
                MessageBox.Show("Please fill the required field");
            }
            else
            {
               
                {
                    Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                    bool catogry = db.catogry(textBox1.Text);
                    show();
                    textBox1.Clear();
                }
              
            }

        }

        private void DrugCatogery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet3.cato' table. You can move, or remove it, as needed.
         

        }
    }
}
