using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace risovalka
{
    public interface IPainter
    {
        void DrawFigure(int x1, int y1, int x2, int y2, PictureBox pictureBox);
        void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox);
    }
}
