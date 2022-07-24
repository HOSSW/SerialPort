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
        public static Form1 ex_form1;
        public Form1()
        {
            InitializeComponent();
            ex_form1 = this;


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox1.Text = "COM1";
            comboBox2.Text = "115200";
            comboBox3.Text = "8";
            comboBox4.Text = "None";
            comboBox5.Text = "1";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
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
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
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
                    serialPort1.ReadTimeout = 100;
                    serialPort1.WriteTimeout = -1;
                    serialPort1.ReceivedBytesThreshold = 1;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                    serialPort1.Open();    //打开串口
                    button1.Text = "关闭串口";
                    button1.BackColor = Color.Firebrick;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
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
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }


        //串口接收数据响应函数
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) 
        {
            SerialPort serial = (SerialPort)sender;

            string s = serial.ReadExisting();
            this.Invoke(new Action(() =>
            {
                rev.AppendText(s);
            }));
        }

        private void rev_TextChanged(object sender, EventArgs e)
        {
            rev.SelectionStart = rev.Text.Length;
            rev.ScrollToCaret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* rev.Text = "这是按键一" + "\r\n";*/
            DollSubject dollsubject = new DollSubject(); //实例化一个子窗口
            //设置子窗口不显示为顶级窗口
            dollsubject.TopLevel = false;
            //设置子窗口的样式，没有上面的标题栏
            dollsubject.FormBorderStyle = FormBorderStyle.None;
            //填充
            dollsubject.Dock = DockStyle.Fill;
            //清空Panel里面的控件 
            this.contentPanel.Controls.Clear();
            //加入控件
            this.contentPanel.Controls.Add(dollsubject);
            //让窗体显示
            dollsubject.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* rev.Text = "这是按键二" + "\r\n";*/
            BodyMotherboard bodymotherboard = new BodyMotherboard(); //实例化一个子窗口
            //设置子窗口不显示为顶级窗口
            bodymotherboard.TopLevel = false;
            //设置子窗口的样式，没有上面的标题栏
            bodymotherboard.FormBorderStyle = FormBorderStyle.None;
            //填充
            bodymotherboard.Dock = DockStyle.Fill;
            //清空Panel里面的控件 
            this.contentPanel.Controls.Clear();
            //加入控件
            this.contentPanel.Controls.Add(bodymotherboard);
            //让窗体显示
            bodymotherboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rev.Text = "这是按键三" + "\r\n";
        }

       
    }
}
