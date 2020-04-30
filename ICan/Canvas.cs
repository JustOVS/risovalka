using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using risovalka.List;
using risovalka.APainter;

namespace risovalka.ICan
{
    public class Canvas
    {
        private static Canvas obj;
        public List<Bitmap> archive;
        public Bitmap currentBitmap;
        public Bitmap tmpBitmap;
        public L2List tmpList = new L2List();    //сохраняем сюда все currentBmp после каждого действия, чтобы была возможность использовать Undo/Redo
        public List<AbstractPainter> figures = new List<AbstractPainter>();
        public int undoCounter = 0;              //показывает индекс элемента, следующего за последним активным. Основное применение при undo/redo
                                                        // undoCounter увеличивается при добавлении элемента в tmpList, уменьшается при использовании undo, увеличивается
                                                        //при использовании redo, т.е. если мы сделали undo 3 раза, а потом undo 1 раз, а потом сделали новое действие, то,
                                                        // благодаря undocounter и методу L2list.InsertAndCut мы удаляем из списка 2 элемента, на которые сделали undo.

        private Canvas()
        {
        }
        
        public static Canvas GetCanvas
        {
            get
            {
                if (obj == null)
                {
                    obj = new Canvas();
                }
                return obj;
            }
        }
        public void DrawPixel(int x, int y, Color color) // обертка для Bitmap.SetPixel, используем вместо этого Canvas.DrawPixel.
        {
            if (x < currentBitmap.Width - 1 && x > 0 && y < currentBitmap.Height - 1 && y > 0)
            {
                 currentBitmap.SetPixel(x, y, color);
            }
            else
            {

            }
           
        }

        public void DrawPixel(int x, int y, Color color, Bitmap newBitmap) // обертка для Bitmap.SetPixel, используем вместо этого Canvas.DrawPixel.
        {
            if (x < newBitmap.Width - 1 && x > 0 && y < newBitmap.Height - 1 && y > 0)
            {
                newBitmap.SetPixel(x, y, color);
            }
            else
            {

            }

        }
        public void Clear(PictureBox pictureBox)
        {
            AddToTmp();
            currentBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = currentBitmap;
            //PointPolygon.first.X = -1;
            //PointPolygon.first.Y = -1;
        }
        public void AddToTmp()
        {
            if (undoCounter == tmpList.Length)           // условие задано просто для ускорени добавления, поскольку InsertAndCut перебирает список до неоходимого индекса
                                                         //равенство undoCounter и tmpList.Length означает, что Undo не делалось и будет простая добавка.
                                                         // Если же Undo делалось, то  после того Bitmap, до которого дошли с помощью Undo будет добавлен новый Bitmap, а те, 
                                                         // которые ранее шли после текущего Bitmap удаляются из списка (с ними разрываются связи)
            {
                tmpList.Add(new Bitmap(currentBitmap));
            }
            else
            {
                tmpList.InsertAndCut(new Bitmap(currentBitmap), undoCounter);
            }
            undoCounter++;
        }
        

        public void Undo(PictureBox pictureBox) //метод отрисовывает предыдущий bitmap, надо передавать Bitmap с места вызова
        {
            if (undoCounter == 0)
            {

            }
            else if (undoCounter == tmpList.Length)
            {
                tmpList.Add(new Bitmap(currentBitmap));
                currentBitmap = tmpList[undoCounter - 1];
                pictureBox.Image = currentBitmap;
            }
            else
            {
                undoCounter--;
                currentBitmap = new Bitmap(tmpList[undoCounter - 1]);
                pictureBox.Image = currentBitmap;
            }
        }

        public void Redo(PictureBox pictureBox)
        {
            if (undoCounter == tmpList.Length)            //ничего не делаем, можно сделать кнопку неактивной просто
            {

            }
            else
            {
                undoCounter++;
                currentBitmap = new Bitmap(tmpList[undoCounter - 1]);
                pictureBox.Image = currentBitmap;
            }
        }
        

        public void DrawAllFigures(PictureBox pictureBox)
        {
            currentBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);


            foreach (AbstractPainter f in figures)
            {
                f.brush.DrawFigure(f.formFigure, currentBitmap, pictureBox, f.points);
            }
        }

        //public Figure FindFigureByPoint(Point p)
        //{

        //    foreach (Figure f in figures)
        //    {
        //        if (f.points.Contains(p))
        //            return f;
        //    }

        //    return null;
        //}

        public AbstractPainter FindFigureByPoint1(Point p)
        {
            foreach (AbstractPainter f in figures)
            {
                foreach (Point t in f.points)
                {
                    if (Math.Abs(t.X - p.X) <= 10 && Math.Abs(t.Y - p.Y) <= 10)
                    {
                        return f;
                    }
                }
            }
            return null;
        }

        //public int FindPointByPoint(Point p)
        //{

        //    foreach (Figure f in figures)
        //    {
        //        if (f.points.Contains(p))
        //        {
        //            return f.points.IndexOf(p);
        //        }

        //    }
        //    return -1;
        //}


        //public void PointChangeMode(PictureBox pictureBox)
        //{
        //    DrawAllFigures(pictureBox);
        //    Brush brush = new Brush();

        //    foreach (Figure f in figures)
        //    {
        //        foreach (Point t in f.points)
        //        {
        //            for (int i = -3; i <= 3; i++)
        //            {
        //                Point p1 = new Point(t.X - 3, t.Y + i);
        //                Point p2 = new Point(t.X + 3, t.Y + i);
        //                brush.DrawLine(p1, p2, pictureBox, Color.Red);

        //            }
        //        }
        //    }
        //}


    }
}
