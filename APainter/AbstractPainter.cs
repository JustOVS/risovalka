using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using risovalka.FormFigure;
using risovalka.AFill;
using risovalka.ICan;

namespace risovalka.APainter
{
    
    public abstract class AbstractPainter 
    {
        public Brush brush;
        public IFormFigure formFigure;
        public Canvas apCanvas = Canvas.GetCanvas;
        public Point startPoint;
        public AbstractFilling typeOfFilling;
        public List<Point> points;
      

        public abstract void DrawDynamicFigure(Point p1, PictureBox pictureBox, bool shift);

        public abstract void MoveFigure(int dX, int dY);
    }
}
