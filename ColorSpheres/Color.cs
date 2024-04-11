using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace ColorSpheres
{
    public class Color
    {
        private int r;
        private int g;
        private int b;
        public const int a = 255;

        public Color(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public int GetRed ()
        {
            return r;
        }

        public int GetGreen ()
        {
            return g;
        }

        public int GetBlue ()
        {
            return b;
        }

        public int GetAlpha ()
        {
            return a;
        }

        public static Color GetGray (int r, int g, int b)
        {
            int media = (r + g + b) / 3;

            return new Color(media, media, media);
        }
    }
}