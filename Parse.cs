using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Сalculator
{
    static class Parse
    {
        public static bool CheckSeparator(string str)
        {
            if (str.Length == 0 || str.Split(',').Length - 1 == 1)
                return false;
            return true;
        }
        public static bool CheckDiff(string str)
        {
            if (str.Length == 0)
                return true;
            return false;
        }
    }
}
