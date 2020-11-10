using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(400, 300);
        public Form1()
        {
            InitializeComponent();
            SetClientSizeCore(500, 400);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.Yellow);
            for(int i = 0; i < 10; i++)
            {
                //bitmapGraphics.DrawString("C#", Font, Brushes.Black, 10, 10 + (20 * i));
                e.Graphics.DrawString("C#", Font, Brushes.Black, 10, 10 + (20 * i));
            }
            //bitmapGraphics.DrawRectangle(Pens.Black, 150, 10, 200, 100);

            e.Graphics.DrawRectangle(Pens.Black, 150, 10, 200, 100);

            e.Graphics.DrawImage(bitmap, 0, 0);

            //======================================

            //Bitmap myBitmap = new Bitmap("Z7XjCo1.jpeg");
            //SetClientSizeCore(myBitmap.Width, myBitmap.Height);
            //e.Graphics.DrawImage(myBitmap, 0, 0);
        }
    }
}
