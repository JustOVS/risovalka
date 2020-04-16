using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risovalka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas.currentBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Canvas.tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            AbstractPainter.x1 = e.X;
            AbstractPainter.y1 = e.Y;
            AbstractPainter.drawStartFinishFlag = true;
            Canvas.tmpBitmap = new Bitmap (Canvas.currentBitmap);
            Canvas.AddToTmp();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            AbstractPainter.drawStartFinishFlag = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            AbstractPainter.drawSwitch.DrawDynamicFigure(e, pictureBox1);
            //Brush.DrawMouseLine(e, pictureBox1);
            //IPainter //painter.DrawDymanicFigure(e, picturebox1);
        }

       

        private void buttonPalette_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            Brush.currentColor = Color.Black;
            // расширенное окно для выбора цвета
            MyDialog.FullOpen = true;
            // установка начального цвета для colorDialog
            MyDialog.Color = Brush.currentColor;

            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            Brush.currentColor = MyDialog.Color;
        }

        private void buttonSize1_Click(object sender, EventArgs e)
        {
            Brush.Size = 1;
        }
        private void buttonSize2_Click(object sender, EventArgs e)
        {
            Brush.Size = 2;
        }

        private void buttonSize3_Click(object sender, EventArgs e)
        {
            Brush.Size = 3;
        }
        private void buttonSize4_Click(object sender, EventArgs e)
        {
            Brush.Size = 4;
        }

        private void buttonPencile_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new Line ();
        }


        private void buttonSquare_Click(object sender, EventArgs e)
        {

        }

        private void buttonRectabgle_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new Rectangle();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new IsoscelesTriangle ();
        }

        private void buttonRightTriangle_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new RectangleTriangle ();
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new Eraser();
        }

        private void buttonBucket_Click(object sender, EventArgs e)
        {
            Canvas.Clear(pictureBox1 );
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            Canvas.Undo(pictureBox1);
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            Canvas.Redo(pictureBox1);
        }
    }
}
