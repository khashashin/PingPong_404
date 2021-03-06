﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_404
{
    class Zufallsmethoden
    {
        private Random rand = new Random();

        public int ErzeugeZufallszahl(int min, int max)
        {
            max++;
            return rand.Next(min, max);
        }

        public Color ErzeugeZufallsfarbe()
        {
            Color randColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            return randColor;
        }
    }
}
