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
    public partial class ControlWindow : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private void displayGrid()
        {
            DB connect = new DB();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT *FROM tbl_studentinformation", connect.connection());
            DataTable dtbl1 = new DataTable();
            dtbl1.Clear();
            sqlda.Fill(dtbl1);
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = dtbl1;
            connect.closeconnection();
        }

        public ControlWindow()
        {
            InitializeComponent();
            LoginForm wind = new LoginForm();
            wind.Close();
            displayGrid();

        }
        

        private void PictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string name = textName.Text;
                int sclass = Convert.ToInt32(textClass.Text);
                int rollno = Convert.ToInt32(textRoll.Text);
                string verify = radio_submitted.Checked ? "Yes" : "No";
                int phone = Convert.ToInt32(textPhone.Text);
                DB connect = new DB();
                string query = "INSERT INTO tbl_studentinformation (NAME,CLASS,ROLLNO,ASSIGNMENT,PHONE) VALUES ('" + name + "','" + sclass + "','" + rollno + "','" + verify + "','" + phone + "')";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry added to the database!!");
                displayGrid();
                connect.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DB con = new DB();
                con.connection();
                DataGridViewRow row = dgv1.SelectedRows[0];
                string id = row.Cells["ROLLNO"].Value.ToString();
                string deletequery = "DELETE FROM tbl_studentinformation WHERE ROLLNO = '"+id+"' ";
                MySqlCommand delcmd = new MySqlCommand(deletequery, con.connection());
                if (delcmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("The selected data has been removed");
                    displayGrid();
                }
                con.closeconnection();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textClass.Text = "";
            textRoll.Text = "";
            textPhone.Text = "";
            radio_submitted.Checked = false;

        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv1.SelectedRows[0];
                textName.Text = row.Cells["Name"].Value.ToString();
                textClass.Text = row.Cells["Class"].Value.ToString();
                textRoll.Text = row.Cells["Rollno"].Value.ToString();
                textPhone.Text = row.Cells["Phone"].Value.ToString();
                if (row.Cells["Assignment"].Value.ToString() == "Yes")
                    radio_submitted.Checked = true;
                else
                    radio_submitted.Checked = false;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DB con = new DB();
                con.connection();
                DataGridViewRow row = dgv1.SelectedRows[0];
                string id = row.Cells["ROLLNO"].Value.ToString();
                string name = textName.Text;
                int sclass = Convert.ToInt32(textClass.Text);
                int rollno = Convert.ToInt32(textRoll.Text);
                string verify = radio_submitted.Checked ? "Yes" : "No";
                int phone = Convert.ToInt32(textPhone.Text);
                string updatequery = "UPDATE tbl_studentinformation SET NAME = '" + name + "', CLASS = '" + sclass + "', ROLLNO = '" + rollno + "', ASSIGNMENT = '" + verify + "', PHONE = '" + phone + "' WHERE ROLLNO = '"+id+"' ";
                MySqlCommand updatecommand = new MySqlCommand(updatequery,con.connection());
                updatecommand.ExecuteNonQuery();
                MessageBox.Show("The field has been updated");
                displayGrid();
                con.closeconnection();
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ControlWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void ControlWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
