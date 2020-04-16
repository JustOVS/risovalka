using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace risovalka
{
    public class Rectangle : AbstractPainter
    {
        
        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            if (AbstractPainter.drawStartFinishFlag == true)
            {
                Canvas.currentBitmap = new Bitmap(Canvas.tmpBitmap);
                DrawFigure(AbstractPainter.x1, AbstractPainter.y1, e.X, e.Y, pictureBox, Brush.currentColor);

                pictureBox.Image = Canvas.currentBitmap;
                //pictureBox.Image = Canvas.currentBitmap;
                //if (Brush.drawStartFinishFlag == true)
                //{
                //    Canvas.currentBitmap = Canvas.tmpBitmap;
                //    pictureBox.Image = Canvas.currentBitmap;
                //}
            }
        }

        public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
        {
            AbstractPainter.DrawLine(x1, y1, x1, y2, pictureBox, currentColor);
            AbstractPainter.DrawLine(x1, y1, x2, y1, pictureBox, currentColor);
            AbstractPainter.DrawLine(x1, y2, x2, y2, pictureBox, currentColor);
            AbstractPainter.DrawLine(x2, y1, x2, y2, pictureBox, currentColor);

        }

        public void CalculateTops(int x1, int y1, int x2, int y2)
        {

        }
    }
}
