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
using risovalka.ICan;

namespace risovalka
{
    public partial class Form1 : Form
    {
        public Canvas formCanvas = Canvas.GetCanvas;
        public Color currentColor = Color.Black;
        public static int size = 1;
        public IFormFigure currentForm = new LineForm();
        public APainterFactory currentFactory = new LinePainterFactory();
        public AbstractPainter currentPainter = null;
        public static bool drawStartFinishFlag = false;
        IButton buttonSwitch = new NoneButton();
        public AbstractFilling currentFilling; 
        public Color fillingColor = Color.Blue; //костыль
        public bool shift = false;
        public bool vectorMode = false;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formCanvas.currentBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            formCanvas.tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBoxCurrentColor.BackColor = Color.Black;
            currentFilling = new NoneFilling(currentColor);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentColor = pictureBoxPrevColor.BackColor;
            }


            formCanvas.tmpBitmap = new Bitmap(formCanvas.currentBitmap);
            formCanvas.AddToTmp();
            drawStartFinishFlag = buttonSwitch.ButtonSwitch(new Point(e.X, e.Y), pictureBox1, ref currentColor); 
            if (drawStartFinishFlag)
            {
                
                currentPainter = currentFactory.CreatePainter(currentForm, currentColor, size, new Point(e.X, e.Y), currentFilling);
                
                if (PointPolygonPainter.first.X != -1) 
                {

                    currentPainter.DrawDynamicFigure(new Point(e.X, e.Y), pictureBox1, shift);
                }
            }


            fillingColor = pictureBoxPrevColor.BackColor;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            if(buttonSwitch is PipetteButton)
            {
                pictureBoxCurrentColor.BackColor = currentColor;
                buttonSwitch = new NoneButton();
            }
            else
            {
                currentColor = pictureBoxCurrentColor.BackColor;
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
            if (drawStartFinishFlag)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    shift = true;
                }
                else
                {
                    shift = false;
                }
                
