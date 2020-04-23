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
        public PointPolygonPainter(Brush brush, IFormFigure formFigure, Point startPoint)
        {
            this.brush = brush;
            this.formFigure = formFigure;
            this.startPoint = startPoint;
        }

        public override void DrawDynamicFigure(Point p1, PictureBox pictureBox)
        {
            if (Form1.drawStartFinishFlag == true)
            {

                //apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                //AbstractPainter.DrawLine(last.X, last.Y, e.X, e.Y, pictureBox, Brush.currentColor);
                //pictureBox.Image = apCanvas.currentBitmap;



            }
        }
    }
}
