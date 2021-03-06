﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka;

namespace risovalka.FormFigure
{
    public class RecTriangleForm : IFormFigure
    {
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
            int x1 = p1.X; // 0
            int y1 = p1.Y; // 0
            int x2 = p2.X; // 4
            int y2 = p2.Y; // 4  // 1. 0, 0; 2. 4, 4; 3. 0, 4; 4. 0, 0 

            return new List<Point> { new Point(x1, y1), new Point(x2, y2), new Point(x1, y2) };
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
            return center;
            //return new Point(((2* p1.X + p2.X) / 3), ((p1.Y + 2* p2.Y) / 3));
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
    }
}
