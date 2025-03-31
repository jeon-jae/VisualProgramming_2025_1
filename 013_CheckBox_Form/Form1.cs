using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_CheckBox_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit(object sender, EventArgs e)
        {
            string s = "좋아하는 과일은 : ";

            //if (checkBox1.Checked == true) s += checkBox1.Text + " "; // checkBox가 체크되면 문자열에 체크박스 문자를 추가하라
            //if (checkBox2.Checked == true) s += checkBox2.Text + " ";
            //if (checkBox3.Checked == true) s += checkBox3.Text + " ";
            //if (checkBox4.Checked == true) s += checkBox4.Text + " ";
            //if (checkBox5.Checked == true) s += checkBox5.Text + " ";

            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 }; //배열

            foreach(var item in cBox) // cBox 배열 안에 있는 각각의 원소 아이템에 대해서 //외우기 체크박스는 대부분 이렇게 씀
            {
                if(item.Checked == true) { s += item.Text + " "; } //아이템에 체크가 되면 해당 아이템 내용과 빈칸 추가
            }


            MessageBox.Show(s); 

            string t = "";

            foreach (var item in cBox)
            {
                t += string.Format("{0} : {1} \n ", item.Text, item.Checked);
            }
        }
    }
}
