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
            DirectionalLight light = new DirectionalLight(new Point(50, 50, 50), new Point(0, 0, 0));
            Sphere sphere = new Sphere(new Point(0, 0, 0), 20);

            Console.WriteLine("------------------------");
            for (int y = 0; y < height + 1; y++)
            {
                string raw = "";
                for (int x = 0; x < width + 1; x++)
                {
                    Ray ray = camera.GetRay(x, y, width, height);
                    double? intersection = sphere.GetIntersection(ray);
                    if (intersection == null) {
                        raw += " ";
                        continue;
                    }

                    Point intersectionPoint = ray.atDistance((double)intersection);
                    double lightCoef = light.GetLightingOf(sphere, intersectionPoint);
                    if (lightCoef < 0) { raw += " "; }
                    else if (lightCoef < 0.2) { raw += "."; }
                    else if (lightCoef < 0.5) { raw += "*"; }
                    else if (lightCoef < 0.8) { raw += "O"; }
                    else { raw += "#"; }

                }
                Console.WriteLine(raw);
            }
        }
    }
}
