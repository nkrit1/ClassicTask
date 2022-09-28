using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    interface ITriangle: IGeometryFigure
    {
        double EdgeA { get; }
        double EdgeB { get; }
        double EdgeC { get; }
    }
}
