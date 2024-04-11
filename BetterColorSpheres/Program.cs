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

            Color color2 = new Color(currentColor4, currentColor5, currentColor6);

            Sphere sphere1 = new Sphere(color1, 4);
            Sphere sphere2 = new Sphere(color2, 4);

            sphere1.Thrown();
            sphere1.Pop();
            sphere1.Thrown();

            sphere2.Thrown();
            sphere2.Thrown();

            Console.WriteLine($"Thrown number sphere 1: {sphere1.GetTimesThrown()}");

            Console.WriteLine($"Thrown number sphere 2: {sphere2.GetTimesThrown()}");


        }
    }
}
