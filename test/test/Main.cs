using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;



namespace test
{
    public partial class Main : Form
    {
        //static private string usrLabel;
        private int param;

        public Main()
        {
            InitializeComponent();
            UserLabel.Text = LoginW.user;
        }

        public void setParam(int p)
        {
            param = p;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Status st = new Status();
            st.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MngUser mU = new MngUser();
            mU.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Config conf = new Config();
            conf.setParam(param); //throw parameter from main to config back
            conf.ShowDialog();
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
    }
}
