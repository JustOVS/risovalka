using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace risovalka.AFill
{
    public abstract class AbstractFilling
    {
        public Canvas fillCanvas = Canvas.GetCanvas;
        public abstract void Fill(Point p1, PictureBox pictureBox, Color currentColor);

        public abstract void Fill(Point p1, PictureBox pictureBox, Color currentColor, ref Bitmap newBitmap);
    }
}
