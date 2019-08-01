using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyCompleteSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
            groupBox2.Visible = false;
            groupBox3.Visible = false;


        }
        private static Login Instance;
        //New form Function
        public static Login Getinstance()
        {
            if (Instance == null || Instance.IsDisposed)
                Instance = new Login();
            else
                Instance.BringToFront();
                return Instance;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox2.Show();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox2.Hide();
            groupBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            image();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" & textBox2.Text == "12345")
            {
                MessageBox.Show("Succefull");
                // Parent obj = new Parent();
               // button2.Enabled = true;
                Hide();

            }
            else
            {
                MessageBox.Show("try Again");
            }


           // image();

        }

        //Image Upload Fun
        public void image()
        {
            string imagelocation = "";
            try
            {
                Parent obj = new Parent();

                OpenFileDialog dialoge = new OpenFileDialog();
                dialoge.Filter = "*.jpeg; *.bmp; *.png; *.jpg)| *.jpeg; *.bmp; *.png; *.jpg";
                if (dialoge.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialoge.FileName;
                    pictureBox1.ImageLocation = imagelocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Uploading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
