using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmi_Form
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

        private void btn_bmi(object sender, EventArgs e) //btn_bmi가 Click 되었을 때 생기는 이벤트를 처리하는 함수
        {//sender 이벤트를 보내주는 (button같은것) ,
            double weight, height, bmi;

            height = double.Parse(txtH . Text); //txtH의 Text를 받아 double 로 변환 후 height에 넣음
            weight = double.Parse(txtW . Text); //txtW의 Text를 받아 double 로 변환 후 weight에 넣음

            height /= 100;

            bmi = weight / (height * height);

            lblBMI.Text = string.Format($"BMI = {0:F2bmi}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
