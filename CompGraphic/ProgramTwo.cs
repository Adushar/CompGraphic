using System;
using System.Collections.Generic;
using CompGraphic.Models;

namespace CompGraphic
{
    public class ProgramTwo
    {
        public static void Lunch()
        {
            int width = 600;
            int height = 600;
            Camera camera = new Camera(new Point(0, 0, 30), width, height);
            DirectionalLight light = new DirectionalLight(new Point(50, 50, 50), new Point(0, 0, 0));
            Triangle triangle = new Triangle(new Point(50, 100, -15), new Point(-180, 50, 10), new Point(-100, -200, 0));
            Triangle triangle2 = new Triangle(new Point(-200, -100, 200), new Point(-180, 50, 10), new Point(-100, -200, 0));

            List<SceneElement> sceneElements = new List<SceneElement>();
            sceneElements.Add(triangle);
            sceneElements.Add(triangle2);
            Scene scene = new Scene(sceneElements, light, camera);
            double[][] result = scene.renderScene(width, height);

            Utils.PpmWriter.Write(result);
        }
    }
}
