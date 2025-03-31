using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_RadioButton_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Submit(object sender, EventArgs e)
        {
            string Result = "";

            RadioButton[] rBox = { rbKorea, rbChina, rbJapan, rbOthers, rbFemale, rbMale };

            foreach (var item in rBox) //해보기
            {
                if(item.Checked == true) { Result += item.Text + " "; } //라디오 버튼이 선택되면 그 선택된걸 추가 후 빈칸 추가
            }

            //if (rbKorea.Checked) { Result += "국적 : 대한민국\n"; }
            //else if (rbChina.Checked) { Result += "국적 : 중국\n"; }
            //else if (rbJapan.Checked) { Result += "국적 : 일본\n"; }
            //else if (rbOthers.Checked) { Result += "국적 : 그 외 국가\n"; } // 넷 중에 하나만 True

            //if (rbMale.Checked) { Result += "성별 : 남성"; }
            //else if (rbFemale.Checked) { Result += "성별 : 여성"; }

            MessageBox.Show(Result, "결과"); //결과라는 메시지와 결과 값 출력


        }
    }
}
