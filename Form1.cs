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

        private void palette_Click(object sender, EventArgs e)
        {
            // ColorDialog MyDialog = new ColorDialog();

            // Color currentColor = Color.Black;
            // // расширенное окно для выбора цвета
            // MyDialog.FullOpen = true;
            // // установка начального цвета для colorDialog
            // MyDialog.Color =currentColor;

            // if (MyDialog.ShowDialog() == DialogResult.Cancel)
            //     return;
            // // установка цвета формы
            ////currentColor = MyDialog.Color;
            Brush.ChooseColor();
        }

        private void size1_Click(object sender, EventArgs e)
        {
            Brush.Size = 1;
        }

        private void size2_Click(object sender, EventArgs e)
        {
            Brush.Size = 2;
        }

        private void size3_Click(object sender, EventArgs e)
        {
            Brush.Size = 3;
        }

        private void size4_Click(object sender, EventArgs e)
        {
            Brush.Size = 4;
        }
    }
}
