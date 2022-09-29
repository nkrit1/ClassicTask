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


	}
}