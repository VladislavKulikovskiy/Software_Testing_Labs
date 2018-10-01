using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Triangle
    {
        public static bool isExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Exception: triange side can't be less or equals that 0");
            return a + b > c && b + c > a && c + a > b ? true : false;
        }
    }
}
