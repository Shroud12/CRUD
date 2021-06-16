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
    public partial class AdminWindow : Form
    {
        DB connect = new DB();
        private bool mouseDown;
        private Point lastLocation;
        
        public AdminWindow()
        {
            InitializeComponent();
            LoginForm wind = new LoginForm();
            wind.Close();
            showgrid();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                connect.connection();
                string username = textUsername.Text;
                string password = textPassword.Text;
                string updatequery = "UPDATE logininformation SET Password = '" + password + "' WHERE UserName = '" + username + "'";
                MySqlCommand updcmd = new MySqlCommand(updatequery, connect.connection());
                updcmd.ExecuteNonQuery();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showgrid();
  
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.connection();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = row.Cells["UserId"].Value.ToString();
                string delquery = "DELETE FROM logininformation WHERE UserId = '" + id + "'";
                MySqlCommand delcmd = new MySqlCommand(delquery, connect.connection());
                delcmd.ExecuteNonQuery();
                connect.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showgrid();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textUsername.Text = row.Cells["UserName"].Value.ToString();
                textPassword.Text = row.Cells["Password"].Value.ToString();
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showgrid()
        {
            connect.connection();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT *FROM logininformation", connect.connection());
            DataTable dtble = new DataTable();
            dtble.Clear();
            sqlda.Fill(dtble);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtble;
            connect.closeconnection();
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPassword.Text = "";
        }

        private void AdminWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AdminWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void AdminWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
