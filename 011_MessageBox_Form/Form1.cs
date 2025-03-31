using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_MessageBox_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Form이 로드될때, 즉 프로그램이 시작될 때
        {
            MessageBox.Show("가장 간단한 메시지 박스");
            
            MessageBox.Show("타이틀이 있는 메시지 박스", "타이틀"); // 두개를 가장 많이 씀

            DialogResult r1 // 선택한걸 표시하기 위해 변수로 값을 받고
                = MessageBox.Show("두개의 버튼을 받는 메시지 박스", "타이틀", MessageBoxButtons.YesNo);

            DialogResult r2
                = MessageBox.Show("세개의 버튼과 물음표 메시지 박스", "타이틀", MessageBoxButtons.YesNoCancel , MessageBoxIcon.Question);

            DialogResult r3
                =MessageBox.Show("디폴트 버튼을 두 번째 버튼으로 \n 지정한 메시지박스입니다.", "Question", MessageBoxButtons.YesNoCancel,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            MessageBox.Show("느낌표와 알람 메시지박스입니다.", "느낌표와 알람 소리", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //string msg = string.Format($"당신의 선택은 {r1.ToString()} , {r2.ToString()}, {r3.ToString()}");

            string msg = string.Format("당신의 선택 {0}, {1}, {2}", r1.ToString(), r2.ToString(), r3.ToString()); // 여기서 선택 값들 모아 출력
            MessageBox.Show(msg, "Your Select");

            DialogResult r4
            = MessageBox.Show("메세지 박스 안 내용", "메세지 박스 창 이름", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);



        }
    }
}
