﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using risovalka.IFill;

namespace risovalka.IButtonswitch
{
    public class FillButton : IButton
    {
        public bool ButtonSwitch(Point p1, PictureBox pictureBox, ref Color currentColor, int currentSize)
        {
            new Filling().Fill(p1, pictureBox, currentColor, currentSize);
            return false;
        }
    }
}