namespace digersubevize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ucret = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            
            
            {

            }
            
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Masa No:"+textBox1.Text+"Hesap:"+ucret);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lutfen masa numaranizi giriniz!");

            }
            else return;
        }

        private void button13_Click(object sender, EventArgs e)
        {
          listBox1.Items.RemoveAt(listBox1.Items.Count-1);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza");
            ucret += 40;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hamburger");
            ucret += 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Makarna");
            ucret += 25;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Salata");
            ucret += 30;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ekler");
            ucret += 35;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pasta");
            ucret += 60;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kola");
            ucret += 10;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sprite");
            ucret += 12;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("IceTea");
            ucret += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çay");
            ucret += 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Su");
            ucret += 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kahve");
            ucret += 20;
        }


    }
}