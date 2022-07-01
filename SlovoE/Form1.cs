namespace SlovoE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Point o;
        Random r = new Random();
        int a;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            a = 30;
            o = new Point(0, a);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Color b = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Slovo slovo = new Slovo(o, a, b);
            slovo.Crtaj(g);
            o.X += (a + 10);
            if (o.X > ClientRectangle.Width)
            {
                o.X = 0;
                o.Y += 2 * a + 10;
            }
        }
    }
}