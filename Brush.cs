using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace risovalka
{
    public class Brush
    {
        public Color currentColor = Form1.currentColor;
        public static Canvas brushCanvas = Canvas.GetCanvas;
        public int size = Form1.size;         //размер кисти, используем через свойство Size
   
public static bool takePipette = false;
        public Brush()
        {
            currentColor = Form1.currentColor;
            size = Form1.size;
        }
        
       
        public Brush(Color currentColor, int size)
        {
            this.currentColor = currentColor;
            this.size = size;
        }
        public void Pen(int x1, int y1, Color currentColor)
        {
            switch (size)
            {
                case 1:
                    brushCanvas.DrawPixel(x1, y1, currentColor);
                    break;

                case 2:
                    brushCanvas.DrawPixel(x1 - 1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1 - 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1, y1, currentColor);
                    break;
                case 3:
                    brushCanvas.DrawPixel(x1, y1, currentColor);
                    brushCanvas.DrawPixel(x1 - 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1 + 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 + 1, currentColor);
                    break;
                case 4:
                    brushCanvas.DrawPixel(x1 - 1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1 - 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1, y1, currentColor);

                    brushCanvas.DrawPixel(x1 - 2, y1, currentColor);
                    brushCanvas.DrawPixel(x1 - 2, y1 - 1, currentColor);

                    brushCanvas.DrawPixel(x1 - 1, y1 - 2, currentColor);

                    brushCanvas.DrawPixel(x1 + 1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1 + 1, y1, currentColor);

                    brushCanvas.DrawPixel(x1 - 1, y1 + 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 + 1, currentColor);
                    break;

            }
        }
        public void Pen(int x1, int y1, Color currentColor, Bitmap newBitmap)
        {
            switch (size)
            {
                case 1:
                    brushCanvas.DrawPixel(x1, y1, currentColor, newBitmap);
                    break;

                case 2:
                    brushCanvas.DrawPixel(x1 - 1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1 - 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1, y1, currentColor);
                    break;
                case 3:
                    brushCanvas.DrawPixel(x1, y1, currentColor);
                    brushCanvas.DrawPixel(x1 - 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1 + 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 + 1, currentColor);
                    break;
                case 4:
                    brushCanvas.DrawPixel(x1 - 1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1 - 1, y1, currentColor);
                    brushCanvas.DrawPixel(x1, y1, currentColor);

                    brushCanvas.DrawPixel(x1 - 2, y1, currentColor);
                    brushCanvas.DrawPixel(x1 - 2, y1 - 1, currentColor);

                    brushCanvas.DrawPixel(x1 - 1, y1 - 2, currentColor);

                    brushCanvas.DrawPixel(x1 + 1, y1 - 1, currentColor);
                    brushCanvas.DrawPixel(x1 + 1, y1, currentColor);

                    brushCanvas.DrawPixel(x1 - 1, y1 + 1, currentColor);
                    brushCanvas.DrawPixel(x1, y1 + 1, currentColor);
                    break;

            }
        }
        public void DrawLine(Point p1, Point p2, PictureBox pictureBox, Color currentColor)
        {
                int x1 = p1.X;
                int y1 = p1.Y;
                int x2 = p2.X;
                int y2 = p2.Y;
                //if (Form1.drawStartFinishFlag == true)
                //{
                    int lengthX = Math.Abs(x2 - x1);
                    int lengthY = Math.Abs(y2 - y1);

                    int length = Math.Max(lengthX, lengthY);


                    if (length == 0)
                    {

                        //Canvas.DrawPixel(x1, y1, Color.Red);
                        Pen(x1, y1, currentColor);
                        pictureBox.Image = brushCanvas.currentBitmap;
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
                            Pen((int)x, (int)y, currentColor);
                            pictureBox.Image = brushCanvas.currentBitmap;

                            x += dx;
                            y += dy;
                            length--;
                        }
                    }

                //}
        }
        public void DrawLine(Point p1, Point p2, PictureBox pictureBox, Color currentColor, Bitmap newBitmap)
        {
            
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            //if (Form1.drawStartFinishFlag == true)
            //{
            int lengthX = Math.Abs(x2 - x1);
            int lengthY = Math.Abs(y2 - y1);

            int length = Math.Max(lengthX, lengthY);


            if (length == 0)
            {

                //Canvas.DrawPixel(x1, y1, Color.Red);
                Pen(x1, y1, currentColor, newBitmap);
                pictureBox.Image = newBitmap;
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
                    Pen((int)x, (int)y, currentColor, newBitmap);
                    pictureBox.Image = newBitmap;

                    x += dx;
                    y += dy;
                    length--;
                }
            }

            //}
        }



        //public static void ChooseColor()
        //{
        //    ColorDialog MyDialog = new ColorDialog();



        //    MyDialog.FullOpen = true;

        //    MyDialog.Color = currentColor;

        //    if (MyDialog.ShowDialog() == DialogResult.Cancel)
        //        return;

        //    currentColor = MyDialog.Color;
        //}
        //public static void DrawMouseLine(MouseEventArgs e, PictureBox pictureBox)
        //{
        //    DrawLine(x1, y1, e.X, e.Y, pictureBox);
        //    x1 = e.X;
        //    y1 = e.Y;
        //}
        //public static void DrawLine(int x1, int y1, int x2, int y2, PictureBox pictureBox)
        //{
        //    if (drawStartFinishFlag == true)
        //    {
        //        int lengthX = Math.Abs(x2 - x1);
        //        int lengthY = Math.Abs(y2 - y1);

        //        int length = Math.Max(lengthX, lengthY);


        //        if (length == 0)
        //        {

        //            //Canvas.DrawPixel(x1, y1, Color.Red);
        //            Pen(x1, y1);
        //            pictureBox.Image = Canvas.currentBitmap;
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
        //                Pen((int)x, (int)y);
        //                pictureBox.Image = Canvas.currentBitmap;

        //                x += dx;
        //                y += dy;
        //                length--;
        //            }
        //        }

        //    }
        //}


    }

        //public static void EraseLine(MouseEventArgs e, PictureBox pictureBox)   
        //{

        //        Color tmpColor = currentColor;
        //        currentColor = pictureBox.BackColor;
        //        DrawLine(x1, y1, e.X, e.Y, pictureBox);
        //        x1 = e.X;
        //        y1 = e.Y;
        //        currentColor = tmpColor;

        //}


    }
