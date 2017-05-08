using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace test
{
    public partial class Config : Form
    {
        private static int param;

        public Config()
        {
            InitializeComponent();
            getAvailablePort();
        }

        public void setParam(int par){
            param = par;
        }
        void getAvailablePort()
        {
            String[] ports = SerialPort.GetPortNames();
            ComPorts.Items.AddRange(ports);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //scrolling action perform
            val_Label.Text = Parameter.Value.ToString();
            turbValue_box.Text = val_Label.Text; //gives value to parameter box

            //try to assign parameter
            try { param = int.Parse(val_Label.Text); }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            Parameter.Minimum = 0;
            Parameter.Maximum = 500;
            Parameter.TickStyle = TickStyle.TopLeft;
            Parameter.TickFrequency = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            param = Parameter.Value; //set value to internal variable
            Status stat = new Status();
            Main main = new Main();

            try
            {
                param = int.Parse(turbValue_box.Text);
                stat.setParameter(param); //pass the value to status class
                main.setParam(param);

                this.Close();
                LoginW login = new LoginW();
                login.Activate();
            }
            catch (Exception)
            {
                MessageBox.Show("Please put the whole number (no decimal)");
            }

        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        public void turbValue_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
