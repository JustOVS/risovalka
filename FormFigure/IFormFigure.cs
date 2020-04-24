using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using risovalka;

namespace risovalka.FormFigure
{
    public interface IFormFigure
    {
        List <Point> CalculateFigure(Point p1, Point p2);
    }
}
