using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace risovalka
{
    public static class Brush
    {
        public static bool drawStartFinishFlag = false;

        public static int x1, y1;                             // Стартовые координаты при рисовании мышкой, первоначально значения присваивается из mousedown;
     

        
        private static int size = 1;         //размер кисти, используем через свойство Size

        public static int Size               //надо прикрутить к бегунку 4 положения для переключения размера
        {
            get
            {
                return size;
            }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    size = value;
                }
            }
        }

        public static Color currentColor = Color.Black;
        public static void DrawMouseLine(MouseEventArgs e, PictureBox pictureBox)
        {
            DrawLine(x1, y1, e.X, e.Y, pictureBox);
            x1 = e.X;
            y1 = e.Y;
        }
        public static void DrawLine(int x1, int y1, int x2, int y2, PictureBox pictureBox)
        {
            if (drawStartFinishFlag == true)
            {
                int lengthX = Math.Abs(x2 - x1);
                int lengthY = Math.Abs(y2 - y1);

                int length = Math.Max(lengthX, lengthY);
                

                if (length == 0)
                {

                    //Canvas.DrawPixel(x1, y1, Color.Red);
                    Pen();
                    pictureBox.Image = Canvas.currentBitmap;
                }

                else 
                {
                    double dx = (double)(x2 - x1) / (double)length;
                    double dy = (double)(y2 - y1) / (double)length;
                    double x = x1;
                    double y = y1;

                    

                    while (length + 1 != 0)
                    {
                        //Canvas.DrawPixel((int)x, (int)y, Color.Red);
                        Pen();
                        pictureBox.Image = Canvas.currentBitmap;

                        x += dx;
                        y += dy;
                        length--;
                    }
                }

            }
        }
        public static void Pen()                  
        {                                                           
            switch(Size)
            {
                case 1:
                    Canvas.DrawPixel(x1, y1, currentColor);
                    break;
                
                case 2:
                    Canvas.DrawPixel(x1 - 1, y1 - 1, currentColor);
                    Canvas.DrawPixel(x1, y1 - 1, currentColor);
                    Canvas.DrawPixel(x1 - 1, y1, currentColor);
                    Canvas.DrawPixel(x1, y1, currentColor);
                    break;
                case 3:
                    Canvas.DrawPixel(x1, y1, currentColor);
                    Canvas.DrawPixel(x1 - 1, y1, currentColor);
                    Canvas.DrawPixel(x1 + 1, y1, currentColor);
                    Canvas.DrawPixel(x1, y1 - 1, currentColor);
                    Canvas.DrawPixel(x1, y1 + 1, currentColor);
                    break;
                case 4:
                    Canvas.DrawPixel(x1 - 1, y1 - 1, currentColor);
                    Canvas.DrawPixel(x1, y1 - 1, currentColor);
                    Canvas.DrawPixel(x1 - 1, y1, currentColor);
                    Canvas.DrawPixel(x1, y1, currentColor);

                    Canvas.DrawPixel(x1 - 2, y1, currentColor);
                    Canvas.DrawPixel(x1 - 2, y1 - 1, currentColor);

                    Canvas.DrawPixel(x1 - 1, y1 - 2, currentColor);

                    Canvas.DrawPixel(x1 + 1, y1 - 1, currentColor);
                    Canvas.DrawPixel(x1 +1, y1, currentColor);

                    Canvas.DrawPixel(x1 - 1, y1 + 1, currentColor);
                    Canvas.DrawPixel(x1, y1 + 1, currentColor);
                    break;
                    
            }
                
        }

        public static void EraseLine(MouseEventArgs e, PictureBox pictureBox)   
        {
            Color tmpColor = currentColor;
            currentColor = pictureBox.BackColor;
            DrawLine(x1, y1, e.X, e.Y, pictureBox);
            x1 = e.X;
            y1 = e.Y;
            currentColor = tmpColor;
        }
    }
}
