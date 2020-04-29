using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka;

namespace risovalka.FormFigure
{
    public class PolygonForm : IFormFigure
    {
        public static int nSides;
        
       
        // int[] points = new int[2 * nSides];

        //public Polygon()
        //{

        //}

        public PolygonForm(int n)
        {
            nSides = n;
            //points = new int[2 * nSides];
        }
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
            List<Point> list1 = new List<Point>();
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            double angle = 90; 
            int i = 0;
            
            int radius = (int)(Math.Round(Math.Sqrt(Math.Pow(((double)x2 - (double)x1), 2) + Math.Pow(((double)y2 - (double)y1), 2))));
            
            Point lastPoint = new Point(x1 + (int)(Math.Round(Math.Cos(angle / 180 * Math.PI) * radius)), y1 - (int)(Math.Round(Math.Sin(angle / 180 * Math.PI) * radius)));
            //int j = 0;
            while (i < nSides)
            {
                list1.Add(new Point(x1 + (int)(Math.Round(Math.Cos(angle / 180 * Math.PI) * radius)), y1 - (int)(Math.Round(Math.Sin(angle / 180 * Math.PI) * radius))));
                //points[j] = x1 + (int)(Math.Round(Math.Cos(angle / 180 * Math.PI) * radius));
                //j++;
                //points[j] = y1 - (int)(Math.Round(Math.Sin(angle / 180 * Math.PI) * radius));
                //j++;
                angle += 360 / nSides;
                i++;
            }
            list1.Add(lastPoint);
            return list1;

            
            //for (int k = 0; k < points.Length - 1; k += 2)
            //{
            //    if (k == points.Length - 2)
            //    {
            //        AbstractPainter.DrawLine(points[k], points[k + 1], points[0], points[1], pictureBox, currentColor);
            //    }
            //    else
            //    {
            //        AbstractPainter.DrawLine(points[k], points[k + 1], points[k + 2], points[k + 3], pictureBox, currentColor);
            //    }
            //}
        }
        public Point GetCenter(Point p1, Point p2)
        {
            return p1;
        }
    }
}
