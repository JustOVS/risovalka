using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace risovalka
{
    class Circle : AbstractPainter
    {

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

            int r = Convert.ToInt32(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

            int xStep = 0;
            int yStep = r;

            for (int i = 0; i <= r; i++)
            {
                double catet = Math.Sqrt(r * r - i * i);



                AbstractPainter.DrawLine(xStep + x1, yStep + y1, i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
                AbstractPainter.DrawLine(-xStep + x1, yStep + y1, -i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
                AbstractPainter.DrawLine(xStep + x1, -yStep + y1, i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
                AbstractPainter.DrawLine(-xStep + x1, -yStep + y1, -i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
                xStep = i;
                yStep = Convert.ToInt32(catet);


            }


        }
        //public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
        //{

        //    int a = 2 *Math.Abs(x2 - x1);
        //    int b = 2 *Math.Abs(y2 - y1);

        //    int xStep = 0;
        //    int yStep = b;

        //    for (int i = 0; i <= a; i++)
        //    {
        //        double catet = (1 - (x1 + xStep) * (x1 +xStep)) * b * b;



        //        AbstractPainter.DrawLine(xStep + x1, yStep + y1, i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        AbstractPainter.DrawLine(-xStep + x1, yStep + y1, -i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        AbstractPainter.DrawLine(xStep + x1, -yStep + y1, i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        AbstractPainter.DrawLine(-xStep + x1, -yStep + y1, -i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        xStep = i;
        //        yStep = Convert.ToInt32(catet);


        //    }


        //}



    }


}
