using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace test
{
    public partial class Login : Form
    {
        //connection address
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=haloain;port=3306;persistsecurityinfo=True;database=clawt");
        int i; //
        public Login()
        {
            InitializeComponent();

            //Maximum and encapsulate the passwordField
            passField.PasswordChar = '*';
            passField.MaxLength = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userField.Text == null)
            {
                MessageBox.Show("Please enter your username");
            }
            else if (passField.Text == null)
            {
                MessageBox.Show("Please enter your password");
            }
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
                    this.Hide();
                    Main mn = new Main();
                    mn.Show();
                }

                conn.Close();

            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset or clear the field
            userField.Text = null;
            passField.Text = null;
        }
    }
}
