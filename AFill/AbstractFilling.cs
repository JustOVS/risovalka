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
        public Color fillingColor;
        public Bitmap newBitmap;
        public int counter = 0;
        public AbstractFilling(Color fillingColor, Bitmap newBitmap)
        {
            this.fillingColor = fillingColor;
            this.newBitmap = newBitmap;
        }
        public abstract void Fill(Point p1, PictureBox pictureBox, Bitmap newBitmap);

        
    }
}
