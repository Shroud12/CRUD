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
    public partial class ForgotPassword : Form
    {
        DB connect = new DB();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connect.connection();
                string username = textUsername.Text;
                string password = textPassword.Text;
                string changequery = "UPDATE logininformation SET Password ='" + password + "' WHERE UserName = '" + username + "'";
                MySqlCommand changecommand = new MySqlCommand(changequery, connect.connection());
                changecommand.ExecuteNonQuery();
                MessageBox.Show("Password change successful!!!");
                connect.closeconnection();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
