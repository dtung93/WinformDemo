using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class DataProvider
    {
        private static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8P863OK\TUNG;Initial Catalog=VinShop;Integrated Security=True");

        private static SqlDataAdapter adapter = new SqlDataAdapter();        

        public DataProvider()
        {

        }

        private static SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public static DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                DataTable dtb = new DataTable();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = OpenConnection(),
                    CommandText = query
                };
                cmd.Parameters.AddRange(parameters);
                adapter.SelectCommand = cmd;
                adapter.Fill(dtb);
                conn.Close();
                return dtb;
            }
           
            catch (Exception e)
            {
                return null;
            }
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = OpenConnection(),
                    CommandText = query
                };
                cmd.Parameters.AddRange(parameters);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
            catch (Exception e)
            {
       
                return -1;
            }
        }
    }
}
