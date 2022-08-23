using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompGraphic.Models;
using System;

namespace GraphicTest
{
    [TestClass]
    public class RayTest
    {
        [TestMethod]
        public void TestAtDistance()
        {
            Ray ray = new Ray(new Point(1, 2, 3), new Vector(0, 1, 0));
            Point result = ray.atDistance(3);
            Assert.AreEqual(1, result.X);
            Assert.AreEqual(5, result.Y);
            Assert.AreEqual(3, result.Z);
        }
    }
}
