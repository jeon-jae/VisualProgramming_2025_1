namespace _007_bmi_Form
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
            this.lblH = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_H = new System.Windows.Forms.TextBox();
            this.txt_W = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(91, 143);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(108, 30);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "키(cm)";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(91, 264);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(158, 30);
            this.lblW.TabIndex = 1;
            this.lblW.Text = "몸무게(kg)";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(91, 404);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 30);
            this.lblBMI.TabIndex = 2;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(91, 482);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(93, 30);
            this.lbl_Result.TabIndex = 3;
            this.lbl_Result.Text = "판정 :";
            // 
            // txt_H
            // 
            this.txt_H.Location = new System.Drawing.Point(256, 143);
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(221, 42);
            this.txt_H.TabIndex = 4;
            // 
            // txt_W
            // 
            this.txt_W.Location = new System.Drawing.Point(256, 264);
            this.txt_W.Name = "txt_W";
            this.txt_W.Size = new System.Drawing.Size(221, 42);
            this.txt_W.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "BMI 계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_bmi);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(395, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 57);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_W);
            this.Controls.Add(this.txt_H);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblH);
            this.Name = "Form1";
            this.Text = "BMI 계산기 v.0.1 by 전재현";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.TextBox txt_W;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

