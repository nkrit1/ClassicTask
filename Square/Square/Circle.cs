using System;

namespace Square
{
    class Circle: IGeometryFigure
    {
        public const double MinRadius = 1e-8;
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius - MinRadius < Const.Eps)
                throw new ArgumentException("Радиус круга не может быть столь мал", nameof(radius));
            Radius = radius;
        }
        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d); 
        }
    }
}
