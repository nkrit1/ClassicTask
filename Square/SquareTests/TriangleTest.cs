using NUnit.Framework;
using System;
using Square;

namespace SquareTests
{
    class TriangleTest
    {
        [Test]
        public void InitNotTriangle()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 6));
        }

        [TestCase(0, 0, 0)]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void InitErrorTriangle(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void InitTriangleTest()
        {
            // Arrange.
            double a = 3d, b = 4d, c = 5d;

            // Act.
            var triangle = new Triangle(a, b, c);

            // Assert.
            Assert.NotNull(triangle);
            Assert.Less(Math.Abs(triangle.EdgeA - a), Const.Eps);
            Assert.Less(Math.Abs(triangle.EdgeB - b), Const.Eps);
            Assert.Less(Math.Abs(triangle.EdgeC - c), Const.Eps);
        }

        [Test]
		public void CalculateSquareTest()
        {
            // Arrange.
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            // Act.
            var square = triangle?.CalculateSquare();

            // Assert.
            Assert.NotNull(square);
            Assert.Less(Math.Abs(square.Value - result), Const.Eps);
        }



        [TestCase(3, 4, 3, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5.00000000001, ExpectedResult = true)]
        public bool NotRightTriangle(double a, double b, double c)
        {
            // Arrange.
            var triangle = new Triangle(a, b, c);

            // Act.
            var isRight = triangle.IsRightTriangle;

            // Assert. 
            return isRight;
        }


    }
}
