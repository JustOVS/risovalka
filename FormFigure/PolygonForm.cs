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
            

            while (i < nSides)
            {
                list1.Add(new Point(x1 + (int)(Math.Round(Math.Cos(angle / 180 * Math.PI) * radius)), y1 - (int)(Math.Round(Math.Sin(angle / 180 * Math.PI) * radius))));
                angle += 360 / nSides;
                i++;
            }
            return list1;

        }
        public Point GetCenter(Point p1, Point p2)
        {
            return p1;
        }
    }
}
