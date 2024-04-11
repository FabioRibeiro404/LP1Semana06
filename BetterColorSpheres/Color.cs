using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace BetterColorSpheres
{
    public class Color
    {
        private int r;
        private int g;
        private int b;
        private const int a = 255;

        public Color(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public int Red
        {
            get => r;
            set => r = value;
        }
        public int Green
        {
            get => g;
            set => g = value;
        }
        public int Blue
        {
            get => b;
            set => b = value;
        }
        public int Alpha
        {
            get => a;
        }
        public Color Gray 
        {
            set => new Color((r+g+b)/3, (r+g+b)/3, (r+g+b)/3);
        }
        
    }
}