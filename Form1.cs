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
using risovalka.AFill;
using risovalka.IButtonswitch;
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
        IButton buttonSwitch = new NoneButton();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formCanvas.currentBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            formCanvas.tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBoxCurrentColor.BackColor = Color.Black;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            
            formCanvas.tmpBitmap = new Bitmap(formCanvas.currentBitmap);
            formCanvas.AddToTmp();
            drawStartFinishFlag = buttonSwitch.ButtonSwitch(new Point(e.X, e.Y), pictureBox1, ref currentColor); 
            if (drawStartFinishFlag)
            {
                currentPainter = currentFactory.CreatePainter(currentForm, currentColor, size, new Point(e.X, e.Y));

                if (PointPolygonPainter.first.X != -1) 
                {

                    currentPainter.DrawDynamicFigure(new Point(e.X, e.Y), pictureBox1);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(buttonSwitch is PipetteButton)
            {
                buttonSwitch = new NoneButton();
            }

            if (Math.Abs(e.X - PointPolygonPainter.first.X) < 10 && Math.Abs(e.Y - PointPolygonPainter.first.Y) < 10 && PointPolygonPainter.first.X != -1)
            {
                new PointPolygonPainter(currentColor, size).ConnectLastAndFirst(pictureBox1);
            }
            else if (PointPolygonPainter.first.X != -1)
            {
                PointPolygonPainter.last.X = e.X;
                PointPolygonPainter.last.Y = e.Y;
            }
            drawStartFinishFlag = false;
        }
        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawStartFinishFlag == true)
            {
                //if (Control.ModifierKeys == Keys.Shift && (currentForm is RectangleForm))
                //{
                //    AbstractPainter tmpPainter = currentFactory.CreatePainter(new SquareForm(), currentColor, size, new Point(e.X, e.Y));
                //    tmpPainter.DrawDynamicFigure(new Point(e.X, e.Y), pictureBox1);
                //}
                ////else if (Control.ModifierKeys != Keys.Shift && (AbstractPainter.drawSwitch.GetType() == typeof(Rectangle)))
                ////{

                ////    new Rectangle().DrawDynamicFigure(e, pictureBox1);
                ////}
                ////else
                ////{
                ////    AbstractPainter.drawSwitch.DrawDynamicFigure(e, pictureBox1);
                ////}

                //else
                //{
                    currentPainter.DrawDynamicFigure(new Point(e.X, e.Y), pictureBox1);
                //}

            }
            pictureBoxCurrentColor.BackColor = currentColor;
        }



        private void buttonPalette_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.FullOpen = true;

            if (MyDialog.ShowDialog() == DialogResult.Cancel)
                return;

            currentColor = MyDialog.Color;
        }

        private void buttonPipetka_Click(object sender, EventArgs e)
        {
            buttonSwitch = new PipetteButton();
        }

        private void pictureBoxCurrentColor_Click(object sender, EventArgs e)
        {
            currentColor = pictureBoxCurrentColor.BackColor;
        }

        private void pictureBoxPrevColor_Click(object sender, EventArgs e)
        {
            currentColor = pictureBoxPrevColor.BackColor;
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
            buttonSwitch = new NoneButton();
        }


        private void buttonSquare_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new SquareForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonRectabgle_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new RectangleForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new IsoTriangleForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonRightTriangle_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new RecTriangleForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonPolygon1_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new PolygonForm(Convert.ToInt32(numericUpDownForPolygon.Value));
            buttonSwitch = new NoneButton();
        }

        private void numericUpDownForPolygon_ValueChanged(object sender, EventArgs e)
        {
            currentForm = new PolygonForm(Convert.ToInt32(numericUpDownForPolygon.Value));
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            currentFactory = new ErasePainterFactory();
            currentForm = new LineForm();
            buttonSwitch = new NoneButton();
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
            buttonSwitch = new NoneButton();

        }

        private void buttonOval_Click(object sender, EventArgs e)
        {
            currentFactory = new FigurePainterFactory();
            currentForm = new EllipseForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonPolygon2_Click(object sender, EventArgs e)
        {
            currentFactory = new PointPolygonPainterFactory();
            currentForm = new LineForm();
            buttonSwitch = new NoneButton();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (PointPolygonPainter.first.X != -1)
            {
                new PointPolygonPainter(currentColor, size).ConnectLastAndFirst(pictureBox1);
            }
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

       

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Bitmap tmpBitmap = formCanvas.currentBitmap;
            formCanvas.currentBitmap = new Bitmap (pictureBox1.Width, pictureBox1.Height);
            formCanvas.currentBitmap = tmpBitmap;
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

        private void button1_Click(object sender, EventArgs e)
        {
            buttonSwitch = new FillButton();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            formCanvas.tmpBitmap = formCanvas.currentBitmap;
            formCanvas.currentBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
