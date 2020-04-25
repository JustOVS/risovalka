using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using risovalka;
using System.Drawing;
using risovalka.FormFigure;
using System.Windows.Forms;

namespace risovalka.APainter
{
    public class PointPolygonPainter : AbstractPainter
    {
        public static Point first = new Point(-1, -1);
        public static Point last;
        public PointPolygonPainter(Brush brush, IFormFigure formFigure, Point startPoint)
        {
            this.brush = brush;
            this.formFigure = formFigure;
            if (first.X == -1)
            {
                first = startPoint;
                last = startPoint;
            }
            else
            {
                
            }
        }
        public PointPolygonPainter(Color currentColor, int size)
        {
            brush = new Brush(currentColor, size);

        }

        public override void DrawDynamicFigure(Point p1, PictureBox pictureBox, bool shift)
        {
            if (Form1.drawStartFinishFlag == true)
            {

                apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                brush.DrawLine(last, p1, pictureBox, brush.currentColor);
                pictureBox.Image = apCanvas.currentBitmap;



            }
        }
        public void ConnectLastAndFirst(PictureBox pictureBox)
        {
            apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
            brush.DrawLine(last, first, pictureBox, brush.currentColor);
            first.X = -1;
            first.Y = -1;
        }
    }
}
