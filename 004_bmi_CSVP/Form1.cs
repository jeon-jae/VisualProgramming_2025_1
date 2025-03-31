namespace _004_bmi_CSVP
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_bmi(object sender, EventArgs e)
        {
            double height, weight;

            height = double.Parse(textBox1.Text);
            weight = double.Parse(textBox2.Text);
            double bmi = weight / (height / 100) * (height / 100);
            label4.Text = "BMI = " + bmi;

            
        }

        
    }
}
