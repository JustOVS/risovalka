//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Drawing;

//namespace risovalka
//{
//    class PointPolygon : AbstractPainter
//    {
//        public static Point first = new Point (-1, -1);
//        public static Point last;
//        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
//        {
            
//            if (AbstractPainter.drawStartFinishFlag == true)
//            {
                
//                    apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
//                    AbstractPainter.DrawLine(last.X, last.Y, e.X, e.Y, pictureBox, Brush.currentColor);
//                    pictureBox.Image = apCanvas.currentBitmap;
                    

                
//            }
//        }
//    }
//}
