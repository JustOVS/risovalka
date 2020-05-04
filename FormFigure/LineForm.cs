using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace risovalka.FormFigure
{
    public class LineForm : IFormFigure
    {
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
            return new List<Point> { p1, p2 };
        }
        public Point GetCenter(Point p1, Point p2)
        {
            return p1;
        }
        public Point GetCenter(List<Point> points)
        {
            int x = 0;
            int y = 0;

            foreach (Point p in points)
            {
                x += p.X;
                y += p.Y;
            }
            return new Point(x / points.Count, y / points.Count);
        }
        //public double[] GetArgumentsForLineFormule(Point p1, Point p2)
        //{
        //    double[] lineArguments = new double[2];
        //    double k, b;
            
        //    if ((p2.X - p1.X) != 0)
        //    {
        //        k = (p2.Y - p1.Y) / (p2.X - p1.X);
        //        b = ((p2.X * p1.Y) - (p2.Y * p1.X)) / (p2.X - p1.X);

        //    }
        //    else
        //    {
        //        k = (p2.X - p1.X) / (p2.Y - p1.Y);
        //        b = ((p2.Y * p1.X) - (p2.X * p1.Y)) / (p2.Y - p1.Y);

        //    }
        //    lineArguments[0] = k;
        //    lineArguments[1] = b;
        //    return lineArguments;
        //}
        //public Point GetLinePoints (Point p1, Point p2, Point p3)
        //{
        //    double[] lineArguments = GetArgumentsForLineFormule(p1, p2);
        //    if((p2.X - p1.X) != 0)
        //    {
        //        for( int i = p3.X - 10; i <= p3.X +10; i++)
        //        {
        //            for (int j = p3.Y - 10; j <= p3.Y + 10; j++)
        //            {
        //                if (j == (int)(lineArguments[0] * i) + (int)lineArguments[1])
        //                {
        //                    return new Point(i, j);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = p3.Y - 10; i <= p3.Y + 10; i++)
        //        {
        //            for (int j = p3.X - 10; j <= p3.X + 10; j++)
        //            {
        //                if (j == (int)(lineArguments[0] * i) + (int)lineArguments[1])
        //                {
        //                    return new Point(j, i);
        //                }
        //            }
        //        }
        //    }

        //    return new Point(-1, -1);

        //}
    }
}
