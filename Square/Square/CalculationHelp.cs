using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    public static class CalculationHelp
    {
        public static void SwapEdges(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

    }
}
