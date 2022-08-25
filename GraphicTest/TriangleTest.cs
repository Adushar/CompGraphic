using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompGraphic.Models;
using System;

namespace GraphicTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestCheckInsterectionHappyPath()
        {
            Ray ray = new Ray(new Point(2, 2, 5), new Point(0, 0, 2));
            Triangle triangle = new Triangle(new Point(-2, 2, 0), new Point(-2, -3, 0), new Point(2, 2, 0));

            var result = triangle.GetIntersection(ray);
            Assert.AreEqual(1.6, result);
        }

        [TestMethod]
        public void TestCheckInsterectionFailure()
        {
            Ray ray = new Ray(new Point(2, 2, 5), new Point(0, -2, 2));
            Triangle triangle = new Triangle(new Point(-2, 2, 0), new Point(-2, -3, 0), new Point(2, 2, 0));

            var result = triangle.GetIntersection(ray);
            Assert.AreEqual(null, result);
        }
    }
}
