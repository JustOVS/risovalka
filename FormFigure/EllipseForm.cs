using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using risovalka;

namespace risovalka.FormFigure
{
    public class EllipseForm : IFormFigure
    {
        public List<Point> CalculateFigure(Point p1, Point p2)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            bool horizontalOrientationFlag = false;
            int majorAxis;
            int smallAxis;
            List<Point> list1 = new List<Point>();
            List<Point> list2 = new List<Point>();
            List<Point> list3 = new List<Point>();
            List<Point> list4 = new List<Point>();

            if (Math.Abs(x2 - x1) > Math.Abs(y2 - y1))
            {
                majorAxis = Math.Abs(x2 - x1);
                smallAxis = Math.Abs(y2 - y1);

                horizontalOrientationFlag = true;
            }

            else
            {
                majorAxis = Math.Abs(y2 - y1);
                smallAxis = Math.Abs(x2 - x1);
            }



            for (int i = 0; i <= majorAxis; i++)
            {
                double x;
                double y;

                if (majorAxis == 0)
                {
                    break;
                }

                else if (horizontalOrientationFlag)
                {
                    x = i;
                    y = Math.Sqrt((Math.Pow(smallAxis, 2) / Math.Pow(majorAxis, 2)) * (Math.Pow(majorAxis, 2) - Math.Pow(x, 2)));
                }
                else
                {
                    y = i;
                    x = Math.Sqrt((Math.Pow(smallAxis, 2) / Math.Pow(majorAxis, 2)) * (Math.Pow(majorAxis, 2) - Math.Pow(y, 2)));
                }
             
                    list1.Add(new Point(Convert.ToInt32(x1 + x), Convert.ToInt32(y1 + y)));
                    list2.Add(new Point(Convert.ToInt32(x1 + x), Convert.ToInt32(y1 - y)));
                    list3.Add(new Point(Convert.ToInt32(x1 - x), Convert.ToInt32(y1 - y)));
                    list4.Add(new Point(Convert.ToInt32(x1 - x), Convert.ToInt32(y1 + y)));



            }
            if (horizontalOrientationFlag)
            {
                list2.Reverse();
                list1.AddRange(list2);
                list1.AddRange(list3);
                list4.Reverse();
                list1.AddRange(list4);
            }
            else
            {
                list1.Reverse();
                list1.AddRange(list2);
                list3.Reverse();
                list1.AddRange(list3);
                list1.AddRange(list4);
            }
            
            
            
            
            return list1;
        }
        public Point GetCenter(Point p1, Point p2)
        {
            return p1; //new Point(((p1.X + p2.X) / 2), ((p1.Y + p2.Y) / 2));
        }
    }
}
