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
    public partial class MngUser : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=haloain;port=3306;persistsecurityinfo=True;database=clawt");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public MngUser()
        {
            InitializeComponent();
            tableInitial();
            retrieved();
            //updateTable();

        }

        public void populate(String id, String name, String usName, String Password)
        {
            UserTable.Rows.Add(id, name, Password, usName);
        }

        public void tableInitial()
        {
            UserTable.DataSource = null;
            UserTable.ColumnCount = 4;
            UserTable.Columns[0].Name = "ID";
            UserTable.Columns[1].Name = "Name";
            UserTable.Columns[2].Name = "Username";
            UserTable.Columns[3].Name = "Password";

            UserTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Selection Method
            UserTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserTable.MultiSelect = false;
        }

        //retrieved From database
        public void retrieved()
        {
            UserTable.Rows.Clear();
            string sql = "SELECT * From clawt.user";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                //Loop
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

                conn.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void addUser(String name, String pass, String usName)
        {
            //Sql Statment
            string sql = "INSERT INTO user(name,password,username) VALUES (@name,@password,@username)";
            cmd = new MySqlCommand(sql, conn);

            //add Parametes
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Parameters.AddWithValue("@username", usName);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data already inserted!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The format is not correct, " + ex.Message);
            }
        }

        public void update(int id, String name, String pass, String usName)
        {
            string sql = "UPDATE user SET name='" + name + "', password='" + pass + "', username='" + usName + "' WHERE iduser='" + id + "'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(cmd);

                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully updated");
                    cancel();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        public void delete(int id)
        {
            string sql = "DELETE FROM user WHERE iduser = '" + id + "'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = conn.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //asking confirmation
                if (MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfully deleted!");
                        cancel();
                    }
                }

                conn.Close();
                retrieved();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
                conn.Close();
            }
        }

        public void updateTable()
        {
            cmd = new MySqlCommand("Select * from clawt.user ;", conn);
            try
            {
                adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                UserTable.DataSource = bSource;
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            addUser(nameField.Text, passField.Text, userField.Text);
            retrieved();
            cancel();
        }

        public void cancel()
        {
            IdField.Text = null;
            nameField.Text = null;
            passField.Text = null;
            userField.Text = null;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void UserTable_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                IdField.Text = UserTable.SelectedRows[0].Cells[0].Value.ToString();
                nameField.Text = UserTable.SelectedRows[0].Cells[1].Value.ToString();
                userField.Text = UserTable.SelectedRows[0].Cells[2].Value.ToString();
                passField.Text = UserTable.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Empty record | Please choose the correct row");
            }
            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            String selected = UserTable.SelectedRows[0].Cells[0].Value.ToString();
            int id = Int32.Parse(selected);
            delete(id);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            String selcted = UserTable.SelectedRows[0].Cells[0].Value.ToString();
            int id = Int32.Parse(selcted);

            update(id, nameField.Text, passField.Text, userField.Text);
            retrieved();
        }
    }
}
