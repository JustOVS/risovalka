﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risovalka
{
    public class Line : AbstractPainter
    {
        
        public override void DrawDynamicFigure(MouseEventArgs e, PictureBox pictureBox)
        {
            AbstractPainter.DrawLine(x1, y1, e.X, e.Y, pictureBox);
            x1 = e.X;
            y1 = e.Y;
        }
    }
}
