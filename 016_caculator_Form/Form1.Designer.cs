namespace _016_caculator_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_K = new System.Windows.Forms.TextBox();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.txt_E = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.txt_average = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_E);
            this.groupBox1.Controls.Add(this.txt_M);
            this.groupBox1.Controls.Add(this.txt_K);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(44, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "수학";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "영어";
            // 
            // txt_K
            // 
            this.txt_K.Location = new System.Drawing.Point(183, 85);
            this.txt_K.Name = "txt_K";
            this.txt_K.Size = new System.Drawing.Size(178, 51);
            this.txt_K.TabIndex = 3;
            this.txt_K.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_M
            // 
            this.txt_M.Location = new System.Drawing.Point(183, 148);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(178, 51);
            this.txt_M.TabIndex = 4;
            this.txt_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_E
            // 
            this.txt_E.Location = new System.Drawing.Point(183, 211);
            this.txt_E.Name = "txt_E";
            this.txt_E.Size = new System.Drawing.Size(178, 51);
            this.txt_E.TabIndex = 5;
            this.txt_E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_average);
            this.groupBox2.Controls.Add(this.txt_Result);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(584, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "총점";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "평균";
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Result.Location = new System.Drawing.Point(171, 65);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(121, 51);
            this.txt_Result.TabIndex = 2;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_average
            // 
            this.txt_average.Location = new System.Drawing.Point(171, 134);
            this.txt_average.Name = "txt_average";
            this.txt_average.ReadOnly = true;
            this.txt_average.Size = new System.Drawing.Size(121, 51);
            this.txt_average.TabIndex = 3;
            this.txt_average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnresult
            // 
            this.btnresult.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnresult.Location = new System.Drawing.Point(622, 468);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(180, 62);
            this.btnresult.TabIndex = 2;
            this.btnresult.Text = "계산";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btn_Result);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 655);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_E;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.TextBox txt_K;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_average;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnresult;
    }
}

