using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BufferedGraphicsContext context;
        BufferedGraphics graphics;
        Image myImage;
        public Form1()
        {
            InitializeComponent();

            context = BufferedGraphicsManager.Current;
            context.MaximumBuffer = new Size(800, 600);
            graphics = context.Allocate(CreateGraphics(), new Rectangle(0, 0, 800, 600));
            myImage = Image.FromFile("flicker.png");
            SetClientSizeCore(800, 600);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rand = new Random();
            for(int i = 0; i < 1000; i++)
            {
                graphics.Graphics.DrawImage(myImage, rand.Next(0, 700), rand.Next(0, 500));
            }
            graphics.Render(e.Graphics);
        }
    }
}
