using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace risovalka
{
    public class Polygon : AbstractPainter
    {
        public static  int nSides = 6;
        int[] points = new int[2* nSides];
        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            if (AbstractPainter.drawStartFinishFlag == true)
            {

                Canvas.currentBitmap = new Bitmap(Canvas.tmpBitmap);
                DrawFigure(AbstractPainter.x1, AbstractPainter.y1, e.X, e.Y, pictureBox, Brush.currentColor);

                pictureBox.Image = Canvas.currentBitmap;

            }

        }

        public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
        {
            double angle = 0; int i = 0;
            int radius = Convert.ToInt32(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            //int j = 0;
            while (i < nSides + 1)
            {
                //int radius = Convert.ToInt32(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
                // int radius = (int)(Math.Round(Math.Sqrt(Math.Pow(((double)e.Y - (double)AbstractPainter.x1), 2) + Math.Pow(((double)e.X - (double)AbstractPainter.y1), 2))));
                //int j = 0;
                points[i] = AbstractPainter.x1 + (int)(Math.Round(Math.Cos(angle / 180 * Math.PI) * radius));
                //j++;
                points[i] = AbstractPainter.y1 - (int)(Math.Round(Math.Sin(angle / 180 * Math.PI) * radius));
                //j++;
                angle += 180 *(nSides -2)/ nSides;
                i++;
            }

            for (int k = 0; k < points.Length-1; k += 2)
            {
                if (k == points.Length - 2)
                {
                    AbstractPainter.DrawLine(points[k], points[k + 1], points[1], points[k+radius ], pictureBox, currentColor );
                }
                else
                {
                    AbstractPainter.DrawLine(points[k], points[k+1], points[k + 2], points[k + 3], pictureBox, currentColor);
                }
            }
        }
    }
}









