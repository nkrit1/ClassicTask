using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    public static class CalculationHelp
    {
        public static void SwapEdges<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
