using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using risovalka;

namespace risovalka.IButtonswitch
{
    public interface IButton
    {
        bool ButtonSwitch(Point p1, PictureBox pictureBox, ref Color currentColor);
    }
}
