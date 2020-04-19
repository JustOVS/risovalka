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

        //public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
        //{

        //    int r = Convert.ToInt32(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

        //    int xStep = 0;
        //    int yStep = r;

        //    for (int i = 0; i <= r; i++)
        //    {
        //        double catet = Math.Sqrt(r * r - i * i);



        //        AbstractPainter.DrawLine(xStep + x1, yStep + y1, i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        AbstractPainter.DrawLine(-xStep + x1, yStep + y1, -i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        AbstractPainter.DrawLine(xStep + x1, -yStep + y1, i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        AbstractPainter.DrawLine(-xStep + x1, -yStep + y1, -i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
        //        xStep = i;
        //        yStep = Convert.ToInt32(catet);


        //    }


        //}
        public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
        {

            //double a =  Math.Abs((double)(x2 - x1)/2);
            //double b =  Math.Abs((double)(y2 - y1)/2);
            //double tmp;
            //if (b > a)
            //{
            //    tmp = a;
            //    a = b;
            //    b = tmp;

            //}

            //int xStep = 0;
            //double yStep = b;
            //x1 = (x1 + x2) / 2;
            //y1 = (y1 + y2) / 2;

            //for (int i = 0; i <= a; i++)
            //{
            //    double catet = Math.Sqrt((1 - (i) * (i) /a / a * b * b)) + y1;



            //    AbstractPainter.DrawLine(xStep + x1, (int)yStep + y1, i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
            //    AbstractPainter.DrawLine(-xStep + x1, (int)yStep + y1, -i + x1, Convert.ToInt32(catet) + y1, pictureBox, currentColor);
            //    AbstractPainter.DrawLine(xStep + x1, (int)-yStep + y1, i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
            //    AbstractPainter.DrawLine(-xStep + x1, (int)-yStep + y1, -i + x1, -Convert.ToInt32(catet) + y1, pictureBox, currentColor);
            //    xStep = i;
            //    yStep = Convert.ToInt32(catet);


            //}
            //int xStep = 0;
            //double yStep = b;
            //x1 = (x1 + x2) / 2;
            //y1 = (y1 + y2) / 2 + (int)b;

            //for (int i = 0; i < 360; i++)
            //{
            //    //double catet = Math.Sqrt((1 - (i) * (i) / a / a * b * b)) + y1;
            //    x2 = (int)a * (int)Math.Cos(i);
            //    y2 = (int)b * (int)Math.Sin(i);

            //    AbstractPainter.DrawLine(x1, y1, x2, y2, pictureBox, currentColor);

            //    x1 = x2;
            //    y1 = y2;


            //}
            bool horizontalOrientationFlag = false;
            int majorAxis;
            int smallAxis;
            
            if (Math.Abs(x2 - x1) > Math.Abs(y2 - y1))
            {
                majorAxis = Math.Abs(x2 - x1);
                smallAxis = Math.Abs(y2 - y1);
               
                horizontalOrientationFlag = true;
            }

            else
            {
                majorAxis = Math.Abs(y2 - y1);
                smallAxis = Math.Abs(x2 - x1);
            }
            //if (big == 0)
            //{
            //    return;
            //}
            int stepX = 0;
            int stepY = 0;

            for (int i = 0; i <= majorAxis; i++)
            {
                double x; 
                double y;

                if (horizontalOrientationFlag)
                {
                    x = i;
                    y = Math.Sqrt((Math.Pow(smallAxis, 2) / Math.Pow(majorAxis, 2)) * (Math.Pow(smallAxis, 2) - Math.Pow(x, 2)));
                }
                else
                {
                    y = i;
                    x = Math.Sqrt((Math.Pow(smallAxis, 2) / Math.Pow(majorAxis, 2)) * (Math.Pow(majorAxis, 2) - Math.Pow(y, 2)));
                }
                if (i == 0)
                {
                    AbstractPainter.DrawLine(Convert.ToInt32(x1 + x), y1 + stepY, Convert.ToInt32(x1 + x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
                    AbstractPainter.DrawLine(Convert.ToInt32(x1 + x), y1 - stepY, Convert.ToInt32(x1 + x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
                    AbstractPainter.DrawLine(Convert.ToInt32(x1 - x), y1 - stepY, Convert.ToInt32(x1 - x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
                    AbstractPainter.DrawLine(Convert.ToInt32(x1 - x), y1 + stepY, Convert.ToInt32(x1 - x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
                    stepX = Convert.ToInt32(x);
                    stepY = Convert.ToInt32(y);
                }
                else
                {


                    AbstractPainter.DrawLine(x1 + stepX, y1 + stepY, Convert.ToInt32(x1 + x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
                    AbstractPainter.DrawLine(x1 + stepX, y1 - stepY, Convert.ToInt32(x1 + x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
                    AbstractPainter.DrawLine(x1 - stepX, y1 - stepY, Convert.ToInt32(x1 - x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
                    AbstractPainter.DrawLine(x1 - stepX, y1 + stepY, Convert.ToInt32(x1 - x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
                    stepX = Convert.ToInt32(x);
                    stepY = Convert.ToInt32(y);
                }

            }
        }
    }



}


