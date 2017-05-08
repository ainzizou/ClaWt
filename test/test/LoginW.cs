using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test
{
    public partial class LoginW : Form
    {
        public static string user;
        //connection address
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=haloain;port=3306;persistsecurityinfo=True;database=clawt");
        int i;
        public LoginW()
        {
            InitializeComponent();

            //Maximum and encapsulate the passwordField
            passField.PasswordChar = '*';
            passField.MaxLength = 10;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                i = 0;
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from user where username='" + userField.Text + "' and password = '" + passField.Text + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Invalid user name or password");
                }
                else
                {
                    user = userField.Text;
                    this.Hide();
                    newMain mn = new newMain();
                    mn.ShowDialog();
                }
                conn.Close();

            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset or clear the field
            userField.Text = null;
            passField.Text = null;
        }

        private void LoginW_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit from this system?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void userField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }

        private void passField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }
    }
}
