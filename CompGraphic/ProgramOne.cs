using System;
using CompGraphic.Models;

namespace CompGraphic
{
    public class ProgramOne
    {
        public static void Lunch()
        {
            double width = 20;
            double height = 20;
            Camera camera = new Camera(new Point(0, 0, 50), width, height);
            Sphere sphere = new Sphere(new Point(0, 0, 0), 20);

            Console.WriteLine("------------------------");
            for (int y = 0; y < height + 1; y++)
            {
                string raw = "";
                for (int x = 0; x < width + 1; x++)
                {
                    Ray ray = camera.GetRay(x, y, width, height);
                    if (sphere.CheckIntersection(ray)) { raw += "#"; } else { raw += "."; }
                }
                Console.WriteLine(raw);
            }
        }
    }
}
