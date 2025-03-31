namespace _004_bmi_CSVP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 165);
            label2.Name = "label2";
            label2.Size = new Size(106, 41);
            label2.TabIndex = 3;
            label2.Text = "키(cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 237);
            label3.Name = "label3";
            label3.Size = new Size(159, 41);
            label3.TabIndex = 4;
            label3.Text = "몸무게(kg)";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(276, 322);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 5;
            button1.Text = "계산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_bmi;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 375);
            label4.Name = "label4";
            label4.Size = new Size(104, 41);
            label4.TabIndex = 6;
            label4.Text = "BMI =";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 486);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "BMI 계산기";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
