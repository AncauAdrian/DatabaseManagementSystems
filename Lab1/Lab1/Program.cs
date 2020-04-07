using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Lab1
{
    class Program
    {
        static void TestSql()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=DESKTOP-4NP2T6Q\\SQLEXPRESS;Initial Catalog=Lab1;Integrated Security=true";
            conn.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Vehicle", conn);
            int nr = (int)cmd.ExecuteScalar();
            Console.WriteLine(nr);


            cmd = new SqlCommand("select count(*) from Vehicle", conn);

            int res = (int)cmd.ExecuteScalar();

            Console.WriteLine(res);

            conn.Close();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Vehicle", conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(ds, "Vehicles"); // Connection is auto. opened and closed

            DataRow dr = ds.Tables["Vehicles"].NewRow();
            dr["VIN"] = "TestVinC"; dr["CNP"] = 1910905405482; dr["Make"] = "TestC"; dr["Model"] = "TestModel";
            ds.Tables["Vehicles"].Rows.Add(dr);

            da.Update(ds, "Vehicles");
        }

        static void Main(string[] args)
        {
            
        }
    }
}
