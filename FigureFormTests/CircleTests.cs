﻿using NUnit.Framework;
using risovalka;
using risovalka.APainter;
using risovalka.FormFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FigureFormTests
{
    public class CircleTests
    {
        readonly IFormFigure figure = new CircleForm();

        [TestCase(new int[] { 0, 0, 4, 4 }, ExpectedResult = new int[] { 0, 6, 0, 6, 1, 
            6, 2, 6, 3, 5, 4, 4, 
            5, 3, 6, 0, 6, 0, 5, -3, 4, -4, 3, -5, 2, -6, 1, -6, 0, -6, 0, -6, 0, -6, 0,
            -6, -1, -6, -2, -6, -3, -5, -4, -4, -5, -3, -6, 0, -6, 0, -5, 3, -4, 4, -3, 5,
            -2, 6, -1, 6, 0, 6, 0, 6 })]
        public int[] CalculateFigureTest(int[] points)
        {
            Point p1 = new Point(points[0], points[1]),
                p2 = new Point(points[2], points[3]);

            List<Point> currentList = figure.CalculateFigure(p1, p2);
            int[] current = new int[currentList.Count * 2];
            int curCounter = 0;

            for (int i = 0; i < currentList.Count; i++)
            {
                current[curCounter] = currentList[i].X;
                curCounter++;
                current[curCounter] = currentList[i].Y;
                curCounter++;
            }

            return current;
        }
    }
}

