using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka;
using risovalka.APainter;
using risovalka.FormFigure;

namespace risovalka.AbstractPainterFactory
{
    public class ErasePainterFactory : APainterFactory
    {
        public override AbstractPainter CreatePainter(IFormFigure currentFigure, Color currentColor, int currentSize, Point startPoint)
        {
            Brush brush = new Brush(currentColor, currentSize);
            abstractPainter = new ErasePainter(brush, currentFigure, startPoint);
            return abstractPainter;
        }
    }
}
