using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _136
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "alsrl4769" && textBox2.Text == "wlsghd5936!")
            {
                textBox3.Text = "로그인 성공";
            }
            else
            {
                textBox3.Text = "아이디 또는 패스워드가 다릅니다.";
            }
        }
    }
}
