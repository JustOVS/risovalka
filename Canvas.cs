using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using risovalka.List;

namespace risovalka
{
    public class Canvas
    {
        private static Canvas obj;
        public List<Bitmap> archive;
        public Bitmap currentBitmap;
        public Bitmap tmpBitmap;
        public L2List tmpList = new L2List();    //сохраняем сюда все currentBmp после каждого действия, чтобы была возможность использовать Undo/Redo

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
            if (x >= currentBitmap.Width || x < 0 || y >= currentBitmap.Height || y < 0)
            {

            }
            else
            {
                currentBitmap.SetPixel(x, y, color);
            }
        }
        public void Clear(PictureBox pictureBox)
        {
            AddToTmp();
            currentBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = currentBitmap;
            PointPolygon.first.X = -1;
            PointPolygon.first.Y = -1;
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


        //public static Bitmap currentBitmap;             // текущий бмп, с которым работаем (инициализируем в load)
        //public static Bitmap tmpBitmap;                 // бмп, который испольхуем для временных отрисовок фигур и пр., используется, что последействия его значение передать currentBmp (инициализируем в load)
        //public static L2List tmpList = new L2List();    //сохраняем сюда все currentBmp после каждого действия, чтобы была возможность использовать Undo/Redo

        //public static int undoCounter = 0;              //показывает индекс элемента, следующего за последним активным. Основное применение при undo/redo
        //                                                // undoCounter увеличивается при добавлении элемента в tmpList, уменьшается при использовании undo, увеличивается
        //                                                //при использовании redo, т.е. если мы сделали undo 3 раза, а потом undo 1 раз, а потом сделали новое действие, то,
        //                                                // благодаря undocounter и методу L2list.InsertAndCut мы удаляем из списка 2 элемента, на которые сделали undo.

        //public static void AddToTmp()
        //{
        //    if (undoCounter == tmpList.Length)           // условие задано просто для ускорени добавления, поскольку InsertAndCut перебирает список до неоходимого индекса
        //                                                 //равенство undoCounter и tmpList.Length означает, что Undo не делалось и будет простая добавка.
        //                                                 // Если же Undo делалось, то  после того Bitmap, до которого дошли с помощью Undo будет добавлен новый Bitmap, а те, 
        //                                                 // которые ранее шли после текущего Bitmap удаляются из списка (с ними разрываются связи)
        //    {
        //        tmpList.Add(new Bitmap(currentBitmap));
        //    }
        //    else
        //    {
        //        tmpList.InsertAndCut(new Bitmap(currentBitmap), undoCounter);
        //    }
        //    undoCounter++;
        //}

        //public static void Undo(PictureBox pictureBox) //метод отрисовывает предыдущий bitmap, надо передавать Bitmap с места вызова
        //{
        //    if (undoCounter == 0 )
        //    {

        //    }
        //    else if (undoCounter == tmpList.Length)
        //    {
        //        tmpList.Add(new Bitmap (currentBitmap));
        //        currentBitmap = tmpList[undoCounter - 1];
        //        pictureBox.Image = currentBitmap;
        //    }
        //    else
        //    {
        //        undoCounter--;
        //        currentBitmap = new Bitmap(tmpList[undoCounter - 1]);
        //        pictureBox.Image = currentBitmap;
        //    }
        //}

        //public static void Redo(PictureBox pictureBox)
        //{
        //    if (undoCounter == tmpList.Length)            //ничего не делаем, можно сделать кнопку неактивной просто
        //    {

        //    }
        //    else
        //    {
        //        undoCounter++;
        //        currentBitmap = new Bitmap(tmpList[undoCounter - 1]);
        //        pictureBox.Image = currentBitmap;
        //    }
        //}

        //public static void DrawPixel(int x, int y, Color color) // обертка для Bitmap.SetPixel, используем вместо этого Canvas.DrawPixel.
        //{
        //    if (x >= currentBitmap.Width || x < 0 || y >= currentBitmap.Height || y < 0)
        //    {

        //    }
        //    else
        //    {
        //        currentBitmap.SetPixel(x, y, color);
        //    }
        //}
        //public static void Clear(PictureBox pictureBox)
        //{
        //    AddToTmp();
        //    currentBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        //    pictureBox.Image = currentBitmap;
        //    PointPolygon.first.X = -1;
        //    PointPolygon.first.Y = -1;
        //}
    }
}
