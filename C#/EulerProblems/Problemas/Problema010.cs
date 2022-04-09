using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema010
    {
        public static long SumPrimesBelow(int number)
        {
            long sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += IsPrime(i) ? i : 0;
            }
            return sum;
        }

        private static bool IsPrime(int testNum)
        {
            var count = 0;
            if (testNum == 2)
                return true;
            if (testNum == 1 || testNum % 2 == 0)
                return false;
            for (int i = 1; i <= (int)Math.Sqrt(testNum); i += 2)
            {
                if (testNum % i == 0)
                {
                    count++;
                }
            }
            return count == 1;
        }
    }
}
