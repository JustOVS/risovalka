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
    }
}
