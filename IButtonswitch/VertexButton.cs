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
                int x=0;
                int y=0;
                foreach(Point f in currentPainter.points)
                {
                    if (f.X == currentPainter.startPoint.X)
                    {
                        if (((currentPainter.startPoint.Y < f.Y) && (currentPainter.startPoint.Y < tmpPoint.Y)) || ((currentPainter.startPoint.Y > f.Y) && (currentPainter.startPoint.Y > tmpPoint.Y)))
                        {
                            y = f.Y;
                        }
                    }
                    else if((f.Y == currentPainter.startPoint.Y))    
                    if (((currentPainter.startPoint.X < f.X) && (currentPainter.startPoint.X < tmpPoint.X)) || ((currentPainter.startPoint.X > f.X) && (currentPainter.startPoint.X > tmpPoint.X)))
                        {
                            x = f.X;
                        }
                    
                }
                x += p1.X - tmpPoint.X;
                y += p1.Y - tmpPoint.Y;
                pointForResize = new Point(x, y);
                currentPainter.points = currentPainter.formFigure.CalculateFigure(currentPainter.startPoint, pointForResize);
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
        }
    }
}
