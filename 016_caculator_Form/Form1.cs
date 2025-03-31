using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_caculator_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Result(object sender, EventArgs e)
        {
            double korean, math, english, average, result;

            

            if (txt_K.Text != "" && txt_M.Text != "" && txt_E.Text != "")
            {
                korean = double.Parse(txt_K.Text);
                math = double.Parse(txt_M.Text);
                english = double.Parse(txt_E.Text);

                result = korean + math + english;

                txt_Result.Text = string.Format($"{result:F1}");

                average = result / 3;

                txt_average.Text = string.Format($"{average:F1}");
            }
            else
            {
                MessageBox.Show("성적을 입력하십시오.", "Waring");
                return;
            }
            

            

            

        }
    }
}
