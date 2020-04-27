using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.AFill;

namespace risovalka.IButtonswitch
{
    public class FillButton : IButton
    {
        public bool ButtonSwitch(Point p1, PictureBox pictureBox, Color currentColor)
        {
            AbstractFilling filler = new TotalFilling(currentColor, Canvas.GetCanvas.currentBitmap);
                
            filler.Fill(p1, pictureBox);
            return false;
        }
    }
}