                currentPainter.DrawDynamicFigure(new Point(e.X, e.Y), pictureBox1, shift);
            }




            //}

            if (e.Button == MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = currentColor;
            }
            // pictureBoxPrevColor.BackColor = currentColor;
        }



        private void buttonPalette_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.FullOpen = true;

                if (MyDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                currentColor = MyDialog.Color;
                pictureBoxCurrentColor.BackColor = currentColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.FullOpen = true;

                if (MyDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                currentColor = MyDialog.Color;
                pictureBoxPrevColor.BackColor = currentColor;
            }
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
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory();
            }
            else
            {
                currentFactory = new LinePainterFactory();
            }
            currentForm = new LineForm();
            buttonSwitch = new NoneButton();
        }


        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory();
            }
            else
            {
                currentFactory = new FigurePainterFactory();
            }
            currentForm = new SquareForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonRectabgle_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory();
            }
            else
            {
                currentFactory = new FigurePainterFactory();
            }
            currentForm = new RectangleForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory();
            }
            else
            {
                currentFactory = new FigurePainterFactory();
            }
            currentForm = new IsoTriangleForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonRightTriangle_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory();
            }
            else
            {
                currentFactory = new FigurePainterFactory();
            }
            currentForm = new RecTriangleForm();
            buttonSwitch = new NoneButton();
        }

        private void buttonPolygon1_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory();
            }
            else
            {
                currentFactory = new FigurePainterFactory();
            }
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
       
        }

        private void pictureBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
     
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
      
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory();
            }
            else
            {
                currentFactory = new FigurePainterFactory();
            }
            currentForm = new CircleForm();
            buttonSwitch = new NoneButton();

        }

        private void buttonOval_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                currentFactory = new VectorFigurePainterFactory(); 
            }
            else
            {
                currentFactory = new FigurePainterFactory();
            }
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

        private void buttonRed_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonRed.BackColor;
                currentColor = buttonRed.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonRed.BackColor;

            }
        }

        private void buttonMagente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonMagente.BackColor;
                currentColor = buttonMagente.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonMagente.BackColor;

            }
        }

        private void buttonBrown_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonBrown.BackColor;
                currentColor = buttonBrown.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonBrown.BackColor;

            }
        }

        private void buttonYellow_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonYellow.BackColor;
                currentColor = buttonYellow.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonYellow.BackColor;

            }
        }

        private void buttonOrange_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonOrange.BackColor;
                currentColor = buttonOrange.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonOrange.BackColor;

            }
        }

        private void buttonLightCoral_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonLightCoral.BackColor;
                currentColor = buttonLightCoral.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonLightCoral.BackColor;

            }
        }

        private void buttonAqua_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonAqua.BackColor;
                currentColor = buttonAqua.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonAqua.BackColor;

            }
        }

        private void buttonLightSkyBlue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonLightSkyBlue.BackColor;
                currentColor = buttonLightSkyBlue.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonLightSkyBlue.BackColor;

            }
        }

        private void buttonGreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonGreen.BackColor;
                currentColor = buttonGreen.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonGreen.BackColor;

            }
        }

        private void buttonBlueViolet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonBlueViolet.BackColor;
                currentColor = buttonBlueViolet.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonBlueViolet.BackColor;

            }
        }

        private void buttonBlue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonBlue.BackColor;
                currentColor = buttonBlue.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonBlue.BackColor;

            }
        }

        private void buttonForestGreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonForestGreen.BackColor;
                currentColor = buttonForestGreen.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonForestGreen.BackColor;

            }
        }

        private void buttonWhite_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonWhite.BackColor;
                currentColor = buttonWhite.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonWhite.BackColor;

            }
        }

        private void buttonBlack_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxCurrentColor.BackColor = buttonBlack.BackColor;
                currentColor = buttonBlack.BackColor;
            }

            else if (e.Button == MouseButtons.Right)
            {
                pictureBoxPrevColor.BackColor = buttonBlack.BackColor;

            }
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Bitmap tmpBitmap = formCanvas.currentBitmap;
            formCanvas.currentBitmap = new Bitmap (pictureBox1.Width, pictureBox1.Height);
            formCanvas.currentBitmap = tmpBitmap;
        }
        public void ChooseColor()
        {
        //    ColorDialog MyDialog = new ColorDialog();



        //    MyDialog.FullOpen = true;

        //    MyDialog.Color = currentColor;

        //    if (MyDialog.ShowDialog() == DialogResult.Cancel)
        //        return;

        //    currentColor = MyDialog.Color;


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

        private void buttonOnlyFigure_Click(object sender, EventArgs e)
        {
            currentFilling = new TotalFilling(currentColor);
        }

        private void buttonFigureWithBorders_Click(object sender, EventArgs e)
        {
          //  fillingColor = pictureBoxPrevColor.BackColor;
            currentFilling = new InsideFilling(fillingColor );
        }

        private void buttonOnlyBorders_Click(object sender, EventArgs e)
        {
            currentFilling = new NoneFilling(currentColor);
        }

      

        private void UndoEdit_Click(object sender, EventArgs e)
        {
            formCanvas.Undo(pictureBox1);
        }

        private void ReduEdit_Click(object sender, EventArgs e)
        {
            formCanvas.Redo(pictureBox1);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCanvas.Clear(pictureBox1);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show(
        "Сохранить документ?",
        "Сообщение",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                
            }

            else if (result == DialogResult.No)
            {
                formCanvas.Clear(pictureBox1);
                formCanvas.currentBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                formCanvas.tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            else if (result == DialogResult.Cancel)
            { 
                
            }
        }

        private void buttonHand_Click(object sender, EventArgs e)
        {
            if (vectorMode)
            {
                panelForVectors.Visible = false;
                vectorMode = false;
                formCanvas.Clear(pictureBox1);
            }
            else
            {
                panelForVectors.Visible = true;
                vectorMode = true;
                formCanvas.Clear(pictureBox1);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog savePicture = new SaveFileDialog();
                savePicture.Title = "Сохранить картинку как";
                savePicture.OverwritePrompt = true; //если сохраняется файл с таким же названием
                savePicture.CheckFileExists = true; //если пути такого не существует
                savePicture.Filter = "Image Files (*.JPG)|*.JPG| Image Files (*.PNG)|*.PNG| Image Files (*.BMP)|*.BMP";
                savePicture.ShowHelp = true;

                if (savePicture.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(savePicture.FileName);
                    }

                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Oшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();
            openPicture.Filter = "Image Files (*.BMP; *.JPG; *.PNG)|*.BMP; *.JPG; *.PNG";

            if (openPicture.ShowDialog() == DialogResult.OK )
            {
                try 
                {
                   // pictureBox1.Image = new Bitmap (openPicture.FileName );
                    //formCanvas.currentBitmap = pictureBox1;
                    formCanvas.currentBitmap = new Bitmap(openPicture.FileName);
                    pictureBox1.Image = formCanvas.currentBitmap;
                }

                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
