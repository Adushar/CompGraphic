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

        public Point GetPointOnPlane(double x, double y, double max_x, double max_y)
        {
            double x_coef = Width / max_x;
            double y_coef = Height / max_y;
            double trueX = Center.X - (Width / 2) + (x * x_coef);
            double trueY = Center.Y - (Height / 2) + (y * y_coef);

            return new Point(trueX, trueY, Center.Z);
        }
    }
}
