using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(100, 200, 110);
            Color color2 = new Color(100, 100, 100);


            Sphere sphere1 = new Sphere(color1, 4);
            Sphere sphere2 = new Sphere(color2, 6);

            sphere1.Thrown();
            sphere1.Pop();
            sphere1.Thrown();

            sphere2.Thrown();
            sphere2.Thrown();


            Console.WriteLine($"Thrown number: {sphere1.GetTimesThrown()}");

            Console.WriteLine($"Thrown number: {sphere2.GetTimesThrown()}");

        }
    }
}
