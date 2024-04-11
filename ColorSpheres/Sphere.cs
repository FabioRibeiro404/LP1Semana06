using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private int radius;
        private int numThrown = 0;

        public Sphere(Color color, int radius)
        {
            this.color = color;
            this.radius = radius;

        }

        public int Pop()
        {
            radius = 0;
            return radius;
        }

        public int Thrown()
        {
            if (radius > 0)
            {
                numThrown++;
            }
            return numThrown;
        }
        public int GetTimesThrown()
        {
            return numThrown;
        }
    }
}