using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risovalka
{
    public class Squaire : IPainter
    {
        
        public void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            Canvas.tmpBitmap = Canvas.currentBitmap;
            DrawFigue(Brush.x1, Brush.y1, e.X, e.Y, pictureBox);
            
            if (Brush.drawStartFinishFlag == true)
            {
                Canvas.currentBitmap = Canvas.tmpBitmap;
                pictureBox.Image = Canvas.currentBitmap;
            }
        }

        public void DrawFigue(int x1, int y1, int x2, int y2, PictureBox pictureBox)
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
