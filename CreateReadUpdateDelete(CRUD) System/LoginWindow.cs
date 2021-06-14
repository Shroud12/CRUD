using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CreateReadUpdateDelete_CRUD__System
{
    public partial class LoginForm : Form
    {
  
        public LoginForm()
        { 
           InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textUsername.Text;
            string pass = textPassword.Text;
            DB connectionobj = new DB();
            string query = $"SELECT * FROM logininformation WHERE username = '{user}' AND password = '{pass}';";
            MySqlCommand cmd = new MySqlCommand(query,connectionobj.connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string user_r = reader.GetString("UserName");
                string pass_r = reader.GetString("Password");
                if (user == user_r && pass == pass_r)
                {
                    MessageBox.Show($"Welcome {user}!");
                    ControlWindow control = new ControlWindow();
                    control.Show();
                }
                else
                {
                    MessageBox.Show("Username and password does not match!");
                }
                connectionobj.closeconnection();
            }
            
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonLogin.PerformClick();

        }
    }
}
