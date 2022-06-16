using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _173
{
    public partial class Form1 : Form
    {
        // 메모장에 값이 있는지 없는지 확인하는 변수
        private bool modiftFlag = false;
        // 파일 제목
        private string fileName = "noname.txt";

        public Form1()
        {
            InitializeComponent();
            this.Text = fileName + " - myNotePad";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox 안에 값이 바뀜
            modiftFlag = true;
        }
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();
            textBox1.Text = "";
            modiftFlag = false;
            fileName = "noname.txt";
        }

        
        // 메모장에 값이 있는 중에 이벤트 발생 시
        private void FileProcessBeforeClose()
        {
            if(modiftFlag == true)
            {
                // 자식 폼 만들기
                DialogResult ans = MessageBox.Show("변경된 내용을 저장하겠습니까?", "저장", MessageBoxButtons.YesNo);
                if(ans == DialogResult.Yes)
                {
                    if(fileName == "noname.txt")    // 파일이름 미지정 시
                    {
                        if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(saveFileDialog2.FileName);
                            sw.WriteLine(textBox1.Text);
                            sw.Close();
                        }
                    }
                    else                            // 파일이름 지정 시
                    {
                        StreamWriter sw = File.CreateText(fileName);
                        sw.WriteLine(textBox1.Text);
                        sw.Close();
                    }
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();

            openFileDialog2.ShowDialog();
            fileName = openFileDialog2.FileName;
            this.Text = fileName + " - myNotePad";
            try
            {
                StreamReader r = File.OpenText(fileName);
                textBox1.Text = r.ReadToEnd();

                modiftFlag =false;
                r.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileName == "noname.txt")
            {
                saveFileDialog2.ShowDialog();
                fileName = saveFileDialog2.FileName;
            }
            StreamWriter sw = File.CreateText(fileName);
            sw.Write(textBox1.Text);

            modiftFlag = false;
            sw.Close();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();
            Close();
        }

        private void 복사하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.SelectedText, true);
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject ido = Clipboard.GetDataObject();
            if (ido.GetDataPresent(typeof(string)))
            {
                textBox1.SelectedText += (string)ido.GetData(typeof(string));
                modiftFlag = true;
            }
        }
    }
}
