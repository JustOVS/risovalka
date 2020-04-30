using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.AFill;
using risovalka.ICan;
using risovalka.APainter;

namespace risovalka.IButtonswitch
{
    public class FillButton : IButton
    {
        public override bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter currentPainter)
        {
            AbstractFilling filler = new TotalFilling(currentColor);
                
            filler.Fill(p1, pictureBox, Canvas.GetCanvas.currentBitmap);
            
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
