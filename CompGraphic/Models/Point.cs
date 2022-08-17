using System;
namespace CompGraphic.Models
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point operator +(Vector vector, Point point)
        {
            return new Point(vector.X + point.X, vector.Y + point.Y, vector.Z + point.Z);
        }
        public static Point operator -(Vector vector, Point point)
        {
            return new Point(point.X - vector.X, point.Y - vector.Y, point.Z - vector.Z);
        }
        public static Vector operator -(Point p1, Point p2)
        {
            return new Vector(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }
    }
}
