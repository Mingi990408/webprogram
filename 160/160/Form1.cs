using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160
{
    public partial class Form1 : Form
    {
        private bool opFlag = false;
        private double Value;
        private String op;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (textBox1.Text == "0" || opFlag == true)
            {
                textBox1.Text = btn.Text;
                opFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".")){
                return;
            }
            else if(textBox1.Text == "")
            {
                textBox1.Text += "0.";
            }
            else
                textBox1.Text += ".";
        }

        private void opbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Value = double.Parse(textBox1.Text);
            op = btn.Text;
            opFlag = true;
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            Double v = Double.Parse(textBox1.Text);
            switch(op)
            {
                case "+":
                    textBox1.Text = (Value + v).ToString();
                    break;
                case "-":
                    textBox1.Text = (Value - v).ToString();
                    break;
                case "x":
                    textBox1.Text = (Value * v).ToString();
                    break;
                case "/":
                    textBox1.Text = (Value / v).ToString();
                    break;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
