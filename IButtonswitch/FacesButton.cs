using risovalka.APainter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.AFill;
using risovalka.ICan;

using risovalka.FormFigure;

namespace risovalka.IButtonswitch
{
    public class FacesButton : IButton
    {
        Point tmpPoint = new Point (-1, -1);
       
        bool ChangingFlag = false;
        //AbstractPainter tmpPainter;


        public override bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter abstractPainter)
        {
            foreach (AbstractPainter f in Canvas.GetCanvas.figures)
            {
                for (int i = 0; i < f.points.Count; i++)
                {
                    if(i != f.points.Count-1)
                    {
                        tmpPoint = GetLinePoints(f.points[i], f.points[i + 1], p1);
                        if(tmpPoint.X != -1)
                        {
                            //tmpPainter = f;
                            f.points.Insert(i + 1, tmpPoint);
                            //tmpIndex = i;
                            break;
                        }

                    }
                    else
                    {
                        tmpPoint = GetLinePoints(f.points[i], f.points[0], p1);
                        if (tmpPoint.X != -1)
                        {
                            //tmpPainter = f;
                            f.points.Insert(i + 1, tmpPoint);
                            //tmpIndex = i;
                            break;
                        }
                    }
                    
                }
                if (tmpPoint.X != -1)
                {
                    break;
                }
            }
            Canvas.GetCanvas.DrawAllFigures(pictureBox);
            return false;
        }

        public override void DeactivateButton()
        {
            tmpPoint = new Point(-1, -1);
        }

        public override void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter)
        {
            
        }
        public double[] GetArgumentsForLineFormule(Point p1, Point p2)
        {
            double[] lineArguments = new double[2];
            double k, b;

            if ((p2.X - p1.X) != 0)
            {
                k = (p2.Y - p1.Y) / (p2.X - p1.X);
                b = ((p2.X * p1.Y) - (p2.Y * p1.X)) / (p2.X - p1.X);

            }
            else
            {
                k = (p2.X - p1.X) / (p2.Y - p1.Y);
                b = ((p2.Y * p1.X) - (p2.X * p1.Y)) / (p2.Y - p1.Y);

            }
            lineArguments[0] = k;
            lineArguments[1] = b;
            return lineArguments;
        }
        public Point GetLinePoints(Point p1, Point p2, Point p3)
        {
            double[] lineArguments = GetArgumentsForLineFormule(p1, p2);
            if ((p2.X - p1.X) != 0)
            {
                for (int i = p3.X - 10; i <= p3.X + 10; i++)
                {
                    for (int j = p3.Y - 10; j <= p3.Y + 10; j++)
                    {
                        if (j == (int)(lineArguments[0] * i) + (int)lineArguments[1])
                        {
                            return new Point(i, j);
                        }
                    }
                }
            }
            else
            {
                for (int i = p3.Y - 10; i <= p3.Y + 10; i++)
                {
                    for (int j = p3.X - 10; j <= p3.X + 10; j++)
                    {
                        if (j == (int)(lineArguments[0] * i) + (int)lineArguments[1])
                        {
                            return new Point(j, i);
                        }
                    }
                }
            }

            return new Point(-1, -1);

        }
    }
}
