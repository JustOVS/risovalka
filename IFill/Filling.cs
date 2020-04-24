using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using risovalka;


namespace risovalka.IFill
{
    public class Filling
    {
        
        public void Fill(Point p1, PictureBox pictureBox, Brush brush)
        {
            int x = p1.X;
            int y = p1.Y;
            int leftChecking = x;
            int rightChecking = x;

            Canvas fillCanvas = Canvas.GetCanvas;
            Color localColor = fillCanvas.currentBitmap.GetPixel(x, y);

            while (fillCanvas.currentBitmap.GetPixel(leftChecking - 1, y) == localColor && leftChecking - 1 > 0)
            {
                leftChecking--;
            }

            while (fillCanvas.currentBitmap.GetPixel(rightChecking + 1, y) == localColor && rightChecking + 1 < fillCanvas.currentBitmap.Width - 1)
            {
                rightChecking++;
            }

            brush.DrawLine(new Point(leftChecking, y), new Point(rightChecking, y), pictureBox, brush.currentColor);

            for (int i = leftChecking; i <= rightChecking; i++)
            {
                if (fillCanvas.currentBitmap.GetPixel(i, y - 1) == localColor && y - 1 > 0)
                {
                    Fill(new Point(i, y - 1), pictureBox, brush);
                }

                if (fillCanvas.currentBitmap.GetPixel(i, y + 1) == localColor && y + 1 < fillCanvas.currentBitmap.Height - 1)
                {
                    Fill(new Point(i, y + 1), pictureBox, brush);
                }
            }
        }
    }
}
