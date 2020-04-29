using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using risovalka;
using System.Drawing;
using risovalka.FormFigure;
using System.Windows.Forms;
using risovalka.AFill;

namespace risovalka.APainter
{
    public class FigurePainter : AbstractPainter
    {
        public FigurePainter(Brush brush, IFormFigure formFigure, Point startPoint, AbstractFilling typeOfFilling)
        {
            this.brush = brush;
            this.formFigure = formFigure;
            this.startPoint = startPoint;
            this.typeOfFilling = typeOfFilling;
        }
        
        public override void DrawDynamicFigure(Point p1, PictureBox pictureBox, bool shift)
        {
            apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                Bitmap newBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(apCanvas.currentBitmap);
            if (shift == false || formFigure is CircleForm || formFigure is SquareForm || formFigure is RecTriangleForm || formFigure is PolygonForm)
            {
                brush.DrawFigure(formFigure, newBitmap, startPoint, p1, pictureBox);
            }
            else if (formFigure is EllipseForm)
            {
                brush.DrawFigure(new CircleForm(), newBitmap, startPoint, p1, pictureBox);
            }
            else if (formFigure is IsoTriangleForm)
            {
                brush.DrawFigure(new RecTriangleForm(), newBitmap, startPoint, p1, pictureBox);
            }
            else
            {
                brush.DrawFigure(new SquareForm(), newBitmap, startPoint, p1, pictureBox);
            }
            typeOfFilling.Fill(formFigure.GetCenter(startPoint, p1), pictureBox, newBitmap);

            g.DrawImage(newBitmap, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            pictureBox.Image = apCanvas.currentBitmap;


        }
        public void DrawFigure(IFormFigure formFigure, Bitmap newBitmap, Point p1, PictureBox pictureBox)
        {
            List<Point> figurePoints = formFigure.CalculateFigure(startPoint, p1);
            if(formFigure is CircleForm || formFigure is EllipseForm)
            for (int i = 0; i < figurePoints.Count - 1; i++)
            {
                brush.DrawLine(figurePoints[i], figurePoints[i + 1], pictureBox, brush.currentColor, newBitmap);
            }
            else
            {
                if (formFigure is CircleForm || formFigure is EllipseForm)
                    for (int i = 0; i < figurePoints.Count; i++)
                    {
                        if (i != figurePoints.Count - 1)
                        {
                            brush.DrawLine(figurePoints[i], figurePoints[i + 1], pictureBox, brush.currentColor, newBitmap);
                        }
                        else
                        {
                            brush.DrawLine(figurePoints[i], figurePoints[0], pictureBox, brush.currentColor, newBitmap);
                        }
                    }
            }
        }
    }
}
