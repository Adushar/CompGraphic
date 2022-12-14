using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompGraphic.Models;
using System;

namespace GraphicTest
{
    [TestClass]
    public class SphereTest
    {
        [TestMethod]
        public void TestCheckInsterectionHappyPath()
        {
            Point p1 = new Point(6, 0, 1);
            Point p2 = new Point(3, 0, 0);
            Ray ray = new Ray(p1, p2);
            Sphere sphere = new Sphere(new Point(-1, 1, 2), 4);

            var result = sphere.GetIntersection(ray);
            Assert.AreEqual(2002, result);
        }

        [TestMethod]
        public void TestCheckInsterectionFailure()
        {
            Point p1 = new Point(6, 0, 1);
            Point p2 = new Point(3, 4, 0);
            Ray ray = new Ray(p1, p2);
            Sphere sphere = new Sphere(new Point(-1, 1, 2), 4);

            var result = sphere.GetIntersection(ray);
            Assert.AreEqual(null, result);
        }
    }
}
