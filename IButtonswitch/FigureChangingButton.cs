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
    public class FigureChangingButton : IButton
    {
        Point tmpPoint;
        bool ChangingFlag = false;
        public override bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter currentPainter)
        {
            currentPainter = Canvas.GetCanvas.FindFigureByPoint1(p1);
            tmpPoint = p1;
            ChangingFlag = true;
            return false;
        }

        public override void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter)
        {
            if (ChangingFlag && currentPainter != null)
            {
                currentPainter.MoveFigure(p1.X - tmpPoint.X, p1.Y - tmpPoint.Y);
                tmpPoint = p1;
                Canvas.GetCanvas.DrawAllFigures(pictureBox);
            }
        }
        public override void DeactivateButton()
        {
            ChangingFlag = false;
        }
    }
}