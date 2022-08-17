using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompGraphic.Models;
using System;

namespace GraphicTest
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void TestLength()
        {
            Vector vector = new Vector(4, 2, -6);
            double result = Math.Round(vector.Length(), 2);
            Assert.AreEqual(7.48, result);
        }

        [TestMethod]
        public void TestCross()
        {
            Vector v1 = new Vector(1, 4, 2);
            Vector v2 = new Vector(-4, 2, 1);
            Vector expected = new Vector(0, -9, 18);

            Vector result = Vector.Cross(v1, v2);
            Assert.AreEqual(result.X, expected.X);
            Assert.AreEqual(result.Y, expected.Y);
            Assert.AreEqual(result.Z, expected.Z);
        }

        [TestMethod]
        public void TestDot()
        {
            Vector v1 = new Vector(1, 4, 2);
            Vector v2 = new Vector(-4, 2, 1);
            double result = Vector.Dot(v1, v2);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestNormalize()
        {
            Vector v1 = new Vector(1, 4, 2);
            Vector result = v1.Normalize();
            Assert.AreEqual(1, result.Length());
        }
    }
}
