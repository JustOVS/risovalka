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
            
            currentPainter = Canvas.GetCanvas.FindFigureByPoint1(p1, ref tmpPoint);
            tmpIndex = Canvas.GetCanvas.FindPointByPoint(tmpPoint);
            ChangingFlag = true;
            return false;
        }


        public override void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter)
        {
            if (ChangingFlag && currentPainter != null)
            {

                Point p2; // = tmpIndex+1 != currentPainter.points.Count? currentPainter.points[tmpIndex + 1] : currentPainter.points[0];
                int p2Index;
                if(tmpIndex + 1 < currentPainter.points.Count)
                {
                    p2 = currentPainter.points[tmpIndex + 1];
                    p2Index = tmpIndex + 1;
                }
                else
                {
                    p2 = currentPainter.points[0];
                    p2Index = 0;
                }
                //Point p1New = p1 + dx;
                ////Point p2New = p2 + dy;
                //p1.X = tmpPoint.X + p1.X;
                //p1.Y  = tmpPoint.Y  + p1.Y ; 
                //p2.X = tmpPoint.X + p2.X;
                //p2.Y  = tmpPoint.Y  + p2.Y ;

                if( tmpPoint.X == p2.X)
                {
                    int dx = p1.X - tmpPoint.X;
                    currentPainter.points[tmpIndex] = new Point(tmpPoint.X+ dx, tmpPoint.Y);
                    currentPainter.points[p2Index] = new Point(p2.X + dx, p2.Y);
                }
                else if (tmpPoint.Y == p2.Y)
                {
                    int dy = p1.Y = tmpPoint.Y;
                    currentPainter.points[tmpIndex] = new Point(tmpPoint.X, tmpPoint.Y+dy);
                    currentPainter.points[p2Index] = new Point(p2.X, p2.Y+dy);
                }




                //tmpPoint = p1;
                //currentPainter.points[tmpIndex] = p1;

                Canvas.GetCanvas.DrawAllFigures(pictureBox);
            }
        }


        public override void DeactivateButton()
        {
            ChangingFlag = false;
        }
    }
}
