using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_bmi_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bmi(object sender, EventArgs e)
        {
            double height, weight, bmi;

            height = double.Parse(txtH.Text);
            weight = double.Parse(txtW.Text);

            height /= 100;

            bmi = weight / (height * height);

            lblBMI.Text = "BMI = " + bmi;




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
