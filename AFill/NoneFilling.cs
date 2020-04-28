using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace risovalka.AFill
{
    public class NoneFilling : AbstractFilling
    {
        public NoneFilling(Color fillingColor, Bitmap newBitmap) : base(fillingColor, newBitmap)
        {

        }

        public override void Fill(Point p1, PictureBox pictureBox, Bitmap newBitmap)
        {

        }



    }
}
