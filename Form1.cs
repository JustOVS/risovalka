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
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Brush.x1 = e.X;
            Brush.y1 = e.Y;
            Brush.drawStartFinishFlag = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Brush.drawStartFinishFlag = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Brush.DrawMouseLine(e, pictureBox1);
        }

        private void palette_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            // расширенное окно для выбора цвета
            MyDialog.FullOpen = true;
            // установка начального цвета для colorDialog
            MyDialog.Color = this.BackColor;

            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            this.BackColor = MyDialog.Color;
        }
    }
}
