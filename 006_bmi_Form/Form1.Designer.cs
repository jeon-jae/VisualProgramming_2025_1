﻿namespace _006_bmi_Form
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
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("맑은 고딕", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblH.Location = new System.Drawing.Point(108, 101);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(165, 62);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "키(cm)";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("맑은 고딕", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblW.Location = new System.Drawing.Point(108, 195);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(248, 62);
            this.lblW.TabIndex = 1;
            this.lblW.Text = "몸무게(kg)";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("맑은 고딕", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBMI.Location = new System.Drawing.Point(108, 345);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 62);
            this.lblBMI.TabIndex = 2;
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("맑은 고딕", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtH.Location = new System.Drawing.Point(385, 105);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(301, 70);
            this.txtH.TabIndex = 3;
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("맑은 고딕", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtW.Location = new System.Drawing.Point(385, 187);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(301, 70);
            this.txtW.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(432, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "BMI 계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_bmi);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblH);
            this.Name = "Form1";
            this.Text = "BMI 계산기 v.0.2 by 전재현";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Button button1;
    }
}

