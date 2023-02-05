using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOPerations
{
    static class MathS
    {
        static public int Add(int x, int y)
        {
            return x + y;
        }

        static public int Subtract(int x, int y)
        {
            return x - y;
        }

        static public int Multiply(int x, int y)
        {
            return x * y;
        }

        //static public bool Dividable(int x, int y)
        //{
        //    if(y != 0){
        //        return false;
        //    }
        //    return true;
        //}

        static public bool Divide(int x, int y , out double result)
        {
            if (y != 0)
            {
                result = (double)x / y;
                return true;
            }
            result = default;
            return false;
        }
    }
}
