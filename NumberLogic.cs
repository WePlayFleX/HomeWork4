using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class NumberLogic
    {
        public static int NumberSum(int number)
        {
            int result = 0;
            foreach (char c in number.ToString())
            {
                result += (int)c - 48;
            }
            return result;
        }

        public static int NumberProd(int number)
        {
            int result = 1;
            foreach (char c in number.ToString())
            {
                result *= (int)c - 48;
            }
            return result;
        }
    }
}
