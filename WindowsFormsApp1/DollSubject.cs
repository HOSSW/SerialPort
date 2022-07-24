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
    public delegate void ChangeFormColor(bool topmost);
    public partial class DollSubject : Form
    {
        public event ChangeFormColor ChangeColor;

        public DollSubject()
        {
            InitializeComponent();
            
        }

        private void DollSubject_Load(object sender, EventArgs e)
        {

        }

        private void Led_Click(object sender, EventArgs e)
        {
           /* ex_form1.rev.Text = "这里是人偶主体的Led灯测试";*/
            
        }
    }
}
