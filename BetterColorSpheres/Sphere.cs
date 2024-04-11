using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
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
        public int Radius
        {
            get => radius;
            set => radius = value;
        }
        public Color BallColor
        {
            get => color;
            set => color = value;
        }
        public int NumberOfThrown
        {
            get => numThrown;
            set => numThrown = value;
        }

        public int Thrown()
        {
            if(radius > 0)
            {
                numThrown++;
            }
            return numThrown;
        }

        public int Pop()
        {
            radius = 0;
            return radius;
        }
        public int GetTimesThrown()
        {
            return numThrown;
        }
    }
}