namespace Scurve
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myButton5 = new SpinnyFlashyShinyControls.myButton();
            this.myButton4 = new SpinnyFlashyShinyControls.myButton();
            this.myButton3 = new SpinnyFlashyShinyControls.myButton();
            this.myButton2 = new SpinnyFlashyShinyControls.myButton();
            this.myButton1 = new SpinnyFlashyShinyControls.myButton();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.myButton2);
            this.panel1.Controls.Add(this.myButton1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 198);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serial Connection";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(36, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Baud Rate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Com Port";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.myButton4);
            this.panel2.Controls.Add(this.myButton3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(192, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 236);
            this.panel2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Motion Profile";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "0.5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "6";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "150";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "9000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Max. Jerk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Max. Acceleration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Max. Velocity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Distance";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(0, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 472);
            this.panel3.TabIndex = 17;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(301, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Velocity";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(191, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Position";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Graph";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 24);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderColor = System.Drawing.Color.Gold;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.DarkOrchid;
            series1.Legend = "Legend1";
            series1.Name = "Position";
            series2.BorderColor = System.Drawing.Color.Gold;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.OrangeRed;
            series2.Legend = "Legend1";
            series2.Name = "Velocity";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(642, 460);
            this.chart1.TabIndex = 1;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Location = new System.Drawing.Point(489, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 236);
            this.panel4.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Received Data";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 24);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 207);
            this.textBox5.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.White;
            this.myButton5.ClickColor = System.Drawing.Color.Gold;
            this.myButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.myButton5.FontAntiAlias = true;
            this.myButton5.ForeColor = System.Drawing.Color.Black;
            this.myButton5.HoverColor = System.Drawing.Color.LightSkyBlue;
            this.myButton5.Location = new System.Drawing.Point(37, 206);
            this.myButton5.Name = "myButton5";
            this.myButton5.RoundedCornerRadius = 3;
            this.myButton5.Size = new System.Drawing.Size(104, 32);
            this.myButton5.TabIndex = 19;
            this.myButton5.Text = "More >>";
            this.myButton5.UseVisualStyleBackColor = false;
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.White;
            this.myButton4.ClickColor = System.Drawing.Color.Gold;
            this.myButton4.Enabled = false;
            this.myButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.myButton4.FontAntiAlias = true;
            this.myButton4.ForeColor = System.Drawing.Color.Black;
            this.myButton4.HoverColor = System.Drawing.Color.LightSkyBlue;
            this.myButton4.Location = new System.Drawing.Point(176, 203);
            this.myButton4.Name = "myButton4";
            this.myButton4.RoundedCornerRadius = 2;
            this.myButton4.Size = new System.Drawing.Size(75, 23);
            this.myButton4.TabIndex = 36;
            this.myButton4.Text = "Send";
            this.myButton4.UseVisualStyleBackColor = false;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.White;
            this.myButton3.ClickColor = System.Drawing.Color.Gold;
            this.myButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.myButton3.FontAntiAlias = true;
            this.myButton3.ForeColor = System.Drawing.Color.Black;
            this.myButton3.HoverColor = System.Drawing.Color.LightSkyBlue;
            this.myButton3.Location = new System.Drawing.Point(39, 203);
            this.myButton3.Name = "myButton3";
            this.myButton3.RoundedCornerRadius = 2;
            this.myButton3.Size = new System.Drawing.Size(75, 23);
            this.myButton3.TabIndex = 35;
            this.myButton3.Text = "Calculate";
            this.myButton3.UseVisualStyleBackColor = false;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.White;
            this.myButton2.ClickColor = System.Drawing.Color.Gold;
            this.myButton2.Enabled = false;
            this.myButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.myButton2.FontAntiAlias = true;
            this.myButton2.ForeColor = System.Drawing.Color.Black;
            this.myButton2.HoverColor = System.Drawing.Color.LightSkyBlue;
            this.myButton2.Location = new System.Drawing.Point(98, 165);
            this.myButton2.Name = "myButton2";
            this.myButton2.RoundedCornerRadius = 3;
            this.myButton2.Size = new System.Drawing.Size(75, 23);
            this.myButton2.TabIndex = 15;
            this.myButton2.Text = "Disconnect";
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.White;
            this.myButton1.ClickColor = System.Drawing.Color.Gold;
            this.myButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.myButton1.FontAntiAlias = true;
            this.myButton1.ForeColor = System.Drawing.Color.Black;
            this.myButton1.HoverColor = System.Drawing.Color.LightSkyBlue;
            this.myButton1.Location = new System.Drawing.Point(11, 165);
            this.myButton1.Name = "myButton1";
            this.myButton1.RoundedCornerRadius = 3;
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 14;
            this.myButton1.Text = "Connect";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(651, 733);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(667, 780);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-curve Profile Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private SpinnyFlashyShinyControls.myButton myButton2;
        private SpinnyFlashyShinyControls.myButton myButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private SpinnyFlashyShinyControls.myButton myButton4;
        private SpinnyFlashyShinyControls.myButton myButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private SpinnyFlashyShinyControls.myButton myButton5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;

    }
}

