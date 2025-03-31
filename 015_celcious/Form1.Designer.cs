namespace _015_celcious
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_F = new System.Windows.Forms.Label();
            this.txtB_C = new System.Windows.Forms.TextBox();
            this.txtB_F = new System.Windows.Forms.TextBox();
            this.btnch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(343, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "온도변환기";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Location = new System.Drawing.Point(349, 228);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(73, 30);
            this.lbl_C.TabIndex = 1;
            this.lbl_C.Text = "섭씨";
            // 
            // lbl_F
            // 
            this.lbl_F.AutoSize = true;
            this.lbl_F.Location = new System.Drawing.Point(845, 228);
            this.lbl_F.Name = "lbl_F";
            this.lbl_F.Size = new System.Drawing.Size(73, 30);
            this.lbl_F.TabIndex = 2;
            this.lbl_F.Text = "화씨";
            // 
            // txtB_C
            // 
            this.txtB_C.Location = new System.Drawing.Point(101, 225);
            this.txtB_C.Name = "txtB_C";
            this.txtB_C.Size = new System.Drawing.Size(215, 42);
            this.txtB_C.TabIndex = 3;
            // 
            // txtB_F
            // 
            this.txtB_F.Location = new System.Drawing.Point(577, 228);
            this.txtB_F.Name = "txtB_F";
            this.txtB_F.Size = new System.Drawing.Size(215, 42);
            this.txtB_F.TabIndex = 4;
            // 
            // btnch
            // 
            this.btnch.BackColor = System.Drawing.Color.Teal;
            this.btnch.Location = new System.Drawing.Point(354, 341);
            this.btnch.Name = "btnch";
            this.btnch.Size = new System.Drawing.Size(249, 57);
            this.btnch.TabIndex = 5;
            this.btnch.Text = "변환하기";
            this.btnch.UseVisualStyleBackColor = false;
            this.btnch.Click += new System.EventHandler(this.btn_ch);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "섭씨 = (화씨 - 32) x 5 / 9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "화씨 = 섭씨 x 9 / 5 + 32";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1026, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnch);
            this.Controls.Add(this.txtB_F);
            this.Controls.Add(this.txtB_C);
            this.Controls.Add(this.lbl_F);
            this.Controls.Add(this.lbl_C);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "온도변환기 v.0.1 by전재현";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_F;
        private System.Windows.Forms.TextBox txtB_C;
        private System.Windows.Forms.TextBox txtB_F;
        private System.Windows.Forms.Button btnch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

