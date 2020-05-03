//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Drawing;
//using risovalka.APainter;

//namespace risovalka.ICan
//{
//    public class VectorCanvas : Canvas
//    {
//        private static VectorCanvas obj;

//        public Bitmap currentBitmap;
//        public Bitmap tmpBitmap;


//        private VectorCanvas()
//        {
//        }

//        public static VectorCanvas GetCanvas
//        {
//            get
//            {
//                if (obj == null)
//                {
//                    obj = new VectorCanvas();
//                }
//                return obj;
//            }
//        }
//        public void DrawPixel(int x, int y, Color color) // обертка для Bitmap.SetPixel, используем вместо этого Canvas.DrawPixel.
//        {
//            if (x < currentBitmap.Width - 1 && x > 0 && y < currentBitmap.Height - 1 && y > 0)
//            {
//                currentBitmap.SetPixel(x, y, color);
//            }
//            else
//            {

//            }

//        }

//        public void DrawPixel(int x, int y, Color color, Bitmap newBitmap) // обертка для Bitmap.SetPixel, используем вместо этого Canvas.DrawPixel.
//        {
//            if (x < newBitmap.Width - 1 && x > 0 && y < newBitmap.Height - 1 && y > 0)
//            {
//                newBitmap.SetPixel(x, y, color);
//            }
//            else
//            {

//            }

//        }
//        public List<AbstractPainter> figures;

//        public void DrawAllFigures(PictureBox pictureBox)
//        {
//            currentBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            
//            foreach (AbstractPainter f in figures)
//            {
//                f.brush.DrawFigure(f.formFigure, currentBitmap, pictureBox, f.points);
//            }
//        }

//        public Figure FindFigureByPoint(Point p)
//        {

//            foreach (Figure f in figures)
//            {
//                if (f.points.Contains(p))
//                    return f;
//            }

//            return null;
//        }

//        public Figure FindFigureByPoint1(Point p)
//        {
//            foreach (Figure f in figures)
//            {
//                foreach (Point t in f.points)
//                {
//                    if (Math.Abs(t.X - p.X) <= 10 && Math.Abs(t.Y - p.Y) <= 10)
//                    {
//                        return f;
//                    }
//                }
//            }
//            return null;
//        }

//        public int FindPointByPoint(Point p)
//        {

//            foreach (Figure f in figures)
//            {
//                if (f.points.Contains(p))
//                {
//                    return f.points.IndexOf(p);
//                }

//            }
//            return -1;
//        }


//        public void PointChangeMode(PictureBox pictureBox)
//        {
//            DrawAllFigures(pictureBox);
//            Brush brush = new Brush();

//            foreach (Figure f in figures)
//            {
//                foreach (Point t in f.points)
//                {
//                    for (int i = -3; i <= 3; i++)
//                    {
//                        Point p1 = new Point(t.X - 3, t.Y + i);
//                        Point p2 = new Point(t.X + 3, t.Y + i);
//                        brush.DrawLine(p1, p2, pictureBox, Color.Red);

//                    }
//                }
//            }
//        }
//    }
//}
