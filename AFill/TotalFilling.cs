using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using risovalka;


namespace risovalka.AFill
{
    public class TotalFilling : AbstractFilling

    {
        public TotalFilling(Color fillingColor) : base(fillingColor)
        {

        }
        public override void Fill(Point p1, PictureBox pictureBox, Bitmap newBitmap)

        {


            Brush brush = new Brush(fillingColor, 1);
            int x = p1.X;
            int y = p1.Y;
            int leftChecking = x;
            int rightChecking = x;

            
            Color localColor = newBitmap.GetPixel(x, y);
            if (localColor.ToArgb() != fillingColor.ToArgb()) //|| localColor.R != fillingColor.R || localColor.G != fillingColor.G || localColor.B != fillingColor.B)
            {

                while (newBitmap.GetPixel(leftChecking - 1, y) == localColor && leftChecking - 1 > 0)
                {
                    leftChecking--;
                }

                while (newBitmap.GetPixel(rightChecking + 1, y) == localColor && rightChecking + 1 < newBitmap.Width - 1)
                {
                    rightChecking++;
                }

                brush.DrawLine(new Point(leftChecking, y), new Point(rightChecking, y), pictureBox, brush.currentColor, newBitmap);

                for (int i = leftChecking; i <= rightChecking; i++)
                {
                    if (newBitmap.GetPixel(i, y - 1) == localColor && y - 1 > 0)
                    {
                        Fill(new Point(i, y - 1), pictureBox, newBitmap);
                    }

                    if (newBitmap.GetPixel(i, y + 1) == localColor && y + 1 < newBitmap.Height - 1)
                    {
                        Fill(new Point(i, y + 1), pictureBox, newBitmap);
                    }
                }
            }
        }
        
    }
}
