namespace _008_bmi_Form
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_PW = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.txtbox_PW = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtbox_Login_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ID.Location = new System.Drawing.Point(96, 149);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(122, 46);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "아이디";
            // 
            // lbl_PW
            // 
            this.lbl_PW.AutoSize = true;
            this.lbl_PW.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_PW.Location = new System.Drawing.Point(96, 257);
            this.lbl_PW.Name = "lbl_PW";
            this.lbl_PW.Size = new System.Drawing.Size(156, 46);
            this.lbl_PW.TabIndex = 1;
            this.lbl_PW.Text = "비밀번호";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_ID.Location = new System.Drawing.Point(282, 146);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(285, 51);
            this.txtbox_ID.TabIndex = 2;
            // 
            // txtbox_PW
            // 
            this.txtbox_PW.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_PW.Location = new System.Drawing.Point(282, 257);
            this.txtbox_PW.Name = "txtbox_PW";
            this.txtbox_PW.PasswordChar = '●';
            this.txtbox_PW.Size = new System.Drawing.Size(285, 51);
            this.txtbox_PW.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Login.Location = new System.Drawing.Point(353, 373);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(214, 63);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtbox_Login_Result
            // 
            this.txtbox_Login_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Login_Result.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_Login_Result.Location = new System.Drawing.Point(101, 461);
            this.txtbox_Login_Result.Name = "txtbox_Login_Result";
            this.txtbox_Login_Result.ReadOnly = true;
            this.txtbox_Login_Result.Size = new System.Drawing.Size(223, 44);
            this.txtbox_Login_Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 618);
            this.Controls.Add(this.txtbox_Login_Result);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtbox_PW);
            this.Controls.Add(this.txtbox_ID);
            this.Controls.Add(this.lbl_PW);
            this.Controls.Add(this.lbl_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_PW;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.TextBox txtbox_PW;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtbox_Login_Result;
    }
}

