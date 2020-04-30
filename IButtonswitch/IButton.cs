using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using risovalka;
using risovalka.ICan;
using risovalka.APainter;

namespace risovalka.IButtonswitch
{
    public abstract class IButton
    {
        bool ChangingFlag;
        public abstract bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter abstractPainter);
        public abstract void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter);
        public abstract void DeactivateButton();
    }
}
