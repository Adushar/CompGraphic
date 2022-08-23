using System;
namespace CompGraphic.Models
{
    public class Sphere : SceneElement
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Sphere(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public double? GetIntersection(Ray ray)
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
            if (D < 0) { return null; }

            var D2 = D * D;
            var t1 = (-b - D2) / (2*a);
            var t2 = (-b + D2) / (2*a);

            if (t1 >= 0 && t2 >= 0) {
                return Math.Min(t1, t2);
            } else if (t1 >= 0) {
                return t1;
            } else if (t2 >= 0) {
                return t2;
            } else {
                return null;
            }
        }

        public Vector Normal(Point point)
        {
            return new Vector(Center, point).Normalize();
        }
    }
}
