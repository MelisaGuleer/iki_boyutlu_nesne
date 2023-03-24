namespace iki_boyutlu_nesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top -= 5;
            if (pictureBox2.Top <= 27)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 5; 
            if(pictureBox2.Left >= 632)
            {
                timer2.Stop();
                timer3.Start();

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top += 5;
            if (pictureBox2.Top >= 334)
            {
                timer3.Stop();
                timer4.Start();

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 5;
            if(pictureBox2.Left <= 55)
            {
                timer4.Stop();
                timer1.Start();
            }
                
        }
    }
}