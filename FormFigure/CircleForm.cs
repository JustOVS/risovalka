using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka;

namespace risovalka.FormFigure
{
    public class CircleForm : IFormFigure
    {
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int r = Convert.ToInt32(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

           
            List<Point> list1 = new List<Point>() { new Point(x1, r + y1) };
            List<Point> list2 = new List<Point>() { new Point(x1, r + y1) };
            List<Point> list3 = new List<Point>() { new Point(x1, -r + y1) };
            List<Point> list4 = new List<Point>() { new Point(x1, -r + y1) };
            for (int i = 0; i <= r; i++)
            {
                double catet = Math.Sqrt(r * r - i * i);



                list1.Add(new Point (i + x1, Convert.ToInt32(catet) + y1));
                list2.Add(new Point (-i + x1, Convert.ToInt32(catet) + y1));
                list3.Add(new Point (i + x1, -Convert.ToInt32(catet) + y1));
                list4.Add(new Point (-i + x1, -Convert.ToInt32(catet) + y1));
            }
            list3.Reverse();
            list1.AddRange(list3);
            list1.AddRange(list4);
            list2.Reverse();
            list1.AddRange(list2);
            return list1;
        }

        public Point GetCenter(Point p1, Point p2)
        {
            return new Point(((p1.X + p2.X) / 2), ((p1.Y + p2.Y) / 2));
        }
    }
}
