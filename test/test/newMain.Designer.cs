namespace test
{
    partial class newMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.river = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelParamet = new System.Windows.Forms.Label();
            this.valBox = new System.Windows.Forms.TextBox();
            this.setBttn = new System.Windows.Forms.Button();
            this.label_param = new System.Windows.Forms.Label();
            this.paramTrack = new System.Windows.Forms.TrackBar();
            this.DisCon = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.baudCom = new System.Windows.Forms.ComboBox();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.value2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.val4 = new System.Windows.Forms.Label();
            this.userValue = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_Stat = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.PictureBox();
            this.Yellow = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.Label_turbid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramTrack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.river);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LabelParamet);
            this.groupBox1.Controls.Add(this.valBox);
            this.groupBox1.Controls.Add(this.setBttn);
            this.groupBox1.Controls.Add(this.label_param);
            this.groupBox1.Controls.Add(this.paramTrack);
            this.groupBox1.Controls.Add(this.DisCon);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.baudCom);
            this.groupBox1.Controls.Add(this.comPorts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // river
            // 
            this.river.FormattingEnabled = true;
            this.river.Items.AddRange(new object[] {
            "Sintok",
            "Penang",
            "Kampong"});
            this.river.Location = new System.Drawing.Point(68, 80);
            this.river.Name = "river";
            this.river.Size = new System.Drawing.Size(121, 21);
            this.river.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "River";
            // 
            // LabelParamet
            // 
            this.LabelParamet.AutoSize = true;
            this.LabelParamet.Location = new System.Drawing.Point(430, 18);
            this.LabelParamet.Name = "LabelParamet";
            this.LabelParamet.Size = new System.Drawing.Size(13, 13);
            this.LabelParamet.TabIndex = 10;
            this.LabelParamet.Text = "0";
            // 
            // valBox
            // 
            this.valBox.Location = new System.Drawing.Point(507, 84);
            this.valBox.Name = "valBox";
            this.valBox.Size = new System.Drawing.Size(46, 20);
            this.valBox.TabIndex = 9;
            // 
            // setBttn
            // 
            this.setBttn.Location = new System.Drawing.Point(559, 84);
            this.setBttn.Name = "setBttn";
            this.setBttn.Size = new System.Drawing.Size(53, 23);
            this.setBttn.TabIndex = 8;
            this.setBttn.Text = "Set";
            this.setBttn.UseVisualStyleBackColor = true;
            this.setBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_param
            // 
            this.label_param.AutoSize = true;
            this.label_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_param.Location = new System.Drawing.Point(308, 16);
            this.label_param.Name = "label_param";
            this.label_param.Size = new System.Drawing.Size(71, 16);
            this.label_param.TabIndex = 7;
            this.label_param.Text = "Parameter";
            // 
            // paramTrack
            // 
            this.paramTrack.Location = new System.Drawing.Point(311, 46);
            this.paramTrack.Name = "paramTrack";
            this.paramTrack.Size = new System.Drawing.Size(301, 45);
            this.paramTrack.TabIndex = 6;
            this.paramTrack.Scroll += new System.EventHandler(this.paramTrack_Scroll);
            // 
            // DisCon
            // 
            this.DisCon.Location = new System.Drawing.Point(206, 74);
            this.DisCon.Name = "DisCon";
            this.DisCon.Size = new System.Drawing.Size(85, 23);
            this.DisCon.TabIndex = 5;
            this.DisCon.Text = "Disconnected";
            this.DisCon.UseVisualStyleBackColor = true;
            this.DisCon.Click += new System.EventHandler(this.DisCon_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(206, 26);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(85, 23);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // baudCom
            // 
            this.baudCom.FormattingEnabled = true;
            this.baudCom.Items.AddRange(new object[] {
            "9600"});
            this.baudCom.Location = new System.Drawing.Point(68, 50);
            this.baudCom.Name = "baudCom";
            this.baudCom.Size = new System.Drawing.Size(121, 21);
            this.baudCom.TabIndex = 3;
            // 
            // comPorts
            // 
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(68, 20);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(121, 21);
            this.comPorts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2.ForeColor = System.Drawing.Color.Red;
            this.value2.Location = new System.Drawing.Point(669, 68);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(13, 20);
            this.value2.TabIndex = 2;
            this.value2.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // val4
            // 
            this.val4.AutoSize = true;
            this.val4.Location = new System.Drawing.Point(883, 10);
            this.val4.Name = "val4";
            this.val4.Size = new System.Drawing.Size(52, 13);
            this.val4.TabIndex = 4;
            this.val4.Text = "Welcome";
            // 
            // userValue
            // 
            this.userValue.AutoSize = true;
            this.userValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userValue.Location = new System.Drawing.Point(937, 9);
            this.userValue.Name = "userValue";
            this.userValue.Size = new System.Drawing.Size(57, 16);
            this.userValue.TabIndex = 6;
            this.userValue.Text = "UserVal";
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Location = new System.Drawing.Point(881, 38);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(51, 13);
            this.dateTime.TabIndex = 7;
            this.dateTime.Text = "dateTime";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUserToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.recordToolStripMenuItem.Text = "Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // serialChart
            // 
            chartArea2.Name = "ChartArea1";
            this.serialChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.serialChart.Legends.Add(legend2);
            this.serialChart.Location = new System.Drawing.Point(12, 144);
            this.serialChart.Name = "serialChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.serialChart.Series.Add(series2);
            this.serialChart.Size = new System.Drawing.Size(982, 485);
            this.serialChart.TabIndex = 9;
            this.serialChart.Text = "chart1";
            title2.Name = "Water Turbidity";
            this.serialChart.Titles.Add(title2);
            // 
            // label_Stat
            // 
            this.label_Stat.AutoSize = true;
            this.label_Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stat.ForeColor = System.Drawing.Color.Black;
            this.label_Stat.Location = new System.Drawing.Point(648, 41);
            this.label_Stat.Name = "label_Stat";
            this.label_Stat.Size = new System.Drawing.Size(56, 18);
            this.label_Stat.TabIndex = 10;
            this.label_Stat.Text = "Status";
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(640, 109);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(72, 25);
            this.Green.TabIndex = 11;
            this.Green.TabStop = false;
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(718, 109);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(72, 25);
            this.Yellow.TabIndex = 12;
            this.Yellow.TabStop = false;
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(796, 109);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(72, 25);
            this.red.TabIndex = 13;
            this.red.TabStop = false;
            // 
            // Label_turbid
            // 
            this.Label_turbid.AutoSize = true;
            this.Label_turbid.BackColor = System.Drawing.SystemColors.Control;
            this.Label_turbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_turbid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_turbid.Location = new System.Drawing.Point(24, 385);
            this.Label_turbid.Name = "Label_turbid";
            this.Label_turbid.Size = new System.Drawing.Size(36, 16);
            this.Label_turbid.TabIndex = 14;
            this.Label_turbid.Text = "LUX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "TIME";
            // 
            // newMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 641);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label_turbid);
            this.Controls.Add(this.red);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.label_Stat);
            this.Controls.Add(this.serialChart);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.userValue);
            this.Controls.Add(this.val4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "newMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.newMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramTrack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisCon;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox baudCom;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label val4;
        private System.Windows.Forms.Label userValue;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.TrackBar paramTrack;
        private System.Windows.Forms.Label label_param;
        private System.Windows.Forms.Button setBttn;
        private System.Windows.Forms.TextBox valBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart serialChart;
        private System.Windows.Forms.Label label_Stat;
        private System.Windows.Forms.Label LabelParamet;
        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.PictureBox Yellow;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.ComboBox river;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_turbid;
        private System.Windows.Forms.Label label4;
    }
}