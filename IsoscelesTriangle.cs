using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace risovalka
{
    public class IsoscelesTriangle : AbstractPainter
    {
        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            if (AbstractPainter.drawStartFinishFlag == true)
            {
                apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                DrawFigure(AbstractPainter.x1, AbstractPainter.y1, e.X, e.Y, pictureBox, Brush.currentColor);

                pictureBox.Image = apCanvas.currentBitmap;
            }
        }

        public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
        {
            AbstractPainter.DrawLine(x1, y1, x2, y2, pictureBox, currentColor);
            AbstractPainter.DrawLine(x1, y1, x1 - (x2 - x1), y2, pictureBox, currentColor);
            AbstractPainter.DrawLine(x1 - (x2 - x1), y2, x2, y2, pictureBox, currentColor);
        }
    }
}
