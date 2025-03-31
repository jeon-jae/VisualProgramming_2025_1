using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_combobox_Form
{
    public partial class Form1: Form
    {

        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능I";
            txt2.Text = "일반수학 I";
            txt3.Text = "전자공학";
            txt4.Text = "비주얼 프로그래밍";
            txt5.Text = "설계 및 프로젝트 기본";
            txt6.Text = "데이터 사이언스";


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
