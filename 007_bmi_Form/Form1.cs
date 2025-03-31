using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_bmi_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_bmi(object sender, EventArgs e)
        {
            double height, weight, bmi;

            height = double.Parse(txt_H.Text);
            weight = double.Parse(txt_W.Text);

            height /= 100;

            bmi = weight / (height * height);

            //lblBMI.Text = "BMI = " + bmi.ToString();
            lblBMI.Text = string.Format("당신의 BMI = {0:F1}", bmi);

            if (bmi < 20) { lbl_Result.Text = "저체중"; pictureBox1.BackColor = Color.Yellow; }
            else if(20<=bmi && bmi < 25) { lbl_Result.Text = "정상체중"; pictureBox1.BackColor = Color.Green; }
            else if(25 <= bmi && bmi < 30) { lbl_Result.Text = "경도비만"; pictureBox1.BackColor = Color.Yellow; }
            else if(30 <= bmi && bmi < 40) { lbl_Result.Text = "비만"; pictureBox1.BackColor = Color.Orange; }
            else { lbl_Result.Text = "고도비만"; pictureBox1.BackColor = Color.Red; }
            // 원하는 것 주석처리 블록 잡고 Ctrl + KC 해제 시 Ctrl+KU
            // textBox는 입력, 출력 해줌


            

            

        }
    }
}
