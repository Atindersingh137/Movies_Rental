using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Movies_Rental
{
   
    public class Database

    {
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-52CB3J4K\SQLEXPRESS;Initial Catalog=VBMOVIESFULLDATA.MDF;Integrated Security=True;");
        public SqlCommand cmd;
        public SqlDataReader dr;
        public string proid;
        public SqlDataAdapter da;
        public string sql;
        public bool Mode = true;
        public string id;

        //public DataTable load()
        //{

        //    sql = "select * from Customer";
        //    cmd = new SqlCommand(sql, con);
        //    con.Open();
        //    DataTable dgvcCustomer = new DataTable();
        //    //dr = cmd.ExecuteReader();

        //    dgvcCustomer.Rows.Clear();

        //    using (da = new SqlDataAdapter(sql, con))
        //    {
        //        da.Fill(dgvcCustomer);

        //    }
        //    con.Close();
        //    return dgvcCustomer;
        //}

        public string Checkdb()
        {
            return con.Database;
        }
        
        public string TOPMovie()
        {

            con.Open();

            sql = "SELECT MovieIDFK, COUNT(*) AS Rep FROM RentedMovies GROUP BY MovieIDFK ORDER BY Rep DESC";

            cmd = new SqlCommand(sql, con);

            var result = cmd.ExecuteScalar().ToString();

            con.Close();

            return result;
        }

        public void getid(string CustID, string FN, string LN, string A, string M)
        {
            sql = "select * from Customer where CustID = '" + CustID + "' ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CustID = dr[0].ToString();
                FN = dr[1].ToString();
                LN = dr[2].ToString();
                A = dr[3].ToString();
                M = dr[4].ToString();

            }
            con.Close();
        }
        public string TopCustomer()
        {
            con.Open();

           sql = "SELECT CustIDFK, COUNT(*) AS Rep FROM RentedMovies GROUP BY CustIDFK ORDER BY Rep DESC";

            cmd = new SqlCommand(sql, con);

            var result = cmd.ExecuteScalar().ToString();

            con.Close();

            con.Open();

            Console.WriteLine(result);

            sql = "SELECT FirstName, LastName FROM Customer WHERE CustID = " + result;

            cmd = new SqlCommand(sql, con);

            dr = cmd.ExecuteReader();

            string output = "";

            while (dr.Read())
            {
                output = dr["FirstName"].ToString();
                output += " ";
                output += dr["LastName"].ToString();
            }

            con.Close();

            return output;
        }
    }
}
