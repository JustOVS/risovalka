using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.AFill;
using risovalka.FormFigure;
namespace risovalka.APainter
{
    public class VectorFigurePainter : AbstractPainter
    {
        
        public VectorFigurePainter(Brush brush, IFormFigure formFigure, Point startPoint, AbstractFilling typeOfFilling)
        {
            this.brush = brush;
            this.formFigure = formFigure;
            this.startPoint = startPoint;
            this.typeOfFilling = typeOfFilling;
            points = formFigure.CalculateFigure(startPoint, startPoint);
        }
        public override void DrawDynamicFigure(Point p1, PictureBox pictureBox, bool shift)
        {
            this.points = formFigure.CalculateFigure(startPoint, p1);
            apCanvas.DrawAllFigures(pictureBox);
        }
        public override void MoveFigure(int dX, int dY)
        {
            
                for (int i = 0; i < points.Count; i++)
                {
                    points[i] = new Point(points[i].X + dX, points[i].Y + dY);
                }
            
        }
    }
}
