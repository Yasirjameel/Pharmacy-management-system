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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            show();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == " " || textBox3.Text == string.Empty || textBox4.Text == " ")

            {
                MessageBox.Show("Please fill all the required fields");
            }
            else {
                try
                {
                    {
                        Pharmacy_Yasir.Add_user_Database db = new Add_user_Database();
                        DateTime date = DateTime.Parse(dateTimePicker1.Text);
                        int age = int.Parse(textBox2.Text);
                        bool employee = db.employee(textBox1.Text, age, textBox3.Text, date, textBox4.Text);

                        MessageBox.Show("Record Added Successfully");
                        textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
                        show();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error Code 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void show()
        {
            Pharmacy_Yasir.Show_database db = new Show_database();
            DataSet ds = new DataSet();
            ds = db.Bindemployee();
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].ToString();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please enter full name to delete");

            }
            else
            {
                try
                {
                    Pharmacy_Yasir.delete_data_base_table db = new delete_data_base_table();
                    bool Deleteuser = db.Deleteemployee(textBox5.Text);


                    MessageBox.Show("Record Deleted Successfully");
                    textBox5.Clear();
                    show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Pharmacy_Yasir.update_user_database db = new update_user_database();
                int con = int.Parse(textBox2.Text);
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                bool updateemployee = db.updateemployee(textBox1.Text, con, textBox3.Text,date, textBox4.Text);


                MessageBox.Show("Record Updated Successfully");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
                show();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter name to update", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet4.employee' table. You can move, or remove it, as needed.
           

        }
    }
}
