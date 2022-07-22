using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox1.Text = "COM1";
            comboBox2.Text = "115200";
            comboBox3.Text = "8";
            comboBox4.Text = "None";
            comboBox5.Text = "1";
        }
       

  

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();    //关闭串口
                    button1.Text = "打开串口";
                    button1.BackColor = Color.ForestGreen;
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                    comboBox4.Enabled = true;
                    comboBox5.Enabled = true;
                    rev.Text = "";  //清空接收区
                    send.Text = "";     //清空发送区
                }
                else 
                {

                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;

                    serialPort1.PortName = comboBox1.Text.ToString();
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text.ToString());
                    serialPort1.DataBits = Convert.ToInt32(comboBox3.Text.ToString());

                    if (comboBox4.Text.ToString().CompareTo("奇校验") == 0)
                        serialPort1.Parity = Parity.Odd;
                    else if (comboBox4.Text.ToString().CompareTo("偶校验") == 0)
                        serialPort1.Parity = Parity.Even;
                    else
                        serialPort1.Parity = Parity.None; 

                    switch (Convert.ToInt32(comboBox5.Text.ToString()))
                    {
                        case 1: serialPort1.StopBits = StopBits.One; break;
                        case 2: serialPort1.StopBits = StopBits.Two; break;
                        default: break;
                    }
                    serialPort1.Open();    //打开串口
                    button1.Text = "关闭串口";
                    button1.BackColor = Color.Firebrick;
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理

                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                button1.Text = "打开串口";
                button1.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;

            }

        }


    }
}
