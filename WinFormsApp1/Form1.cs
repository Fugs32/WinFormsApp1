namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Random r = new Random(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void MoveButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            
            this.BackColor = GetRandomColor();

            int maxX = this.Size.Width;
            maxX -= this.Size.Width;
            int maxY = b.Size.Height;
            maxY -= b.Size.Height;

            int x = r.Next(200);
            int y = r.Next(200);

            Point p = new Point(10, 10);
            p.X = r.Next(12, 713);
            p.Y = r.Next(12, 415);
            b.Location = p;
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Point p = new Point(10, 10);
            p.X = r.Next(12, 713);
            p.Y = r.Next(12, 415);
            b.Location = p;
        }
    }
}
