﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace risovalka.FormFigure
{
    public class SquareForm : IFormFigure   
    {
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int delta;
            //List<Point> pointList = new 
            if (Math.Abs(x2 - x1) > Math.Abs(y2 - y1))
            {
                delta = Math.Abs(y2 - y1);
            }
            else
            {
                delta = Math.Abs(x2 - x1);
            }
            int dx = x2 - x1 > 0 ? delta : -delta;
            int dy = y2 - y1 > 0 ? delta : -delta;
            return new List<Point> { new Point(x1, y1), new Point(x1 + dx, y1), new Point(x1 + dx, y1 + dy), new Point(x1, y1 + dy), new Point(x1, y1) };
        }
    }
}