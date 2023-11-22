using System;
using System.Data;
using System.Data.SqlClient;

namespace Estacionamento
{
    public class DataBaseAcess
    {
       private static SqlConnection conn;

        public static SqlConnection ConnOpen()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source =.\SQLEXPRESS;Initial Catalog= Auto_Car_Parkingdb;Intregated Security=false");
            }
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }
        public static bool InsertUpdateDelete(string query)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, ConnOpen()))
                {
                    int noofrows = cmd.ExecuteNonQuery();
                    if (noofrows > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
            public static DataTable Select(string query)
            {
            DataTable dt = new DataTable();
            try
                {
                    using ( SqlDataAdapter da = new SqlDataAdapter(query, ConnOpen()))
                    {
                        da.Fill(dt);
                       
                    }
                    return dt;
                }
                catch
                {
                    return dt;
                }
            
            }
        }
    }
