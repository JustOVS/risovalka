using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace risovalka
{
    public class RectangleTriangle : AbstractPainter
    {
        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            if (AbstractPainter.drawStartFinishFlag == true)
            {
                Canvas.currentBitmap = new Bitmap(Canvas.tmpBitmap);
                DrawFigure(AbstractPainter.x1, AbstractPainter.y1, e.X, e.Y, pictureBox);

                pictureBox.Image = Canvas.currentBitmap;
            }
        }

        public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox)
        {
            AbstractPainter.DrawLine(x1, y1, x2, y2, pictureBox);
            AbstractPainter.DrawLine(x1, y1, x1, y2, pictureBox);
            AbstractPainter.DrawLine(x1, y2, x2, y2, pictureBox);
        }
    }
}
