using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Site_Yonetim_Otomasyonu.Connection
{
    class ServerConnection
    {
        public static string stringConnection = "//TO DO";


        public static DataTable ExecuteSQL(string sql)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dataTable = new DataTable();

            try
            {
              
                connection.ConnectionString = stringConnection;
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dataTable);

                connection.Close();
                connection = null;
                return dataTable;

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Hata: "+ex.Message,
                "SQL Server Hatasi ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataTable = null;
            
            }

            return dataTable;

        }
    }
}
