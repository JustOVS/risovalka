﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka;

namespace risovalka.FormFigure
{
    public class IsoTriangleForm : IFormFigure
    {
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;

            return new List<Point> { new Point(x1, y1), new Point(x2, y2), new Point(2 * x1 - x2, y2)};
        }
        public Point GetCenter(Point p1, Point p2)
        {
            int x = 0;
            int y = 0;
            List<Point> tmpList = CalculateFigure(p1, p2);
            foreach (Point p in tmpList)
            {
                x += p.X;
                y += p.Y;
            }
            Point center = new Point(x / tmpList.Count, y / tmpList.Count);
            return center; //new Point((p1.X ), ((p1.Y + 2 *p2.Y) / 3));
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
            return  new Point(x / points.Count, y / points.Count);
        }


    }
}
