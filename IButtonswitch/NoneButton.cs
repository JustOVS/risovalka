using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.AFill;
using System.Drawing;

namespace risovalka.IButtonswitch
{
    public class NoneButton : IButton
    {
        public bool ButtonSwitch(Point p1, PictureBox pictureBox, Color currentColor)
        {
            return true;
        }
    }
}
