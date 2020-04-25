using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using risovalka.FormFigure;

namespace risovalka.APainter
{
    
    public abstract class AbstractPainter
    {
        public Brush brush;
        public IFormFigure formFigure;
        public Canvas apCanvas = Canvas.GetCanvas;
        public Point startPoint;
      

        public abstract void DrawDynamicFigure(Point p1, PictureBox pictureBox, bool shift);

        //public static int x1, y1;         //поля, которые присваиваются при mousedown и нужны для посмотрения фигур всех наследников.

        //public static AbstractPainter drawSwitch = new Line();  //поле для смены режима рисования (линия/фигуры), по умолчанию на старте стоит линия.

        //public static bool drawStartFinishFlag = false; // при mousedown = true, при mouseup = false, соответственно, методы наследников рисуют только при значении true.

        //public static bool shift = false;


        //public static void DrawLine(int x1, int y1, int x2, int y2, PictureBox pictureBox, Color currentColor)
        //{
        //    if (drawStartFinishFlag == true)
        //    {
        //        int lengthX = Math.Abs(x2 - x1);
        //        int lengthY = Math.Abs(y2 - y1);

        //        int length = Math.Max(lengthX, lengthY);


        //        if (length == 0)
        //        {

        //            //Canvas.DrawPixel(x1, y1, Color.Red);
        //            Brush.Pen(x1, y1, currentColor);
        //            pictureBox.Image = apCanvas.currentBitmap;
        //        }

        //        else
        //        {
        //            double dx = (double)(x2 - x1) / (double)length;
        //            double dy = (double)(y2 - y1) / (double)length;
        //            double x = x1;
        //            double y = y1;



        //            while (length + 1 != 0)
        //            {
        //                //Canvas.DrawPixel((int)x, (int)y, Color.Red);
        //                Brush.Pen((int)x, (int)y, currentColor);
        //                pictureBox.Image = apCanvas.currentBitmap;

        //                x += dx;
        //                y += dy;
        //                length--;
        //            }
        //        }

        //    }
        //}
    }
}
