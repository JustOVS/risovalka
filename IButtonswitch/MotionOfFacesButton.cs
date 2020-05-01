using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka.ICan;
using risovalka.APainter;
//using risovalka.FormFigure;
using System.Windows.Forms;

namespace risovalka.IButtonswitch
{
    class MotionOfFacesButton: IButton
    {
        Point tmpPoint;
        //Point tmpX;
        //Point tmpY;
        bool ChangingFlag = false;
        int tmpIndex;

        public override bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter currentPainter)
        {
            tmpPoint = p1;
            currentPainter = Canvas.GetCanvas.FindFigureByPoint1(tmpPoint);
            tmpIndex = Canvas.GetCanvas.FindPointByPoint(tmpPoint);
            ChangingFlag = true;
            return false;
        }


        public override void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter)
        {
            if (ChangingFlag && currentPainter != null)
            {
                Point p2 = currentPainter.points[tmpIndex + 1];

                //Point p1New = p1 + dx;
                //Point p2New = p2 + dy;
                p1.X = tmpPoint.X + p1.X;
                p1.Y  = tmpPoint.Y  + p1.Y ; 
                p2.X = tmpPoint.X + p2.X;
                p2.Y  = tmpPoint.Y  + p2.Y ;




                tmpPoint = p1;
                currentPainter.points[tmpIndex] = p1;

                Canvas.GetCanvas.DrawAllFigures(pictureBox);
            }
        }


        public override void DeactivateButton()
        {
            ChangingFlag = false;
        }
    }
}
