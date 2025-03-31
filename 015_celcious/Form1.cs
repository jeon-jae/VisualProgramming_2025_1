using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_celcious
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ch(object sender, EventArgs e)
        {

            double c, f = 0;

            if (txtB_C.Text == "")
            {
                f = (double.Parse(txtB_F.Text) - 32) * 5 / 9;
                txtB_C.Text = f.ToString("#.##");

            }

            else if (txtB_F.Text == "")
            {
                c = (double.Parse(txtB_C.Text) * 9 / 5 + 32);
                txtB_F.Text = c.ToString("#.##");
            }


            //if (txtB_C.Text != "")
            //{
            //    double f = (double.Parse(txtB_C.Text) * 9 / 5 + 32);
            //    txtB_F.Text = f.ToString("#.##");

            //}
            //else if (txtB_F.Text != "")
            //{
            //    double c = (double.Parse(txtB_F.Text) - 32) * 5 / 9;
            //    txtB_C.Text = c.ToString("#.##");

            //}

        }
    }
}
