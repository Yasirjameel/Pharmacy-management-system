using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Pharmacy_Yasir
{
    public partial class Dangerzone : Form
    {
        public Dangerzone()
        {
            InitializeComponent();
        }

        private void Dangerzone_Load(object sender, EventArgs e)
        {
            

            dangerzine();
        }
        private void dangerzine()
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "pharma.mdf";





            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
            try
            {
                DataTable dt = new DataTable();
                string sql = "Select * from stock Where Quantity<=10";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("No Quantity is less", "Error Code 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
