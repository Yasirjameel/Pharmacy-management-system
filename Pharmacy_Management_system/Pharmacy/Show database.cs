using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace Pharmacy_Yasir
{
    class Show_database
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "pharma.mdf";
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
      
        public DataSet BindUsers()
        {
            
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From customer";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindemployee()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From employee";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindsupplier()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From supplier";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindproduct()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From product";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindcatogory()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From cato";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindorders()
        {
           
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From orders";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Binddetails()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From order_details";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindsection()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From section";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindstock()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From stock";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindopeaning()
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From opeaning";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindclosing()
        {

            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From closing";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Bindreceipt()
        {

            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From receipt";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Searchstock(string name)
        {

            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From stock where Product_name=@Product_name";
            cmd.Connection = con;
            cmd.Parameters.Add("@Product_name", SqlDbType.VarChar).Value = name;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Searchproduct(string name)
        {

            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From product where Product_name=@Product_name";
            cmd.Connection = con;
            cmd.Parameters.Add("@Product_name", SqlDbType.VarChar).Value = name;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
