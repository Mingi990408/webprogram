using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _146
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text == "골드리트리버")
            {
                pictureBox1.Image = Bitmap.FromFile("C:/Users/Administrator/source/repos/146/이미지/골드리트리버.jpg");
                textBox1.Text = "이름대로 윤기가 흐르는 크림빛 또는 금빛의 풍성한 털이 가장 큰 특징이며 은은하게 귀티가 흐르는 인상이다. " +
                    "마당이 있는 집이 일반적인 미국과 영국, 또한 영국의 직할 속령이었던 아일랜드, 캐나다, 오스트레일리아나 뉴질랜드에서 자주 볼 수 있는 견종이라고 한다. " +
                    "신장 51~61cm, 체중 25~40kg 정도이다.";
            }
            else if(e.Node.Text == "진돗개")
            {
                // 이미지 넣기 
                pictureBox1.Image = Bitmap.FromFile("C:/Users/Administrator/source/repos/146/이미지/진돗개2.jpg");
                textBox1.Text = "표준어는 진돗개이나 천연기념물 상에서는 진도개로 등록되어 있는데, " +
                    "이는 원서식지인 진도를 분명히 드러내야 한다는 진도 지역의 의견을 문화재청이 수용하여 심사를 통과한 진도군의 진돗개에 한해서만 진도개라는 명칭을 사용한다. " +
                    "여담으로 일반 진돗개도 동물등록증에는 진도견으로 표기하기도 한다.";
            }
            else if (e.Node.Text == "보더콜리")
            {
                pictureBox1.Image = Bitmap.FromFile("C:/Users/Administrator/source/repos/146/이미지/보더콜리.jpg");
                textBox1.Text = "개의 품종 중 하나로 원산지는 영국으로 브리튼 섬의 품종인 콜리의 일종. 잉글랜드와 스코틀랜드의 국경(border) 지방에서 양치기 개로 사용되었기 때문에 보더 콜리라는 이름이 붙었다."
                    + "세계에서 가장 머리가 좋은 개로 유명하며 그 명성에 걸맞게 학습 능력이 매우 뛰어나다. 또한 어린 보더 콜리와 나이 든 보더 콜리를 같이 기르면, 노견이 어린 개에게 주인이 사용하는 명령어와 기타 생활에 대해 교육한다고 한다.";
            }
            else if (e.Node.Text == "말티즈")
            {
                pictureBox1.Image = Bitmap.FromFile("C:/Users/Administrator/source/repos/146/이미지/말티즈1.jpg");
                textBox1.Text = "몰타가 원산인 개의 한 품종이며 대표적인 소형견이다,국내 명칭은 말티즈/몰티즈가 혼재되는 편."
                    + "작은 체구와 깨끗해 보이는 하얀 털을 가진 귀여운 외모로 한국에서 반려견으로 인기가 많은 종이다. " +
                    "특히 다른 견종에 비해 털빠짐이 적고, 대체적으로 특별하게 까다로운 점이 질병 말고는 딱히 없기 때문에 강아지를 처음 키우는 사람들에게 비교적 적합한 견종이며, 아파트 같은 주택 내에서도 비교적 키우기 수월하여 한국인들의 사랑을 듬뿍 받고 있다. " +
                    "약간씩의 차이는 있지만, 대부분의 조사에서 한국인이 가장 선호하는 견종 1위에 올라있다.";
            }
            else
            {
                pictureBox1.Image = null;
                textBox1.Text = "";
            }
        }
    }
}
