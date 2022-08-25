using System;
namespace CompGraphic.Models
{
    public class CameraScreen
    {
        public Point Center { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public CameraScreen(Point center, double width, double height)
        {
            Center = center;
            Width = width;
            Height = height;
        }

        public Point GetPointOnPlane(double x, double y, double max_x, double max_z)
        {
            double x_coef = Width / max_x;
            double z_coef = Height / max_z;
            double trueX = Center.X - (Width / 2) + (x * x_coef);
            double trueZ = Center.Z - (Height / 2) + (y * z_coef);

            return new Point(trueX, Center.Y, trueZ);
        }
    }
}
