using System;
namespace CompGraphic.Models
{
    public class Sphere
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Sphere(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public bool CheckIntersection(Ray ray)
        {
            // t^2*d^2 + 2*t*d*k + k^2 + r^2 = 0
            var k = ray.Origin - Center;

            var d2 = Vector.Dot(ray.Direction, ray.Direction);
            var k2 = Vector.Dot(k, k);
            var r2 = Radius * Radius;

            var a = d2;
            var b = 2 * Vector.Dot(ray.Direction, k);
            var c = k2 - r2;

            var D = b*b - 4*(a * c);
            return D >= 0;
        }
    }
}
