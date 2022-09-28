using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    class Triangle : ITriangle
    {
        public const double eps = Const.Eps;
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            /// <exception cref="ArgumentException"></exception>
            if (EdgeA < eps)
            { throw new ArgumentException("Неверное значение для стороны.", nameof(edgeA)); }
            if (EdgeB < eps)
            { throw new ArgumentException("Неверное значение для стороны.", nameof(edgeB)); }
            if (EdgeC < eps)
            { throw new ArgumentException("Неверное значение для стороны.", nameof(edgeA)); }

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            double maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
            double perimeter = CalculatePerimeter(edgeA, edgeB, edgeC);
            if (perimeter - maxEdge < maxEdge + eps)
            { throw new ArgumentException("Длина наибольшей стороны трешуольника не может быть больше суммы двух других сторон.", nameof(maxEdge)); }
        }
        
        private double CalculatePerimeter(double edgeA, double edgeB, double edgeC)
        {
            return (edgeA + edgeB + edgeC);
        }

        public double CalculateSquare()
        {
            var halfPerimeter = CalculatePerimeter(EdgeA, EdgeB, EdgeC)/2d;
            return Math.Sqrt(halfPerimeter*(halfPerimeter - EdgeA) *(halfPerimeter - EdgeB) *(halfPerimeter - EdgeC));
        }

        
    }
}
