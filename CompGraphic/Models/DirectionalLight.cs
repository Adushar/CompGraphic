using System;
namespace CompGraphic.Models
{
    public class DirectionalLight
    {
        public Vector Direction { get; set; }

        public DirectionalLight(Vector direction)
        {
            Direction = direction.Normalize();
        }

        public DirectionalLight(Point p1, Point p2)
        {
            Direction = new Vector(p1, p2).Normalize();
        }

        public double GetLightingOf(SceneElement element, Point point)
        {
            return Vector.Dot(element.Normal(point), Direction);
        }
    }
}
