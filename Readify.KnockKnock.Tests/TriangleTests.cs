using Microsoft.VisualStudio.TestTools.UnitTesting;
using Readify.KnockKnock.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.KnockKnock.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CheckTringle_EquiLength()
        {
            int a = 5, b = 5, c = 5;

            Triangle triangle = new Triangle();
            TriangleType triangleType = triangle.CheckTriangleType(a, b, c);

            Assert.AreEqual(TriangleType.Equilateral, triangleType);
        }
        [TestMethod]
        public void CheckTringle_NotValidTriangle_With0()
        {
            int a = 5, b = 5, c = 0;

            Triangle triangle = new Triangle();
            TriangleType triangleType = triangle.CheckTriangleType(a, b, c);

            Assert.AreEqual(TriangleType.Error, triangleType);
        }
        [TestMethod]
        public void CheckTringle_NotValidTriangle_WithNegative()
        {
            int a = 5, b = -3, c = 5;

            Triangle triangle = new Triangle();
            TriangleType triangleType = triangle.CheckTriangleType(a, b, c);

            Assert.AreEqual(TriangleType.Error, triangleType);
        }
        [TestMethod]
        public void CheckTringle_NotValidTriangle_WithSideGreaterThanOtherSides()
        {
            int a = 5, b = 6, c = 20;

            Triangle triangle = new Triangle();
            TriangleType triangleType = triangle.CheckTriangleType(a, b, c);

            Assert.AreEqual(TriangleType.Error, triangleType);
        }

        [TestMethod]
        public void CheckTringle_NotEqualSides()
        {
            int a = 5, b = 6, c = 7;

            Triangle triangle = new Triangle();
            TriangleType triangleType = triangle.CheckTriangleType(a, b, c);

            Assert.AreEqual(TriangleType.Scalene, triangleType);
        }

        [TestMethod]
        public void CheckTringle_HasTwoSideEqual()
        {
            int a = 6, b = 6, c = 7;

            Triangle triangle = new Triangle();
            TriangleType triangleType = triangle.CheckTriangleType(a, b, c);

            Assert.AreEqual(TriangleType.Isosceles, triangleType);
        }
    }
}
