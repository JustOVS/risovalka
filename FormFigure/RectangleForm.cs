using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using risovalka;

namespace risovalka.FormFigure
{
    public class RectangleForm : IFormFigure
    {
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
                int x1 = p1.X;
                int y1 = p1.Y;
                int x2 = p2.X;
                int y2 = p2.Y;
                
                return new List<Point> { new Point(x1, y1), new Point(x2, y1), new Point(x2, y2), new Point(x1, y2), new Point(x1, y1) };
            
        }
        public Point GetCenter(Point p1, Point p2)
        {
            return new Point(((p1.X + p2.X) / 2), ((p1.Y + p2.Y) / 2));
        }
    }
}
