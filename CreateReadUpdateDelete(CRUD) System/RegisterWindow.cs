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
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textUsername.Text;
                string password = textPassword.Text;
                DB connect = new DB();
                string regquery = "INSERT INTO logininformation (username,password) VALUES('" + username + "','" + password + "')";
                MySqlCommand regcmd = new MySqlCommand(regquery, connect.connection());
                regcmd.ExecuteNonQuery();
                MessageBox.Show("Your account has been registered succesfully");
                connect.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            closewindow();
        }
        private void closewindow()
        {
            this.Close();
        }
    }
}
