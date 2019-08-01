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
    class update_user_database
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "pharma.mdf";
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
       static SqlCommand cmd = new SqlCommand();
        
        
            public bool updateemployee(string name, int age, string address, DateTime hire, string contact)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update employee set Full_Name=@Full_name,Age=@Age,Address=@Address,Hiring_date=@Hiring_date,Contact=@Contact where Full_Name=@Full_Name";
            cmd.Connection = con;
            cmd.Parameters.Add("@Full_Name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = age;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@Hiring_date", SqlDbType.DateTime).Value = hire;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = contact;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool updatesupplier(string name, string address,  string contact)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update supplier set Name=@Name,Address=@Address,Contact=@Contact where Name=@Name";
            cmd.Connection = con;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = contact;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool updateproduct(string drugtype, string sectionno, string productn, string potency)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update product set Drug_type=@Drug_type,Section_no=@Section_no,Product_name=@Product_name ,Potency=@Potency where Product_name=@Product_name";
            cmd.Connection = con;
            cmd.Parameters.Add("@Drug_type", SqlDbType.VarChar).Value = drugtype;
            cmd.Parameters.Add("@Section_no", SqlDbType.VarChar).Value = sectionno;
            cmd.Parameters.Add("@Product_name", SqlDbType.VarChar).Value = productn;
            cmd.Parameters.Add("@Potency", SqlDbType.VarChar).Value = potency;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool updatestock(string batch_no,string Product_name, int Quantity, float buying_price, float selling_price,  DateTime bought)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update stock set Batch_no=@batch_no,Product_name=@Product_name,Quantity=@Quantity,Buying_price_perunit=@Buying_price_perunit,Selling_price_perunit=@Selling_price_perunit,Bought_date=@Bought_date where Product_name=@Product_name";
            cmd.Connection = con;
            cmd.Parameters.Add("@Batch_no", SqlDbType.VarChar).Value = batch_no;
            cmd.Parameters.Add("@Product_name", SqlDbType.VarChar).Value = Product_name;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity;
            cmd.Parameters.Add("@Buying_price_perunit", SqlDbType.Float).Value = buying_price;
            cmd.Parameters.Add("@Selling_price_perunit", SqlDbType.Float).Value = selling_price;
            cmd.Parameters.Add("@Bought_date", SqlDbType.DateTime).Value = bought;



            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
    }
}
