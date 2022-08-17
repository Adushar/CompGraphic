using System;
namespace CompGraphic.Models
{
    public class Ray
    {
        public Point Origin { get; set; }
        public Vector Direction { get; set; }

        public Ray(Point origin, Vector direction)
        {
            Origin = origin;
            Direction = direction.Normalize();
        }

        public Ray(Point p1, Point p2)
        {
            Origin = p1;
            Direction = new Vector(p1, p2);
        }
    }
}
