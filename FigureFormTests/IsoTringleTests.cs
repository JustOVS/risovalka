﻿using NUnit.Framework;
using risovalka;
using risovalka.APainter;
using risovalka.FormFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FigureFormTests
{
    public class IsoTringleTests
    {
        readonly IFormFigure figure = new IsoTriangleForm();

        [TestCase(new int[] { 0, 0, 4, 4 }, ExpectedResult = new int[] { 0, 0, 4, 4, -4, 4, 0, 0 })]
        [TestCase(new int[] { 0, 0, -5, -5 }, ExpectedResult = new int[] { 0, 0, -5, -5, 5, -5, 0, 0 })]
        [TestCase(new int[] { 0, 0, 2, 3 }, ExpectedResult = new int[] { 0, 0, 2, 3, -2, 3, 0, 0 })]
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
