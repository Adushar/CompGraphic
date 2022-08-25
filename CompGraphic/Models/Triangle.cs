using System;
namespace CompGraphic.Models
{
    public class Triangle : SceneElement
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Vector AB { get; set; }
        public Vector AC { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            AB = B - A;
            AC = C - A;
        }

        public double? GetIntersection(Ray ray)
        {
            
            Vector normal = Vector.Cross(ray.Direction, AC);
            double d = Vector.Dot(AB, normal);
            if (Math.Abs(d) < Double.Epsilon) { return null; }

            double inverted_d = 1.0 / d;
            Vector ao = ray.Origin - A;
            double u_point = Vector.Dot(ao, normal) * inverted_d;
            if (u_point < 0 || u_point > 1) { return null; }

            Vector aoXab = Vector.Cross(ao, AB);
            double v_point = Vector.Dot(ray.Direction, aoXab) * inverted_d;
            if (v_point < 0 || u_point + v_point > 1) { return null; }

            double result = Vector.Dot(AC, aoXab) * inverted_d;
            if (result <= Double.Epsilon) { return null; }

            return result;
        }

        public Vector Normal(Point point)
        {
            return Vector.Cross(AB, AC).Normalize();
        }
    }
}
