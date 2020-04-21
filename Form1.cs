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
            if (PointPolygon.first.X != -1 && PointPolygon.first.Y != -1) //&& e.Button == MouseButtons.Left && e.Clicks == 1
            {
                
                AbstractPainter.DrawLine(PointPolygon.last.X, PointPolygon.last.Y, e.X, e.Y, pictureBox1, Brush.currentColor);
                pictureBox1.Image = Canvas.currentBitmap;
                
            }
            else if (AbstractPainter.drawSwitch.GetType() == typeof(PointPolygon))
            {
                PointPolygon.first.X = e.X;
                PointPolygon.first.Y = e.Y;
                PointPolygon.last.X = e.X;
                PointPolygon.last.Y = e.Y;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            
             if (Math.Abs(e.X - PointPolygon.first.X) < 10 && Math.Abs(e.Y - PointPolygon.first.Y) < 10 && PointPolygon.first.X != -1)
            {
                Canvas.currentBitmap = new Bitmap(Canvas.tmpBitmap);
                AbstractPainter.DrawLine(PointPolygon.last.X, PointPolygon.last.Y, PointPolygon.first.X, PointPolygon.first.Y, pictureBox1, Brush.currentColor);
                PointPolygon.first.X = -1;
                PointPolygon.first.Y = -1;
            }
            else if (PointPolygon.first.X != -1)
            {
                PointPolygon.last.X = e.X;
                PointPolygon.last.Y = e.Y;
            }
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
            MyDialog.FullOpen = true;
            
            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;
          
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
            AbstractPainter.drawSwitch = new Square();
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

        private void buttonPolygon1_Click(object sender, EventArgs e)
        {
            panelPolygonSides.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

            }
        }

        private void buttonOkPanelPolygonSides_Click(object sender, EventArgs e)
        {
            Polygon.nSides = Convert.ToInt32(textBox1.Text);
            panelPolygonSides.Visible = false;
            AbstractPainter.drawSwitch = new Polygon();
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

        private void pictureBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.Shift)
            {
                AbstractPainter.shift = true;
            }
        }

        private void pictureBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)

            {
                AbstractPainter.shift = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                AbstractPainter.shift = true;
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Shift)
            {
                AbstractPainter.shift = true;
            }
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new Circle();
        }

        private void buttonOval_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new Ellipse();
        }

        private void buttonPolygon2_Click(object sender, EventArgs e)
        {
            AbstractPainter.drawSwitch = new PointPolygon();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(PointPolygon.first.X != -1)
            {
                AbstractPainter.DrawLine(PointPolygon.last.X, PointPolygon.last.Y, PointPolygon.first.X, PointPolygon.first.Y, pictureBox1, Brush.currentColor);
                PointPolygon.first.X = -1;
                PointPolygon.first.Y = -1;
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonRed.BackColor;
        }

        private void buttonMagente_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonMagente.BackColor;
        }

        private void buttonBrown_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonBrown.BackColor;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonYellow.BackColor;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonOrange.BackColor;
        }

        private void buttonLightCoral_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonLightCoral.BackColor;
        }

        private void buttonAqua_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonAqua.BackColor;
        }

        private void buttonLightSkyBlue_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonLightSkyBlue.BackColor;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonGreen.BackColor;
        }

        private void buttonBlueViolet_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonBlueViolet.BackColor;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonBlue.BackColor;
        }

        private void buttonForestGreen_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonForestGreen.BackColor;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonWhite.BackColor;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            Brush.currentColor = buttonBlack.BackColor;
        }

       
    }
}
