//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//using System.Windows.Forms;

//namespace risovalka
//{
//    public class Square : AbstractPainter
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
//            int delta; //= Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
//            if (Math.Abs(x2-x1) > Math.Abs(y2-y1))
//            {
//                delta = Math.Abs(y2 - y1);
//            }
//            else
//            {
//                delta = Math.Abs(x2 - x1);
//            }
//            int dx = x2-x1>0 ? delta : -delta;
//            int dy = y2 - y1 > 0 ? delta : -delta;
//            AbstractPainter.DrawLine(x1, y1, x1+dx, y1, pictureBox, currentColor);
//            AbstractPainter.DrawLine(x1, y1, x1, y1+dy, pictureBox, currentColor);
//            AbstractPainter.DrawLine(x1+dx, y1, x1+dx, y1+dy, pictureBox, currentColor);
//            AbstractPainter.DrawLine(x1, y1+dy, x1 + dx, y1 + dy, pictureBox, currentColor);

//        }

//        public void CalculateTops(int x1, int y1, int x2, int y2)
//        {

//        }
//    }
//}
