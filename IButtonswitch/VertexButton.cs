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
using risovalka.FormFigure;

namespace risovalka.IButtonswitch
{
    public class VertexButton : IButton
    {
        Point tmpPoint;
        int tmpIndex;
        bool ChangingFlag = false;
        Point pointForResize;
        bool ellipseFlag = true;
        int x=0;
        int y=0;
        public override bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter currentPainter)
        {
            currentPainter = Canvas.GetCanvas.FindFigureByPoint1(p1, ref tmpPoint);
            tmpIndex = Canvas.GetCanvas.FindPointByPoint(tmpPoint);
            ChangingFlag = true;
            return false;
        }

        public override void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter)
        {
            if (ChangingFlag && currentPainter != null && currentPainter.formFigure is EllipseForm)
            {
                
                
               

                if (tmpPoint.X == currentPainter.startPoint.X) //&& tmpPoint.Y != currentPainter.startPoint.Y)
                {
                    foreach (Point f in currentPainter.points)
                    {
                        if(f.Y == currentPainter.startPoint.Y && f.X != currentPainter.startPoint.X)
                        {
                            if (ellipseFlag)
                            {
                                x = f.X;
                                ellipseFlag = false;
                            }
                            y = p1.Y;
                            
                            break;
                        }
                    }
                }
                
                if (tmpPoint.Y == currentPainter.startPoint.Y) //&& tmpPoint.X != currentPainter.startPoint.X)
                {
                    foreach (Point f in currentPainter.points)
                    {
                        if (f.X == currentPainter.startPoint.X)
                        {
                            if (ellipseFlag)
                            {
                                y = f.Y;
                                ellipseFlag = false;
                            }
                            x = p1.X;

                            break;
                        }
                    }
                }

                //foreach(Point f in currentPainter.points)
                //{
                //    if (f.X == currentPainter.startPoint.X)
                //    {
                //        if (((currentPainter.startPoint.Y < f.Y) && (currentPainter.startPoint.Y < tmpPoint.Y)) || ((currentPainter.startPoint.Y > f.Y) && (currentPainter.startPoint.Y > tmpPoint.Y)))
                //        {
                //            y = f.Y;
                //        }
                //    }
                //    else if((f.Y == currentPainter.startPoint.Y))    
                //    if (((currentPainter.startPoint.X < f.X) && (currentPainter.startPoint.X < tmpPoint.X)) || ((currentPainter.startPoint.X > f.X) && (currentPainter.startPoint.X > tmpPoint.X)))
                //        {
                //            x = f.X;
                //        }

                //}
                //int dX = (int)(x / tmpPoint.X);
                //int dY = (int)(y / tmpPoint.Y);
                //x += (p1.X - tmpPoint.X) * dX;
                //y += p1.Y - tmpPoint.Y * dY;

                //if (y == currentPainter.startPoint.Y)
                //    y++;
                //if (new Point(x,y) != currentPainter.startPoint)
                pointForResize = new Point(x, y);
                
                currentPainter.points = currentPainter.formFigure.CalculateFigure(currentPainter.startPoint, pointForResize);
                Canvas.GetCanvas.DrawAllFigures(pictureBox);
                

            }
            else if(ChangingFlag && currentPainter != null && currentPainter.formFigure is CircleForm)
            {
                currentPainter.points = currentPainter.formFigure.CalculateFigure(currentPainter.startPoint, p1);
                Canvas.GetCanvas.DrawAllFigures(pictureBox);
            }
            else if (ChangingFlag && currentPainter != null)
            {
                currentPainter.points[tmpIndex] = p1;
                Canvas.GetCanvas.DrawAllFigures(pictureBox);
            }
        }
        public override void DeactivateButton()
        {
            ChangingFlag = false;
            ellipseFlag = true;
        }
    }
}
