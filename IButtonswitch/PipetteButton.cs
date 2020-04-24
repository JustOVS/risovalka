using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.IFill;
using System.Drawing;

namespace risovalka.IButtonswitch
{
    public class PipetteButton : IButton
    {
        public bool ButtonSwitch(Point p1, PictureBox pictureBox, ref Color currentColor, int currentSize)
        {
            currentColor = Canvas.GetCanvas.currentBitmap.GetPixel(p1.X, p1.Y);
            return false;
        }
    }
}
