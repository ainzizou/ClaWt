namespace test
{
    partial class Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComPorts = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Parameter = new System.Windows.Forms.TrackBar();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setBttn = new System.Windows.Forms.Button();
            this.val_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.turbValue_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Parameter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Communication Port";
            // 
            // ComPorts
            // 
            this.ComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPorts.FormattingEnabled = true;
            this.ComPorts.Location = new System.Drawing.Point(35, 119);
            this.ComPorts.Name = "ComPorts";
            this.ComPorts.Size = new System.Drawing.Size(121, 21);
            this.ComPorts.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Parameter
            // 
            this.Parameter.Location = new System.Drawing.Point(26, 229);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(250, 45);
            this.Parameter.TabIndex = 4;
            this.Parameter.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(121, 182);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(0, 13);
            this.valueLabel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value :";
            // 
            // setBttn
            // 
            this.setBttn.Location = new System.Drawing.Point(201, 329);
            this.setBttn.Name = "setBttn";
            this.setBttn.Size = new System.Drawing.Size(75, 23);
            this.setBttn.TabIndex = 7;
            this.setBttn.Text = "Set";
            this.setBttn.UseVisualStyleBackColor = true;
            this.setBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // val_Label
            // 
            this.val_Label.AutoSize = true;
            this.val_Label.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_Label.Location = new System.Drawing.Point(242, 185);
            this.val_Label.Name = "val_Label";
            this.val_Label.Size = new System.Drawing.Size(23, 25);
            this.val_Label.TabIndex = 8;
            this.val_Label.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "250";
            // 
            // turbValue_box
            // 
            this.turbValue_box.Location = new System.Drawing.Point(72, 182);
            this.turbValue_box.Name = "turbValue_box";
            this.turbValue_box.Size = new System.Drawing.Size(43, 20);
            this.turbValue_box.TabIndex = 12;
            this.turbValue_box.TextChanged += new System.EventHandler(this.turbValue_box_TextChanged);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 446);
            this.Controls.Add(this.turbValue_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.val_Label);
            this.Controls.Add(this.setBttn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.Parameter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComPorts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Parameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComPorts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar Parameter;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setBttn;
        private System.Windows.Forms.Label val_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox turbValue_box;
    }
}