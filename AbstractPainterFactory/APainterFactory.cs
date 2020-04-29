using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka;
using risovalka.APainter;
using risovalka.FormFigure;
using risovalka.AFill;

namespace risovalka.AbstractPainterFactory
{
    public abstract class APainterFactory
    {
        public AbstractPainter abstractPainter;
        abstract public AbstractPainter CreatePainter(IFormFigure currentFigure, Color currentColor, int currentSize, Point startPoint, AbstractFilling typeOfFilling);
    }
}
