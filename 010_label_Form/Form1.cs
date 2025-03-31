using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_label_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            string name;

            name = txtBox_name.Text;
            if (name != "")
            {
                lbl_name_Result.Text = name + "님! 안녕하세요!";
            }
            else
            {
                MessageBox.Show("이름을 입력하세요", "Waring!");
            }
            

        }
    }
}
