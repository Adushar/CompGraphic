using System;
using System.Collections.Generic;

namespace CompGraphic.Models
{
    public class Scene
    {
        public List<SceneElement> SceneElements { get; set; }
        public DirectionalLight Light { get; set; }
        public Camera Camera { get; set; }

        public Scene(List<SceneElement> scene_elements, DirectionalLight light, Camera camera)
        {
            SceneElements = scene_elements;
            Light = light;
            Camera = camera;
        }

        public double[][] renderScene(int height, int width)
        {
            double[][] result = new double[height][];
            for (int y = 0; y < height; y++)
            {
                double[] raw = new double[width];
                for (int x = 0; x < width; x++)
                {
                    Ray ray = Camera.GetRay(x, y, width, height);

                    var intersectionResult = getIntersection(ray);
                    double? intersection = intersectionResult.Item1;
                    SceneElement? intersectionElement = intersectionResult.Item2;
                    if (intersection == null) { raw[x] = 0; continue; }

                    Point intersectionPoint = ray.atDistance((double)intersection);
                    double lightCoef = Math.Abs(Light.GetLightingOf(intersectionElement, intersectionPoint));
                    raw[x] = lightCoef;

                }
                result[y] = raw;
            }

            return result;
        }

        private (double?, SceneElement?) getIntersection(Ray ray)
        {
            double? closestIntersection = null;
            SceneElement? closestSceneElement = null;
            foreach (SceneElement scene_element in SceneElements)
            {
                double? intersection = scene_element.GetIntersection(ray);
                if (intersection != null && (closestIntersection == null || intersection < closestIntersection)) {
                    closestIntersection = intersection;
                    closestSceneElement = scene_element;
                }
            }

            return (closestIntersection, closestSceneElement);
        }
    }
}
