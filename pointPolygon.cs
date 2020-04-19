using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace risovalka
{
    class PointPolygon : AbstractPainter
    {
        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            if (AbstractPainter.drawStartFinishFlag == true)
            {

                Canvas.currentBitmap = new Bitmap(Canvas.tmpBitmap);
                AbstractPainter.DrawLine(x1, y1, e.X, e.Y, pictureBox, Brush.currentColor);

                pictureBox.Image = Canvas.currentBitmap;

            }
        }
    }
}
