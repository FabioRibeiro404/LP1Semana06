using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color c1 = new Color(100, 100, 100);
            int currentColor1 = c1.Red;
            int currentColor2 = c1.Green;
            int currentColor3 = c1.Blue;

            Color color1 = new Color(currentColor1, currentColor2, currentColor3);

            Color c2 = new Color(100, 200, 200);
            int currentColor4 = c2.Red;
            int currentColor5 = c2.Green;
            int currentColor6 = c2.Blue;

            Sphere sphere = new Sphere();

        }
    }
}
