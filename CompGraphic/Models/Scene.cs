using System;
namespace CompGraphic.Models
{
    public class Scene
    {
        public Sphere Sphere { get; set; }
        public DirectionalLight Light { get; set; }

        public Scene()
        {
        }
    }
}
