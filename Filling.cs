using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace risovalka
{
    class FullFilling
    {
        
        public void Filling(int x, int y, PictureBox pictureBox)
        {
            int leftChecking = x;
            int rightChecking = x;
            Color localColor = Canvas.currentBitmap.GetPixel(x, y);

            while (Canvas.currentBitmap.GetPixel(leftChecking - 1, y) == localColor && leftChecking - 1 > 0)
            {
                leftChecking--;
            }

            while (Canvas.currentBitmap.GetPixel(rightChecking + 1, y) == localColor && rightChecking + 1 < Canvas.currentBitmap.Width - 1)
            {
                rightChecking++;
            }

            AbstractPainter.DrawLine(leftChecking, y, rightChecking, y, pictureBox, Brush.currentColor);

            for (int i = leftChecking; i <= rightChecking; i++)
            {
                if (Canvas.currentBitmap.GetPixel(i, y - 1) == localColor && y - 1 > 0)
                {
                    Filling(i, y - 1, pictureBox);
                }

                if (Canvas.currentBitmap.GetPixel(i, y + 1) == localColor && y + 1 < Canvas.currentBitmap.Height - 1)
                {
                    Filling(i, y + 1, pictureBox);
                }
            }
        }
    }
}
