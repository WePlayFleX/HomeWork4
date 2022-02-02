using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Subsequence
    {
        public static bool AscendingSequence(int number)
        {
            return (number / 1000 < (number % 1000) / 100) 
                && ((number % 1000) / 100 < (number % 100) / 10)
                && ((number % 100) / 10 < number % 10);
        }
    }
}
