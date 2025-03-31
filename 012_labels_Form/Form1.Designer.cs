namespace _012_labels_Form
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
            this.btn_raff = new System.Windows.Forms.Button();
            this.lbl_artist = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.btn_davinci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_raff
            // 
            this.btn_raff.Location = new System.Drawing.Point(75, 92);
            this.btn_raff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_raff.Name = "btn_raff";
            this.btn_raff.Size = new System.Drawing.Size(457, 66);
            this.btn_raff.TabIndex = 0;
            this.btn_raff.Text = "라파엘로, 아테네 학당";
            this.btn_raff.UseVisualStyleBackColor = true;
            this.btn_raff.Click += new System.EventHandler(this.btn_Raffaello);
            // 
            // lbl_artist
            // 
            this.lbl_artist.AutoSize = true;
            this.lbl_artist.Location = new System.Drawing.Point(81, 202);
            this.lbl_artist.Name = "lbl_artist";
            this.lbl_artist.Size = new System.Drawing.Size(0, 46);
            this.lbl_artist.TabIndex = 1;
            // 
            // lblArt
            // 
            this.lblArt.Location = new System.Drawing.Point(81, 328);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(1033, 312);
            this.lblArt.TabIndex = 2;
            // 
            // btn_davinci
            // 
            this.btn_davinci.Location = new System.Drawing.Point(576, 92);
            this.btn_davinci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_davinci.Name = "btn_davinci";
            this.btn_davinci.Size = new System.Drawing.Size(507, 66);
            this.btn_davinci.TabIndex = 3;
            this.btn_davinci.Text = "다빈치, 모나리자";
            this.btn_davinci.UseVisualStyleBackColor = true;
            this.btn_davinci.Click += new System.EventHandler(this.btn_davinci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.btn_davinci);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lbl_artist);
            this.Controls.Add(this.btn_raff);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_raff;
        private System.Windows.Forms.Label lbl_artist;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Button btn_davinci;
    }
}

