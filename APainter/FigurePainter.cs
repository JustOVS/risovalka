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
            //List<Point> figurePoints = formFigure.CalculateFigure(startPoint, p1);
            //apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
            //Bitmap newBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            //Graphics g = Graphics.FromImage(apCanvas.currentBitmap);

            //for (int i = 0; i < figurePoints.Count - 1; i++)
            //{
            //    brush.DrawLine(figurePoints[i], figurePoints[i + 1], pictureBox, brush.currentColor, newBitmap);
            //}

            //typeOfFilling.Fill(formFigure.GetCenter(startPoint, p1), pictureBox, newBitmap);

            //g.DrawImage(newBitmap, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);

            //pictureBox.Image = apCanvas.currentBitmap;

            if (shift == false || formFigure is CircleForm || formFigure is SquareForm || formFigure is RecTriangleForm || formFigure is PolygonForm)
            {
                List<Point> figurePoints = formFigure.CalculateFigure(startPoint, p1);
                apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                Bitmap newBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(apCanvas.currentBitmap);

                for (int i = 0; i < figurePoints.Count - 1; i++)
                {
                    brush.DrawLine(figurePoints[i], figurePoints[i + 1], pictureBox, brush.currentColor, newBitmap);
                }
                
                typeOfFilling.Fill(formFigure.GetCenter(startPoint, p1), pictureBox, newBitmap);
                
                g.DrawImage(newBitmap, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
                pictureBox.Image = apCanvas.currentBitmap;

            }
            else if (formFigure is EllipseForm)
            {
                List<Point> figurePoints = new CircleForm().CalculateFigure(startPoint, p1);
                apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                Bitmap newBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(apCanvas.currentBitmap);
                for (int i = 0; i < figurePoints.Count - 1; i++)
                {
                    brush.DrawLine(figurePoints[i], figurePoints[i + 1], pictureBox, brush.currentColor, newBitmap);
                }
                typeOfFilling.Fill(new CircleForm().GetCenter(startPoint, p1), pictureBox, newBitmap);

                g.DrawImage(newBitmap, 0, 0, pictureBox.Width, pictureBox.Height);
                pictureBox.Image = apCanvas.currentBitmap;
            }
            else if (formFigure is IsoTriangleForm)
            {
                List<Point> figurePoints = new RecTriangleForm().CalculateFigure(startPoint, p1);
                apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                Bitmap newBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(apCanvas.currentBitmap);
                for (int i = 0; i < figurePoints.Count - 1; i++)
                {
                    brush.DrawLine(figurePoints[i], figurePoints[i + 1], pictureBox, brush.currentColor, newBitmap);
                }
                typeOfFilling.Fill(new RecTriangleForm().GetCenter(startPoint, p1), pictureBox, newBitmap);

                g.DrawImage(newBitmap, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
                pictureBox.Image = apCanvas.currentBitmap;
            }
            else
            {
                List<Point> figurePoints = new SquareForm().CalculateFigure(startPoint, p1);
                apCanvas.currentBitmap = new Bitmap(apCanvas.tmpBitmap);
                Bitmap newBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(apCanvas.currentBitmap);
                for (int i = 0; i < figurePoints.Count - 1; i++)
                {
                    brush.DrawLine(figurePoints[i], figurePoints[i + 1], pictureBox, brush.currentColor, newBitmap);
                }
                typeOfFilling.Fill(new RecTriangleForm().GetCenter(startPoint, p1), pictureBox, newBitmap);

                g.DrawImage(newBitmap, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
                pictureBox.Image = apCanvas.currentBitmap;
            
            }  
        }
    }
}
