using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.AFill;
using System.Drawing;
using risovalka.ICan;
using risovalka.APainter;
namespace risovalka.IButtonswitch
{
    public class PipetteButton : IButton
    {
        public override bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter abstractPainter)
        {
            currentColor = Canvas.GetCanvas.currentBitmap.GetPixel(p1.X, p1.Y);
            return false;
        }

        public override void DeactivateButton()
        {
           
        }

        public override void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter)
        {
            
        }
    }
}
