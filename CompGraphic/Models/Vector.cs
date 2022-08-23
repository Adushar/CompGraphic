using System;
namespace CompGraphic.Models
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector(Point origin, Point end)
        {
            X = end.X - origin.X;
            Y = end.Y - origin.Y;
            Z = end.Z - origin.Z;
        }

        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static Vector Cross(Vector v1, Vector v2)
        {
            double X = v1.Y * v2.Z - v1.Z * v2.Y;
            double Y = v1.Z * v2.X - v1.X * v2.Z;
            double Z = v1.X * v2.Y - v1.Y * v2.X;
            return new Vector(X, Y, Z);
        }
        public static double Dot(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector operator *(double coef, Vector vector)
        {
            return new Vector(vector.X * coef, vector.Y * coef, vector.Z * coef);
        }



        public Vector Normalize()
        {
            double length = this.Length();
            if (length > 0) { return new Vector(X / length, Y / length, Z / length); }

            return this;
        }
    }
}
