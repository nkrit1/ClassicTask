using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    public class Triangle : ITriangle
    {
        public const double eps = Const.Eps;
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            /// <exception cref="ArgumentException"></exception>
            if (edgeA < eps)
                throw new ArgumentException("Неверное значение для стороны.", nameof(edgeA)); 
            if (edgeB < eps)
                throw new ArgumentException("Неверное значение для стороны.", nameof(edgeB)); 
            if (edgeC < eps)
                throw new ArgumentException("Неверное значение для стороны.", nameof(edgeA)); 

            double maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
            double perimeter = edgeA + edgeB + edgeC;
            if ((perimeter - maxEdge) - maxEdge < eps)
             throw new ArgumentException("Длина наибольшей стороны трешуольника не может быть больше суммы двух других сторон.", nameof(maxEdge));

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            _isRightTriangle = CheckIsRightTriangle();
        }

        private readonly bool _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle;


        public double CalculateSquare()
        {
            var halfPerimeter = (EdgeA + EdgeB + EdgeC) / 2d;
            return Math.Sqrt(halfPerimeter * 
                (halfPerimeter - EdgeA) * 
                (halfPerimeter - EdgeB) * 
                (halfPerimeter - EdgeC));

        }


        public bool CheckIsRightTriangle()
        {
            double maxEdge = EdgeA, b = EdgeB, c = EdgeC;

            if (b - maxEdge > Const.Eps)
            {
                CalculationHelp.SwapEdges(ref maxEdge, ref b);
            }
            if (c - maxEdge > Const.Eps)
            {
                CalculationHelp.SwapEdges(ref maxEdge, ref c);
            }

            return Math.Abs(Math.Pow(maxEdge, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < Const.Eps;
        }


    }
}
