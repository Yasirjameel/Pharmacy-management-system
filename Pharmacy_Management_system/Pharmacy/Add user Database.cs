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
    class Add_user_Database
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "pharma.mdf";
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLOCALDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");

       static  SqlCommand cmd = new SqlCommand();
        
        public bool employee(string name, int age, string address, DateTime hire, string contact)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into employee(Full_Name,Age,Address,Hiring_date,Contact )values (@Full_Name,@Age,@Address,@Hiring_date,@Contact )";
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
        public bool customer(string name, string address, string contact)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customer(Name,Address,Contact )values (@Name,@Address,@Contact )";
            cmd.Connection = con;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = contact;

            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool supplier(string nam, string address, string contact)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into supplier(Name,Address,Contact )values (@Name,@Address,@Contact )";
            cmd.Connection = con;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = nam;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = contact;

            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public bool product(string drugtype, string sectionno, string productn, string potency)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into product(Drug_type,Section_no,Product_name ,Potency)values (@Drug_type,@Section_no,@Product_name ,@Potency)";
            cmd.Connection = con;
            cmd.Parameters.Add("@Drug_type", SqlDbType.VarChar).Value = drugtype;
            cmd.Parameters.Add("@Section_no", SqlDbType.VarChar).Value = sectionno;
            cmd.Parameters.Add("@Product_name", SqlDbType.VarChar).Value = productn;
            cmd.Parameters.Add("@Potency", SqlDbType.VarChar).Value = potency;
            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool receipt(string c_name, string employe,string P_name,float ppp,int quantity)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into receipt(customer_name,employee,product_name,Price_per_unit,Quantity) values (@customer_name,@employee,@product_name,@Price_per_unit,@Quantity)";
            cmd.Connection = con;
            cmd.Parameters.Add("@customer_name", SqlDbType.VarChar).Value = c_name;
            cmd.Parameters.Add("@employee", SqlDbType.VarChar).Value = employe;
            cmd.Parameters.Add("@product_name", SqlDbType.VarChar).Value = P_name;
            cmd.Parameters.Add("@Price_per_unit", SqlDbType.Float).Value = ppp;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        
        public bool catogry(string cat)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into cato(catogery)values (@catogery )";
            cmd.Connection = con;
            cmd.Parameters.Add("@catogery", SqlDbType.VarChar).Value = cat;
            

            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool orders(DateTime datee)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into orders(ex)values (@Order_date )";
            cmd.Connection = con;
            cmd.Parameters.Add("@Order_date", SqlDbType.DateTime).Value = datee;
            cmd.Parameters.Clear();

            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool order_details(Decimal discount, Decimal ppp, int quantity)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into order_details(discount,price_per_unit,quantity)values (@discount,@price_per_unit,@quantity )";
            cmd.Connection = con;
            cmd.Parameters.Add("@discount", SqlDbType.Decimal).Value = discount;
            cmd.Parameters.Add("@price_per_unit", SqlDbType.Decimal).Value = ppp;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool section(string sno, string sdetail)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into section(Section_no,Section_detail)values (@Section_no,@Section_detail )";
            cmd.Connection = con;
            cmd.Parameters.Add("@Section_no", SqlDbType.VarChar).Value = sno;
            cmd.Parameters.Add("@Section_detail", SqlDbType.VarChar).Value = sdetail;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool stock(string batch_no,string pro,int Quantity,float buying_price,float selling_price,DateTime bought )
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into stock(Batch_no,Product_name,Quantity,Buying_price_perunit,Selling_price_perunit,Bought_date)values (@Batch_no,@Product_name,@Quantity,@Buying_price_perunit,@Selling_price_perunit,@Bought_date )";
            cmd.Connection = con;
            cmd.Parameters.Add("@Product_name", SqlDbType.VarChar).Value = pro;
            cmd.Parameters.Add("@Batch_no", SqlDbType.VarChar).Value = batch_no;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity;
            cmd.Parameters.Add("@Buying_price_perunit", SqlDbType.Decimal).Value =buying_price;
            cmd.Parameters.Add("@Selling_price_perunit", SqlDbType.Decimal).Value = selling_price;
            cmd.Parameters.Add("@Bought_date", SqlDbType.DateTime).Value = bought;
            


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool opeaning(DateTime op, string time)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into opeaning(Opeaning, Opeaning_Time)values (@Opeaning,@Opeaning_Time )";
            cmd.Connection = con;
            cmd.Parameters.Add("@Opeaning", SqlDbType.DateTime).Value = op;
            cmd.Parameters.Add("@Opeaning_Time", SqlDbType.VarChar).Value = time;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool closing(DateTime op, string time)
        {
            con.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into closing(Closing, Closing_Time)values (@Closing,@Closing_Time )";
            cmd.Connection = con;
            cmd.Parameters.Add("@Closing", SqlDbType.DateTime).Value = op;
            cmd.Parameters.Add("@Closing_Time", SqlDbType.VarChar).Value = time;


            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
    }
}

