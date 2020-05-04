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
        List<double> tmpPointList = new List<double>();

        public override bool ActivateButton(Point p1, PictureBox pictureBox, ref Color currentColor, ref AbstractPainter currentPainter)
        {
            currentPainter = Canvas.GetCanvas.FindFigureByPoint1(p1);
            if (currentPainter != null)
            {
                currentPainter.brush.currentColor = currentColor;
            }
            tmpPoint = p1;
            ChangingFlag = true;
            return false;
        }

        public override void Move(Point p1, PictureBox pictureBox, AbstractPainter currentPainter)
        {
            if (ChangingFlag && currentPainter != null)
            {
                if (Control.ModifierKeys != Keys.Shift && Control.MouseButtons == MouseButtons.Left)
                {
                    currentPainter.MoveFigure(p1.X - tmpPoint.X, p1.Y - tmpPoint.Y);
                }
                else if (Control.ModifierKeys == Keys.Shift)
                {
                    int dY = (int)((p1.Y - tmpPoint.Y) * 1.5);
                    RotateFigure(dY, currentPainter);
                }
                else if (Control.MouseButtons == MouseButtons.Right)
                {
                    int dX = p1.X - tmpPoint.X;
                    int dY = p1.Y - tmpPoint.Y;
                    ScaleFigure(dX, dY, currentPainter);
                }

                tmpPoint = p1;
                Canvas.GetCanvas.DrawAllFigures(pictureBox);
            }
        }

        public void RotateFigure(int angle, AbstractPainter currentPainter)
        {
            Point center = currentPainter.formFigure.GetCenter(currentPainter.points);
            double angleRad = angle * Math.PI / 180;
            
            if (tmpPointList.Count == 0)
            {
                for (int i = 0; i < currentPainter.points.Count; i++)
                {
                    tmpPointList.Add(((currentPainter.points[i].X - center.X) * Math.Cos(angleRad) -
                        (currentPainter.points[i].Y - center.Y) * Math.Sin(angleRad) + center.X));
                    tmpPointList.Add(((currentPainter.points[i].X - center.X) * Math.Sin(angleRad) +
                        (currentPainter.points[i].Y - center.Y) * Math.Cos(angleRad) + center.Y));
                    //currentPainter.points[i] = new Point((int)x, (int)y);
                }
            }
            else
            {
                for (int i = 0; i < tmpPointList.Count - 1; i += 2)
                {
                    double tmpX = tmpPointList[i];

                    tmpPointList[i] = ((tmpPointList[i] - center.X) * Math.Cos(angleRad) -
                        (tmpPointList[i + 1] - center.Y) * Math.Sin(angleRad) + center.X);

                    tmpPointList[i + 1] = ((tmpX - center.X) * Math.Sin(angleRad) +
                        (tmpPointList[i + 1] - center.Y) * Math.Cos(angleRad) + center.Y);
                }
            }

            currentPainter.points.Clear();

            for (int i = 0; i < tmpPointList.Count - 1; i += 2)
            {
                currentPainter.points.Add(new Point((int)(tmpPointList[i]), (int)(tmpPointList[i + 1])));
            }
        }

        private void ScaleFigure(int dX, int dY, AbstractPainter currentPainter)
        {
            for (int i = 0; i < currentPainter.points.Count; i++)
            {
                if(Math.Abs(tmpPoint.X - currentPainter.points[i].X) <= 10)
                {
                    currentPainter.points[i] = new Point(currentPainter.points[i].X 
                        + dX, currentPainter.points[i].Y);
                    if(currentPainter.formFigure is FormFigure.IsoTriangleForm)
                    {
                        currentPainter.points[0] = new Point((currentPainter.points[1].X
                        + currentPainter.points[2].X) / 2, currentPainter.points[0].Y);
                    }
                }

                if(Math.Abs(tmpPoint.Y - currentPainter.points[i].Y) <= 10)
                {
                    currentPainter.points[i] = new Point(currentPainter.points[i].X, 
                        currentPainter.points[i].Y + dY);
                }
            }
        }

        public override void DeactivateButton()
        {
            ChangingFlag = false;
        }
    }
}