using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CreateReadUpdateDelete_CRUD__System
{
    public class DB
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public MySqlConnection connection()
        {
            try
            {
                server = "localhost";
                database = "schoolcrudsystem";
                uid = "root";
                password = "";

                string connstring;
                connstring = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";
                conn = new MySqlConnection(connstring);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conn;
        }
        
        public void closeconnection()
        {
            conn.Close();   
        }

      }
}
