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
    class delete_data_base_table
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "pharma.mdf";
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
       static SqlCommand cmd = new SqlCommand();
        public bool Deleteemployee(string Name)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from employee where Full_Name=@Full_Name";

            cmd.Connection = con;
            cmd.Parameters.Add("@Full_Name", SqlDbType.NVarChar).Value = Name;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
            
        }
        public bool Deletesupplier(string Name)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from supplier where Name=@Name";

            cmd.Connection = con;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool Deleteproduct(string Name)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from product where Product_name=@Product_name";

            cmd.Connection = con;
            cmd.Parameters.Add("@Product_name", SqlDbType.NVarChar).Value = Name;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }
             public bool Deletestock(string batch)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from stock where Batch_no=@Batch_no";

            cmd.Connection = con;
            cmd.Parameters.Add("@Batch_no", SqlDbType.NVarChar).Value = batch;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

    }
}