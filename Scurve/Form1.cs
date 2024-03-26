using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Scurve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] allBaudRates = { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600 };
        double[] T = {0,0,0,0,0,0,0,0};
        double S13, S2, S123, S4, Dmax;
        double V1, V2, Vmax;
        double A, Amax, J, Jmax;
        double a, b, c, x1, x2;
        double timeCount = 0;
        string read;
        int temp, lastVal = 0;
        Boolean flag1 = false;
        Boolean flag2 = false;
        Boolean flag3 = true;
        Boolean flag4 = true;

        private void Form1_Load(object sender, EventArgs e)     // check available ports & set defult baudrate when loading
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            panel3.Visible = false;
            panel4.Visible = false;
            Height -= (panel3.Height + 6);
            Width -= (panel4.Width + 6);
            GetSerialPorts();
            SetBaudRate();
            timer1.Start();
        }

        private void GetSerialPorts()       // check available ports
        {
            string[] allPorts;
            allPorts = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in allPorts)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void SetBaudRate()      // set default baudrate
        {
            foreach (int baudR in allBaudRates)
            {
                comboBox2.Items.Add(baudR);
            }
            comboBox2.SelectedIndex = 5;
        }

        private void GetInput()     // validate inputs
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                double.TryParse(textBox1.Text, out Dmax);
                double.TryParse(textBox2.Text, out Vmax);
                double.TryParse(textBox3.Text, out Amax);
                double.TryParse(textBox4.Text, out Jmax);
                if (Jmax > 0.1 && Jmax < 0.8)
                {
                    J = Jmax;
                }
                else
                {
                    MessageBox.Show("Jerk should be within the range\n0.1 < Jerk < 0.8");
                }
                    A = Amax;
            }   
        }

        private void Calculate()        // calculate 7 time segments 
        {
            T[1] = A/J;
            V1 = J*T[1]*T[1]/2;

            if(2*V1 < Vmax)
            {
                V2 = Vmax - V1;
                T[2] = (Vmax - 2*V1)/A;
                T[3] = T[1];
                //disp('2*V1 < Vmax');
            }
            else if(2*V1 >= Vmax)
            {
                V1 = Vmax/2;
                V2 = V1;
                T[1] = Math.Sqrt(Vmax / J);   //T1 = Math.Pow((Vmax / J), 1.0 / 2.0);
                T[2] = 0;
                T[3] = T[1];
                //disp('2*V1 >= Vmax');
            }

            S13 = Vmax*T[1];
            S123 = (V1 + V2)*T[2]/2 + S13;

            if(2*S123 > Dmax)
            {
                if(2*S13 > Dmax)
                {
                    V1 = Vmax/2;
                    V2 = V1;
                    T[1] = Math.Pow((Dmax / J / 2), 1.0 / 3.0);   //T[1] = (Dmax/J/2)^(1/3);
                    T[2] = 0;
                    T[3] = T[1];
                    //disp('2*S13 > Dmax');
                }
                else if(2*S13 <= Dmax)
                {
                    a = J*T[1];
                    b = 3*J*T[2]*T[2];
                    c = 2*J*T[1]*T[1]*T[1] - Dmax;
                    x1 = (-b + Math.Sqrt(b*b - 4*a*c))/(2*a);
                    x2 = (-b - Math.Sqrt(b*b - 4*a*c))/(2*a);

                    if(x2 > x1)
                    {
                        T[2] = x2;
                    }
                    else if(x1 > x2)
                    {
                        T[2] = x1;
                    }
            
                    V2 = V1 + A*T[2];
                    S2 = (V1 + V2)*T[2]/2 ; 
                    //disp('2*S13 <= Dmax');
                }
            }
            else
            {
                S4 = Dmax - 2 * S123;
                T[4]= S4/Vmax;
                //disp('2*S123 < Dmax');
            }

            T[5] = T[3];
            T[6] = T[2];
            T[7] = T[1];

            MessageBox.Show("Jerk = " + J + "\nT1 = " + T[1] + "\nT2 = " + T[2] + "\nT3 = " + T[3] + "\nT4 = " + T[4] + "\nT5 = " + T[5] + "\nT6 = " + T[6] + "\nT7 = " + T[7]);   
        }

        private void SerialWrite(double val, byte deli)     // data transmission
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    double num = Math.Round(val, 0, MidpointRounding.ToEven);
                    string str = num.ToString();
                    //MessageBox.Show(str);
                    serialPort1.Write(str);
                    serialPort1.Write(new byte[] { deli }, 0, 1);
                }
                catch
                {
                    MessageBox.Show("Write error!");
                }
                /*
                char[] ch = str.ToCharArray();
                //MessageBox.Show(str + "\n" + ch[1].ToString());
                serialPort1.Write(ch, 0, ch.Length);
                serialPort1.Write(deli, 0, 1);
                */
                /*
                foreach (char c in ch)
                {
                    char[] buff = new char[1];
                    buff[0] = c;
                    MessageBox.Show(c.ToString());
                    serialPort1.Write(buff, 0, 1);
                }
                 */
            }
            else
            {
                toolStripStatusLabel1.Text = "Serial port not connected!";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) // data receive
        {
            try
            {
                read = serialPort1.ReadTo("\n");
                //read = serialPort1.ReadLine();
                if (read == "done")
                {
                    toolStripStatusLabel1.Text = "Job done";
                    flag2 = false;
                    flag3 = true;
                    myButton3.Enabled = true;
                }
                else if (flag2)
                {
                    if (flag3)
                    {
                        toolStripStatusLabel1.Text = "Receiving data";
                        timeCount = 0;
                        flag1 = false;
                        flag3 = false;
                    }
                    if (flag4 == true)
                    {
                        chart1.Series["Position"].Points.AddXY(timeCount, read);
                    }
                    Int32.TryParse(read, out temp);
                    //temp = Int32.Parse(read);
                    if (flag4 == false)
                    {
                        chart1.Series["Velocity"].Points.AddXY(timeCount, (temp - lastVal));
                    }
                    lastVal = temp;
                    textBox5.AppendText(read);
                    textBox5.Text += System.Environment.NewLine;
                    textBox5.SelectionStart = textBox5.Text.Length;
                    textBox5.ScrollToCaret();
                    read = "";
                }
                else if (read == "ready")
                {
                    toolStripStatusLabel1.Text = "System ready";
                    flag1 = true;
                }
                else
                {
                    read = "";
                }

            }
            catch
            {
                MessageBox.Show("Read error!");
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)     // com port list
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            GetSerialPorts();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //serialPort1.DiscardInBuffer();
            //serialPort1.DiscardOutBuffer();
            serialPort1.Close();
            //serialPort1.Dispose();
        }

        private void myButton1_Click(object sender, EventArgs e)    // button "Connect"
        {
            string comPort = comboBox1.Text;
            int baudRate = allBaudRates[comboBox2.SelectedIndex];
            if (comPort != "")
            {
                serialPort1.PortName = comPort;
                serialPort1.BaudRate = baudRate;
                try
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        myButton1.Enabled = false;
                        myButton2.Enabled = true;
                        toolStripStatusLabel1.Text = "Serial Port Connected";
                    }
                }
                catch
                {
                    MessageBox.Show("Error!" + System.Environment.NewLine + "Problem to connect COM port");
                }
            }
        }

        private void myButton2_Click(object sender, EventArgs e)    // button "Disconnect"
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                myButton1.Enabled = true;
                myButton2.Enabled = false;
                toolStripStatusLabel1.Text = "Serial Port Disconnected";
            }
        }

        private void myButton3_Click(object sender, EventArgs e)    // button "Calculate"
        {
            GetInput();
            Calculate();
            myButton4.Enabled = true;
        }

        private void myButton4_Click(object sender, EventArgs e)    // button "Send"
        {
            if (flag1)
            {
                SerialWrite(J * 10, 10);     // send data with delimeter 

                for (int i = 1; i < T.Length; i++)
                {
                    SerialWrite(T[i], 10);
                }
                toolStripStatusLabel1.Text = "Data sent";
                read = "";
                flag2 = true;
                myButton3.Enabled = false;
            }
        }

        private void myButton5_Click(object sender, EventArgs e)    // button "More/Less"
        {
            if (panel3.Visible == false)
            {
                Height += (panel3.Height + 6);
                panel3.Visible = true;
                Width += (panel4.Width + 6);
                panel4.Visible = true;
                myButton5.Text = "<< Less";
            }
            else
            {
                Height -= (panel3.Height + 6);
                panel3.Visible = false;
                Width -= (panel4.Width + 6);
                panel4.Visible = false;
                myButton5.Text = "More >>";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)    // timer upcounter for chart x-axis
        {
            timeCount = timeCount + 0.1;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            flag4 = true;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            flag4 = false;
        }
    }
}
