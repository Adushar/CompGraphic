using System;
using System.Collections.Generic;
using CompGraphic.Models;
using CompGraphic.Utils;

namespace CompGraphic
{
    public class ProgramTwo
    {
        public static void Lunch()
        {
            int width = 600;
            int height = 600;
            Camera camera = new Camera(new Point(0, 1, 0), width, height);
            DirectionalLight light = new DirectionalLight(new Point(50, 50, 50), new Point(0, 0, 0));

            List<SceneElement> sceneElements = new List<SceneElement>();
            ObjFileParser fileParser = new ObjFileParser(@"/Users/a1/Projects/CompGraphic/CompGraphic/Resources/cow.obj");
            foreach (Triangle triangle in fileParser.getTriangles()) { sceneElements.Add(triangle); }
            
            Scene scene = new Scene(sceneElements, light, camera);
            double[][] result = scene.renderScene(width, height);

            Utils.PpmWriter.Write(result);
        }
    }
}
