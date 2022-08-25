using System;
namespace CompGraphic.Models
{
    public interface SceneElement
    {
        public Vector Normal(Point point);
        public double? GetIntersection(Ray ray);
    }
}
