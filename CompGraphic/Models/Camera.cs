using System;
namespace CompGraphic.Models
{
    public class Camera
    {
        public Point Origin { get; set; }
        public CameraScreen Screen { get; set; }

        public Camera(Point origin, double width, double height)
        {
            Origin = origin;
            Screen = new CameraScreen(new Point(origin.X, origin.Y - 0.5, origin.Z), 1, 1);
        }

        public Ray GetRay(double x, double y, double max_x, double max_y)
        {
            Point screenPoint = Screen.GetPointOnPlane(x, y, max_x, max_y);
            Vector direction = new Vector(Origin, screenPoint).Normalize();
            return new Ray(Origin, direction);
        }
    }
}
