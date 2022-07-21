using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = user_id.Text;
            string pwd = user_pwd.Text;

            if (user == "admin" && pwd == "666666")
                MessageBox.Show("登陆成功");
            else
                MessageBox.Show("登陆失败");
        }
    }
}
