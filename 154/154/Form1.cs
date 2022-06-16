using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _154
{
    public partial class Form1 : Form
    {
        Timer time = new Timer();
        public Form1()
        {
            InitializeComponent();
            time.Interval = 1000;
            time.Tick += Time_Tick;
            time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();   
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog = new FontDialog();

            fontdialog.ShowColor = true;
            fontdialog.ShowEffects = true;
            fontdialog.Font = label1.Font;
            fontdialog.Color = label1.ForeColor;

            if(fontdialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontdialog.Font;
                label1.ForeColor = fontdialog.Color;
            }
        }
    }
}
