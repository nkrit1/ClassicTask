using NUnit.Framework;
using System;
using Square;

namespace SquareTests
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

		[Test]
		public void IsRadiusNegativeTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(-1d));
		}

		[Test]
		public void IsLessMinRadiusTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(Circle.MinRadius - 1e7));
		}

		[Test]
		public void IsRadiusZeroTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(0d));
		}

		[Test]
		public void CalculateSquareTest()
		{
			var radius = 5;
			var circle = new Circle(radius);
			var expectedValue = Math.PI * Math.Pow(radius, 2d);

			var square = circle.CalculateSquare();

			Assert.NotNull(square);
			Assert.Less(Math.Abs(square - expectedValue), Const.Eps);
		}
	}
}