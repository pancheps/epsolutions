using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema007
    {
        public static int GetNthPrime(int n)
        {
            var count = 0;
            var currentNumber = 1;
            while (count < n)
            {
                if (IsPrime(++currentNumber))
                {
                    count++;
                }
            }
            return currentNumber;
        }

        private static bool IsPrime(int n)
        {
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
