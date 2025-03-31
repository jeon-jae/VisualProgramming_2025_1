using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_bmi_Form
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string id, user_id;
            int pw, user_pw;

            id = (txtbox_ID.Text);
            pw = int.Parse(txtbox_PW.Text);

            user_id = "abcd";
            user_pw = 1234;

            if (id == user_id )
            {
                if (pw == user_pw) { txtbox_Login_Result.Text = "로그인 성공"; }
                else { txtbox_Login_Result.Text = "로그인 실패"; }
            }
            else { txtbox_Login_Result.Text = "로그인 실패"; }
        }
    }
}
