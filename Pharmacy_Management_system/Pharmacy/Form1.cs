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
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Net.NetworkInformation.NetworkInterface[] nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
            //String sMacAddress = string.Empty;
            //foreach (System.Net.NetworkInformation.NetworkInterface adapter in nics)
            //{
            //    if (sMacAddress == String.Empty)// only return MAC Address from first card  
            //    {
            //        System.Net.NetworkInformation.IPInterfaceProperties properties = adapter.GetIPProperties();
            //        sMacAddress = adapter.GetPhysicalAddress().ToString();
            //    }
            //}
            //if (sMacAddress == "F04DA2237F13")
            //{
            //    button1.Enabled = true;
            //    button2.Enabled = true;
            //    button3.Enabled = true;
            //    button4.Enabled = true;
            //    button6.Enabled = true;
            //    button7.Enabled = true;
            //    button5.Enabled = true;
            //    button8.Enabled = true;
            //    button14.Enabled = true;
            //    button13.Enabled = true;
            //    button12.Enabled = true;
            //}
            //else
            //{
            //    button1.Enabled = false;
            //    button2.Enabled = false;
            //    button3.Enabled = false;
            //    button4.Enabled = false;
            //    button6.Enabled = false;
            //    button7.Enabled = false;
            //    button5.Enabled = false;
            //    button8.Enabled = false;
            //    button14.Enabled = false;
            //    button13.Enabled = false;
            //    button12.Enabled = false;
            //}
        }

        private void button15_Click(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee Employee1 = new Employee();
            Employee1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer Customer1 = new Customer();
            Customer1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supplier Supplier1 = new Supplier();
            Supplier1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product Product1 = new Product();
            Product1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stock Stock1 = new Stock();
            Stock1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DrugCatogery DrugCatogery1 = new DrugCatogery();
            DrugCatogery1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Section Section1 = new Section();
            Section1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Order Order1 = new Order();
            Order1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Attendence a1 = new Attendence();
            a1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Attendence2 a2 = new Attendence2();
            a2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dangerzone d1 = new Dangerzone();
            d1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
