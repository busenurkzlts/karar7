namespace karar7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(textBox1.Text);
            int deger2 = Convert.ToInt32(textBox2.Text);
            int sonuc;
            if (radioButton1.Checked == true)
            {
                label4.Text = (deger1 + deger2).ToString();
            }
            else
            {
                label4.Text = (deger1 - deger2).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}