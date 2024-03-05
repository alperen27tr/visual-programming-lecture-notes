using System.Security.Cryptography.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Screen.AllScreens[0].Bounds.X.ToString();
            label2.Text = Screen.AllScreens[0].Bounds.Y.ToString();
            label3.Text = Screen.AllScreens[0].Bounds.Width.ToString();
            label4.Text = Screen.AllScreens[0].Bounds.Height.ToString();

            label5.Text = Screen.AllScreens[0].WorkingArea.X.ToString();
            label6.Text = Screen.AllScreens[0].WorkingArea.Y.ToString();
            label7.Text = Screen.AllScreens[0].WorkingArea.Width.ToString();
            label8.Text = Screen.AllScreens[0].WorkingArea.Height.ToString();

            label9.Text = Screen.AllScreens[0].BitsPerPixel.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y, w, h ;

            x= Screen.PrimaryScreen.Bounds.Size.Width /4;
            y= Screen.PrimaryScreen.Bounds.Size.Height /4;
            w = Screen.PrimaryScreen.Bounds.Size.Width /2;
            h = Screen.PrimaryScreen.Bounds.Size.Height /2;

            this.Left= x;
            this.Top= y;
            this.Width= w;
            this.Height= h;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap resim = new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(resim);

            grafik.CopyFromScreen(0,0,0,0, new Size (resim.Width,resim.Height));

            pictureBox1.Image = resim;

            resim.Save("D:\\ekran.bmp");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Bitmap resim = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(resim);

            grafik.CopyFromScreen(this.Left+7,this.Top,0,0, new Size(this.Width, this.Height));

            pictureBox1.Image = resim;

            resim.Save("D:\\ekran.bmp");
            

        }
    }
}
