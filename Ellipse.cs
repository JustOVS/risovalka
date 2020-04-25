//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//using System.Windows.Forms;

//namespace risovalka
//{
//    class Ellipse : AbstractPainter
//    {

//        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
//        {
//            if (AbstractPainter.drawStartFinishFlag == true)
//            {

//                apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
//                DrawFigure(AbstractPainter.x1, AbstractPainter.y1, e.X, e.Y, pictureBox, Brush.currentColor);

//                pictureBox.Image = apCanvas.currentBitmap;

//            }
//        }
//        public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
//        {

//            bool horizontalOrientationFlag = false;
//            int majorAxis;
//            int smallAxis;

//            if (Math.Abs(x2 - x1) > Math.Abs(y2 - y1))
//            {
//                majorAxis = Math.Abs(x2 - x1);
//                smallAxis = Math.Abs(y2 - y1);

//                horizontalOrientationFlag = true;
//            }

//            else
//            {
//                majorAxis = Math.Abs(y2 - y1);
//                smallAxis = Math.Abs(x2 - x1);
//            }

//            int stepX = 0;
//            int stepY = 0;

//            for (int i = 0; i <= majorAxis; i++)
//            {
//                double x;
//                double y;

//                if (majorAxis == 0)
//                {
//                    break;
//                }

//                else if (horizontalOrientationFlag)
//                {
//                    x = i;
//                    y = Math.Sqrt((Math.Pow(smallAxis, 2) / Math.Pow(majorAxis, 2)) * (Math.Pow(majorAxis, 2) - Math.Pow(x, 2)));
//                }
//                else
//                {
//                    y = i;
//                    x = Math.Sqrt((Math.Pow(smallAxis, 2) / Math.Pow(majorAxis, 2)) * (Math.Pow(majorAxis, 2) - Math.Pow(y, 2)));
//                }
//                if (i == 0)
//                {
//                    AbstractPainter.DrawLine(Convert.ToInt32(x1 + x), Convert.ToInt32(y1 + y), Convert.ToInt32(x1 + x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
//                    AbstractPainter.DrawLine(Convert.ToInt32(x1 + x), Convert.ToInt32(y1 - y), Convert.ToInt32(x1 + x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
//                    AbstractPainter.DrawLine(Convert.ToInt32(x1 - x), Convert.ToInt32(y1 - y), Convert.ToInt32(x1 - x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
//                    AbstractPainter.DrawLine(Convert.ToInt32(x1 - x), Convert.ToInt32(y1 + y), Convert.ToInt32(x1 - x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
//                    stepX = Convert.ToInt32(x);
//                    stepY = Convert.ToInt32(y);
//                }
//                else
//                {

//                    AbstractPainter.DrawLine(x1 + stepX, y1 + stepY, Convert.ToInt32(x1 + x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
//                    AbstractPainter.DrawLine(x1 + stepX, y1 - stepY, Convert.ToInt32(x1 + x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
//                    AbstractPainter.DrawLine(x1 - stepX, y1 - stepY, Convert.ToInt32(x1 - x), Convert.ToInt32(y1 - y), pictureBox, currentColor);
//                    AbstractPainter.DrawLine(x1 - stepX, y1 + stepY, Convert.ToInt32(x1 - x), Convert.ToInt32(y1 + y), pictureBox, currentColor);
//                    stepX = Convert.ToInt32(x);
//                    stepY = Convert.ToInt32(y);
//                }

//            }
//        }
//    }
//}
