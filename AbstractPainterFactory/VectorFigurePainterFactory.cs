using risovalka.AFill;
using risovalka.APainter;
using risovalka.FormFigure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using risovalka.ICan;

namespace risovalka.AbstractPainterFactory
{
    public class VectorFigurePainterFactory : APainterFactory
    {
        public override AbstractPainter CreatePainter(IFormFigure currentFigure, Color currentColor, int currentSize, Point startPoint, AbstractFilling typeOfFilling)
        {
            Brush brush = new Brush(currentColor, currentSize);
            abstractPainter = new VectorFigurePainter(brush, currentFigure, startPoint, typeOfFilling);
            Canvas.GetCanvas.figures.Insert(0, abstractPainter);

            return abstractPainter;
        }
    }
}
