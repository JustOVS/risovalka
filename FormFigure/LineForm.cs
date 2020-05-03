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
    }
}
