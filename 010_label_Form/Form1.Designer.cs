namespace _010_label_Form
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.btn_name = new System.Windows.Forms.Button();
            this.lbl_name_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(23, 34);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(119, 46);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "이름 : ";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(139, 34);
            this.txtBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(206, 51);
            this.txtBox_name.TabIndex = 1;
            this.txtBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_name.TextChanged += new System.EventHandler(this.txtBox_name_TextChanged);
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(372, 34);
            this.btn_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(120, 55);
            this.btn_name.TabIndex = 2;
            this.btn_name.Text = "클릭";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // lbl_name_Result
            // 
            this.lbl_name_Result.AutoSize = true;
            this.lbl_name_Result.Location = new System.Drawing.Point(23, 108);
            this.lbl_name_Result.Name = "lbl_name_Result";
            this.lbl_name_Result.Size = new System.Drawing.Size(0, 46);
            this.lbl_name_Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(554, 211);
            this.Controls.Add(this.lbl_name_Result);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.lbl_name);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Label lbl_name_Result;
    }
}

