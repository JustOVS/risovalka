using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.FormFigure;
using risovalka.AbstractPainterFactory;
using risovalka.APainter;

namespace risovalka
{
    public partial class Form1 : Form
    {
        public Canvas formCanvas = Canvas.GetCanvas;
        public static Color currentColor = Color.Black;
        public static int size = 1;
        public IFormFigure currentForm = new LineForm();
        public APainterFactory currentFactory = new LinePainterFactory();
        public AbstractPainter currentPainter = null;
        public static bool drawStartFinishFlag = false;
        public Form1()
        {
            InitializeComponent();


        }





        private void Form1_Load(object sender, EventArgs e)
        {
            formCanvas.currentBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            formCanvas.tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //AbstractPainter.x1 = e.X;
            //AbstractPainter.y1 = e.Y;
            drawStartFinishFlag = true;
            formCanvas.tmpBitmap = new Bitmap(formCanvas.currentBitmap);
            formCanvas.AddToTmp();
            currentPainter = currentFactory.CreatePainter(currentForm, currentColor, size, new Point(e.X, e.Y));

            //if (PointPolygon.first.X != -1 && PointPolygon.first.Y != -1) //&& e.Button == MouseButtons.Left && e.Clicks == 1
            //{

            //    AbstractPainter.DrawLine(PointPolygon.last.X, PointPolygon.last.Y, e.X, e.Y, pictureBox1, Brush.currentColor);
            //    pictureBox1.Image = formCanvas.currentBitmap;

            //}
            //else if (AbstractPainter.drawSwitch.GetType() == typeof(PointPolygon))
            //{
            //    PointPolygon.first.X = e.X;
            //    PointPolygon.first.Y = e.Y;
            //    PointPolygon.last.X = e.X;
            //    PointPolygon.last.Y = e.Y;
            //}

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {


            // if (Math.Abs(e.X - PointPolygon.first.X) < 10 && Math.Abs(e.Y - PointPolygon.first.Y) < 10 && PointPolygon.first.X != -1)
            //{
            //    formCanvas.currentBitmap = new Bitmap(formCanvas.tmpBitmap);
            //    AbstractPainter.DrawLine(PointPolygon.last.X, PointPolygon.last.Y, PointPolygon.first.X, PointPolygon.first.Y, pictureBox1, Brush.currentColor);
            //    PointPolygon.first.X = -1;
            //    PointPolygon.first.Y = -1;
            //}
            //else if (PointPolygon.first.X != -1)
            //{
            //    PointPolygon.last.X = e.X;
            //    PointPolygon.last.Y = e.Y;
            //}
            drawStartFinishFlag = false;


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawStartFinishFlag == true)
            {
                currentPainter.DrawDynamicFigure(new Point(e.X, e.Y), pictureBox1);
            }
            //Brush.DrawMouseLine(e, pictureBox1);
            //IPainter //painter.DrawDymanicFigure(e, picturebox1);

        }



        private void buttonPalette_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.FullOpen = true;

            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;

            currentColor = MyDialog.Color;
        }

        private void buttonSize1_Click(object sender, EventArgs e)
        {
            size = 1;
        }
        private void buttonSize2_Click(object sender, EventArgs e)
        {
            size = 2;
        }

        private void buttonSize3_Click(object sender, EventArgs e)
        {
            size = 3;
        }
        private void buttonSize4_Click(object sender, EventArgs e)
        {
            size = 4;
        }

        private void buttonPencile_Click(object sender, EventArgs e)
        {
            currentFactory = new LinePainterFactory();
            currentForm = new LineForm();
        }


        private void buttonSquare_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new SquareForm();
        }

        private void buttonRectabgle_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new RectangleForm();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new IsoTriangleForm();
        }

        private void buttonRightTriangle_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new RecTriangleForm();
        }

        private void buttonPolygon1_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new PolygonForm(Convert.ToInt32(numericUpDownForPolygon.Value));
        }

        private void numericUpDownForPolygon_ValueChanged(object sender, EventArgs e)
        {
            //Polygon.nSides = Convert.ToInt32 ( numericUpDownForPolygon.Value);
            currentForm = new PolygonForm(Convert.ToInt32(numericUpDownForPolygon.Value));

        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            //AbstractPainter.drawSwitch = new Eraser();
        }

        private void buttonBucket_Click(object sender, EventArgs e)
        {
            formCanvas.Clear(pictureBox1);
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            formCanvas.Undo(pictureBox1);
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            formCanvas.Redo(pictureBox1);
        }

        private void pictureBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if(e.Shift)
            //{
            //    AbstractPainter.shift = true;
            //}
        }

        private void pictureBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if (Control.ModifierKeys == Keys.Shift)

            //{
            //    AbstractPainter.shift = false;
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Shift)
            //{
            //    AbstractPainter.shift = true;
            //}
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.Shift)
            //{
            //    AbstractPainter.shift = true;
            //}
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new CircleForm();

        }

        private void buttonOval_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new EllipseForm();
        }

        private void buttonPolygon2_Click(object sender, EventArgs e)
        {
            //AbstractPainter.drawSwitch = new PointPolygon();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //if(PointPolygon.first.X != -1)
            //{
            //    AbstractPainter.DrawLine(PointPolygon.last.X, PointPolygon.last.Y, PointPolygon.first.X, PointPolygon.first.Y, pictureBox1, Brush.currentColor);
            //    PointPolygon.first.X = -1;
            //    PointPolygon.first.Y = -1;
            //}
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            currentColor = buttonRed.BackColor;
        }

        private void buttonMagente_Click(object sender, EventArgs e)
        {
            currentColor = buttonMagente.BackColor;
        }

        private void buttonBrown_Click(object sender, EventArgs e)
        {
            currentColor = buttonBrown.BackColor;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            currentColor = buttonYellow.BackColor;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            currentColor = buttonOrange.BackColor;
        }

        private void buttonLightCoral_Click(object sender, EventArgs e)
        {
            currentColor = buttonLightCoral.BackColor;
        }

        private void buttonAqua_Click(object sender, EventArgs e)
        {
            currentColor = buttonAqua.BackColor;
        }

        private void buttonLightSkyBlue_Click(object sender, EventArgs e)
        {
            currentColor = buttonLightSkyBlue.BackColor;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            currentColor = buttonGreen.BackColor;
        }

        private void buttonBlueViolet_Click(object sender, EventArgs e)
        {
            currentColor = buttonBlueViolet.BackColor;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            currentColor = buttonBlue.BackColor;
        }

        private void buttonForestGreen_Click(object sender, EventArgs e)
        {
            currentColor = buttonForestGreen.BackColor;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            currentColor = buttonWhite.BackColor;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            currentColor = buttonBlack.BackColor;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            //Bitmap tmpBitmap = Canvas.currentBitmap;
            //Canvas.currentBitmap = new Bitmap (pictureBox1.Width, pictureBox1.Height);
            //Canvas.currentBitmap = tmpBitmap;

        }
        public void ChooseColor()
        {
            ColorDialog MyDialog = new ColorDialog();



            MyDialog.FullOpen = true;

            MyDialog.Color = currentColor;

            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;

            currentColor = MyDialog.Color;


        }
    }
}
