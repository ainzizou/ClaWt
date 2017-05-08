using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO.Ports;
using System.Collections;
using rtChart;
using MySql.Data.MySqlClient;


namespace test
{
    public partial class newMain : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=haloain;port=3306;persistsecurityinfo=True;database=clawt");
        MySqlCommand cmd;

        private static int param;
        private String status;
        string dataARD;
        kayChart serialDataChart;
        //DateTime dt = DateTime.Now;

        public newMain()
        {
            InitializeComponent();
            getAvailablePort();
            userValue.Text = LoginW.user;
            dateTime.Text = DateTime.Now.ToString("HH:mm:ss");
            serialChart.Visible = true;
            
        }

        private void CheckStatus(int i)
        {
            int maxZone = param + 8;
            int minZone = param - 8;

            if (i < minZone)
            {

                label_Stat.Text = "Danger";
                status = "Danger";
                red.BackColor = Color.Red;
                Yellow.BackColor = Color.White;
                Green.BackColor = Color.White;
            }
            else if (i > minZone && i < maxZone)
            {
                //Invoke(new Action(() => label_Stat.Text = "Clear"));
                label_Stat.Text = "Moderate";
                status = "Moderate";
                Yellow.BackColor = Color.Yellow;
                Green.BackColor = Color.White;
                red.BackColor = Color.White;
            }

            else if (i > maxZone)
            {
                label_Stat.Text = "Clear";
                status = "Clear";
                Green.BackColor = Color.Green;
                Yellow.BackColor = Color.White;
                red.BackColor = Color.White;
            }
        }

        private void storeRecord(String river, String status, int turb, DateTime dateTime)
        {
            //Sql Statment
            string sql = "INSERT INTO record(dateTime,riverName,turb,parameter,status) VALUES (@date,@river,@turb,@param,@stat)";
            cmd = new MySqlCommand(sql, conn);

            //add Parametes
            cmd.Parameters.AddWithValue("@river", river);
            cmd.Parameters.AddWithValue("@stat", status);
            cmd.Parameters.AddWithValue("@turb", turb);
            cmd.Parameters.AddWithValue("@date", dateTime);
            cmd.Parameters.AddWithValue("@param", param);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("Data already inserted!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The format is not correct, " + ex.Message);
            }
        }

        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                //string w = sp.ReadLine();
                dataARD = sp.ReadLine();

                int sData;
                sData = Int32.Parse(dataARD);
                

                if (dataARD != String.Empty)
                {
                    Invoke(new Action(() => value2.Text = dataARD)); //to display value
                    Invoke(new Action(() => CheckStatus(sData))); //to check the status
                    Invoke(new Action(() => storeRecord(river.Text,status,sData, DateTime.Now)));
                }

                Double data;                
                bool result = Double.TryParse(dataARD, out data);
                if (result)
                {
                    serialDataChart.TriggeredUpdate(data);
                }  
            }
            catch (Exception)
            {
              
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comPorts.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudCom.Text);
                if (serialPort1.IsOpen) return;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);
                serialPort1.Open();

                //this will disable button
                Connect.Enabled = false;
                DisCon.Enabled = true;
                comPorts.Enabled = false;
                baudCom.Enabled = false;
                setBttn.Enabled = false;
                valBox.Enabled = false;
                paramTrack.Enabled = false;
                river.Enabled = false;

                if (comPorts.Text == "" && baudCom.Text == "" && valBox.Text == "" )
                {
                    throw new System.Exception("Parameter cannot be null");
                }

                //to check whether computer received the data or not
                if (serialPort1.ReadLine() != String.Empty)
                {
                    MessageBox.Show("Connected");
                }
                else
                {
                    MessageBox.Show("check the device");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Choose SerialPorts/Baud/Devices");
            }

        }

        private void getAvailablePort()
        {
            String[] ports = SerialPort.GetPortNames();
            comPorts.Items.AddRange(ports);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to logout?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                //this.DialogResult = DialogResult.OK;
                LoginW login = new LoginW();
                login.ShowDialog();
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to logout?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                //this.DialogResult = DialogResult.OK;
                LoginW login = new LoginW();
                login.ShowDialog();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //private int[] buildData()
        //{
        //    int[] value = new int[10];
        //    for (int i = 0; i < 10; i++)
        //    {
        //        value[i] = (i + 1) * 10;
        //    }
        //    return value;
        //}

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataARD = serialPort1.ReadLine();              

            }

            catch (Exception ex)
            {
                MessageBox.Show("Serial1 Data received: " + ex);
            }
        }

        private void newMain_Load(object sender, EventArgs e)
        {
            //parameter trackball
            paramTrack.Minimum = 0;
            paramTrack.Maximum = 500;
            serialDataChart = new kayChart(serialChart, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void DisCon_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            serialPort1.Close();
            Connect.Enabled = true;
            DisCon.Enabled = false;
            comPorts.Enabled = true;
            baudCom.Enabled = true;
            value2.Text = "";
            valBox.Enabled = true;
            setBttn.Enabled = true;
            label_Stat.Text = "";
            paramTrack.Enabled = true;
            river.Enabled = true;

            Yellow.BackColor = Color.White;
            Green.BackColor = Color.White;
            red.BackColor = Color.White;
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MngUser mU = new MngUser();
            mU.ShowDialog();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //param = int.Parse(paramTrack.Value.ToString()); //set value to internal variable

            try
            {
                param = int.Parse(valBox.Text);
                MessageBox.Show("Parameter is set to "+param);
                LabelParamet.Text = valBox.Text;
                //Invoke(new Action(() => LabelParamet.Text = paramTrack.Value.ToString()));
            }
            catch (Exception)
            {
                MessageBox.Show("Please put integer number");
            }
        }

        private void paramTrack_Scroll(object sender, EventArgs e)
        {
            
           

            //try to assign parameter
            try {
                valBox.Text = paramTrack.Value.ToString();
                //param = int.Parse(paramTrack.Value.ToString());
                //LabelParamet.Text = paramTrack.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
