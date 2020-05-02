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
                if (tmpIndex + 1 < currentPainter.points.Count)
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

                
                
                //if (k>0)
                //{
                //    int d= Math.Abs(b-)
                //}

                if ( tmpPoint.X == p2.X)
                {
                    int dx =  tmpPoint.X-p1.X;
                    currentPainter.points[tmpIndex] = new Point(p1.X+ dx, p1.Y);
                    currentPainter.points[p2Index] = new Point(p2.X + dx, p2.Y);
                }
                else if (tmpPoint.Y == p2.Y)
                {
                    int dy = tmpPoint.Y-p1.Y ;
                    currentPainter.points[tmpIndex] = new Point(p1.X, p1.Y+dy);
                    currentPainter.points[p2Index] = new Point(p2.X, p2.Y+dy);
                }

                else if ((tmpPoint.Y != p2.Y) && (tmpPoint.X != p2.X))
                {
                    //double k = (p2.Y - tmpPoint.Y) / (tmpPoint.X - p2.X);
                   // double b = -(p2.X * tmpPoint.Y - tmpPoint.X * p2.Y) / (tmpPoint.X - p2.X);

                    // int d = Convert.ToInt32(b-(-((p2.X * p1.Y - p1.X * p2.Y) / (p1.X - p2.X))) );

                   // int d = Convert.ToInt32( b - p1.X);
                    currentPainter.points[tmpIndex] = new Point(tmpPoint.X, p1.Y);
                    currentPainter.points[p2Index] = new Point(tmpPoint.X, p2.Y);


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
