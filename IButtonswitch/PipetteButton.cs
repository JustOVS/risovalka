using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.AFill;
using System.Drawing;
using risovalka.ICan;
namespace risovalka.IButtonswitch
{
    public class PipetteButton : IButton
    {
        public bool ButtonSwitch(Point p1, PictureBox pictureBox, ref Color currentColor)
        {
            currentColor = Canvas.GetCanvas.currentBitmap.GetPixel(p1.X, p1.Y);
            return false;
        }
    }
}
