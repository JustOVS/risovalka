using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace risovalka
{
    public class Eraser : AbstractPainter
    {

        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            AbstractPainter.DrawLine(x1, y1, e.X, e.Y, pictureBox, pictureBox.BackColor );
            x1 = e.X;
            y1 = e.Y;
        }
    }
}
