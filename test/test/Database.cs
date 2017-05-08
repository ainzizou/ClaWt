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
    public partial class Database : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=haloain;port=3306;persistsecurityinfo=True;database=clawt");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader myReader;
        DataTable dt = new DataTable();

        List<KeyValuePair<DateTime, int>> Penang = new List<KeyValuePair<DateTime, int>>();
        List<KeyValuePair<DateTime, int>> Sintok = new List<KeyValuePair<DateTime, int>>();
        List<KeyValuePair<DateTime, int>> Kampong = new List<KeyValuePair<DateTime, int>>();

        public Database()
        {
            InitializeComponent();
            tableInitial();
            load();
        }

       
        private void load()
        {
            recordTable.Rows.Clear();
            string sql = "SELECT dateTime, riverName,turb,parameter,status  From clawt.record";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                //Loop
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
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

        public void tableInitial()
        {
            recordTable.DataSource = null;
            recordTable.ColumnCount = 5;
            //recordTable.Columns[0].Name = "ID";
            recordTable.Columns[0].Name = "Date Time";
            recordTable.Columns[1].Name = "Name";
            recordTable.Columns[2].Name = "Value";
            recordTable.Columns[3].Name = "Parameter";
            recordTable.Columns[4].Name = "Status";
            
            recordTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Selection Method
            recordTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recordTable.MultiSelect = false;
        }

        public void populate(String dateTime, String name, String turb, String param, String status)
        {
            recordTable.Rows.Add(dateTime, name, turb, param, status);
        }

        private void Database_Load(object sender, EventArgs e)
        {

        }

        private void sort_Click(object sender, EventArgs e)
        {

            recordTable.Rows.Clear();
            String p=null, k=null, s=null; //assign null value

            if (cheKampong.Checked == true)
            {
                k = "Kampong";
              
            }else if(cheKampong.Checked != true)
            {
                k = null;
              
            }

            if (cheSintok.Checked == true)
            {
                s = "Sintok";
               
            } else if (cheSintok.Checked == false)
            {
                s = null;
             
            }

            if (chePenang.Checked == true)
            {
                p = "Penang";
               
            }
            else if (chePenang.Checked == false)
            {
                p = null;
             
            }

            string sql = "select dateTime, riverName,turb,parameter,status  from record where (date(dateTime) BETWEEN '" + this.StartDate.Text+ "' AND '" + this.FinishDate.Text + "') AND (riverName = '"+p+"' OR riverName = '" + s + "' OR riverName = '" +k + "') order by dateTime asc";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                //Loop
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
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

       

        private void button1_Click(object sender, EventArgs e)
        {
            clearChart();

            if (cheKampong.Checked==true)
            {
                getKampongChart();
            }

            if (cheSintok.Checked == true)
            {
                getSintokChart();
            }

            if (chePenang.Checked == true)
            {
                getPenangChart();
            }
        }

        private void getPenangChart()
        {
            string sql = "select * from record where (date(dateTime) BETWEEN '" + this.StartDate.Text + "' AND '" + this.FinishDate.Text + "') AND riverName='Penang' order by dateTime asc";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                int i = 0;
                while (myReader.Read())
                {
                    DateTime tgl = myReader.GetDateTime("dateTime");
                    int hasil = myReader.GetInt32("turb");
                    Penang.Insert(i, new KeyValuePair<DateTime, int>(tgl, hasil));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

            foreach (KeyValuePair<DateTime, int> kvp in Penang)
            {
                //showing the chart
                this.chart1.Series[0].Points.AddXY(Convert.ToString(kvp.Key), kvp.Value);

            }
        }

        private void getKampongChart()
        {

            string sql = "select * from record where (date(dateTime) BETWEEN '" + this.StartDate.Text + "' AND '" + this.FinishDate.Text + "') AND riverName='Kampong' order by dateTime asc";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                int i = 0;
                while (myReader.Read())
                {
                    DateTime tgl = myReader.GetDateTime("dateTime");
                    int hasil = myReader.GetInt32("turb");
                    Kampong.Insert(i, new KeyValuePair<DateTime, int>(tgl, hasil));
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

            foreach (KeyValuePair<DateTime, int> kvp in Kampong)
            {
                //showing the chart
                this.chart1.Series[2].Points.AddXY(Convert.ToString(kvp.Key), kvp.Value);

            }
        }

        private void getSintokChart()
        {

            string sql = "select * from record where (date(dateTime) BETWEEN '" + this.StartDate.Text + "' AND '" + this.FinishDate.Text + "') AND riverName='Sintok' order by dateTime asc";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                int i = 0;
                while (myReader.Read())
                {
                    DateTime tgl = myReader.GetDateTime("dateTime");
                    int hasil = myReader.GetInt32("turb");
                    Sintok.Insert(i, new KeyValuePair<DateTime, int>(tgl, hasil));
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

            foreach (KeyValuePair<DateTime, int> kvp in Sintok)
            {
                //showing the chart
                this.chart1.Series[1].Points.AddXY(Convert.ToString(kvp.Key), kvp.Value);
            }
        }

        private void clearChart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            Penang.Clear();
            Sintok.Clear();
            Kampong.Clear();
        }
    }
}
