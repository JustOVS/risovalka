using NUnit.Framework;
using risovalka;
using risovalka.APainter;
using risovalka.FormFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace FigureFormTests
{
    [TestFixture (3)]
    [TestFixture (4)]
    [TestFixture (5)]
    public class PolygonTests
    {
        IFormFigure figure;
        int sides;
        int[] expectedResult;
        int expectedResultCounter = 1;
        
        public PolygonTests(int sides)
        {
            this.sides = sides;
        }

        [OneTimeSetUp]
        public void SetPolygonSides()
        {
            switch (sides)
            {
                case 3:
                    figure = new PolygonForm(sides);
                    break;
                case 4:
                    figure = new PolygonForm(sides);
                    break;
                case 5:
                    figure = new PolygonForm(sides);
                    break;
            }
        }

        [SetUp]
        public void SetExpectedResult()
        {
            switch (expectedResultCounter)
            {
                case 1:
                    if(sides == 3)
                        expectedResult = new int[] { 0, -6, -5, 3, 5, 3, 0, -6 };
                    else if(sides == 4)
                        expectedResult = new int[] { 0, -6, -6, 0, 0, 6, 6, 0, 0, -6 };
                    else if(sides == 5)
                        expectedResult = new int[] { 0, -6, -6, -2, -4, 5, 4, 5, 6, -2, 0, -6 };
                    break;
                case 2:
                    if(sides == 3)
                        expectedResult = new int[] { 1, -1, -1, 2, 3, 2, 1, -1 };
                    else if(sides == 4)
                        expectedResult = new int[] { 1, -1, -1, 1, 1, 3, 3, 1, 1, -1 };
                    else if(sides == 5)
                        expectedResult = new int[] { 1, -1, -1, 0, 0, 3, 2, 3, 3, 0, 1, -1 };
                    break;
            }
            expectedResultCounter++;
        } 

        [TestCase (new int[] { 0, 0, 4, 4})]
        [TestCase (new int[] { 1, 1, 2, 3})]
        public void CalculateFigureTest(int[] points)
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

            Assert.AreEqual(expectedResult, current);
        }
    }
}


