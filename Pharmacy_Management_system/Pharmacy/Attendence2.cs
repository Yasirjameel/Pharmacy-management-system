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
    public partial class Attendence2 : Form
    {
        public Attendence2()
        {
            InitializeComponent();
            show();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
        public void add()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the required field");
            }
            else
            {
                try
                {
                    {


                        DateTime dt1 = DateTime.Parse(dateTimePicker1.Text);
                        Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                        bool opeaning = db.closing(dt1, textBox1.Text);
                        textBox1.Clear();
                        show();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 10", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void show()
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Bindclosing();
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].ToString();
            textBox1.Clear();
        }

        private void Attendence2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet1.closing' table. You can move, or remove it, as needed.
           


        }
    }
}
