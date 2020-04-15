using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace risovalka
{
    public class Squaire : IPainter
    {
        
        public void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            if (Brush.drawStartFinishFlag == true)
            {
                Canvas.currentBitmap = new Bitmap(Canvas.tmpBitmap);
                DrawFigure(Brush.x1, Brush.y1, e.X, e.Y, pictureBox);

                pictureBox.Image = Canvas.currentBitmap;
                //pictureBox.Image = Canvas.currentBitmap;
                //if (Brush.drawStartFinishFlag == true)
                //{
                //    Canvas.currentBitmap = Canvas.tmpBitmap;
                //    pictureBox.Image = Canvas.currentBitmap;
                //}
            }
        }

        public void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox)
        {
            Brush.DrawLine(x1, y1, x1, y2, pictureBox);
            Brush.DrawLine(x1, y1, x2, y1, pictureBox);
            Brush.DrawLine(x1, y2, x2, y2, pictureBox);
            Brush.DrawLine(x2, y1, x2, y2, pictureBox);

        }

        public void CalculateTops(int x1, int y1, int x2, int y2)
        {

        }
    }
}
