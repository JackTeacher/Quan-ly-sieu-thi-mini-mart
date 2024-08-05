using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KetNoiDB
    {
        private static string servername = "DESKTOP-I82AJLH\\SQLEXPRESS";
        private static string dbName = "mini-mart";
        private static string username = "";
        private static string password = "";
        public static string connectionString = $"Data Source={servername};Initial Catalog={dbName};Integrated Security=True;Encrypt=False";
       // public static string connectionString = @"Data Source=ngoctin\TIN;Initial Catalog=mini-mart;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True";
        //public static string connectionString = @"Data Source=DESKTOP-QFAM29O\THU;Initial Catalog=mini-mart;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True";
        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
                }
                return dataTable;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}
