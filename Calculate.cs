using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Сalculator
{
    class Calculate
    {
        public static double NumberOne = double.NaN;
        public static double NumberTwo = double.NaN;
        public static string Sign = null;
        public static double Sum()
        {
            return NumberOne + NumberTwo;
        }
        public static double Diff()
        {
            return NumberOne - NumberTwo;
        }
        public static double Multiply()
        {
            return NumberOne * NumberTwo;
        }
        public static double Share()
        {
            return NumberOne / NumberTwo;
        }
        public static void Clear()
        {
            NumberOne = double.NaN;
            NumberTwo = double.NaN;
        }
    }
}
