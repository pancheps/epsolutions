using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema3
    {
        public static long GetLargestPrimeLong(long num)
        {
            long biggestPrime = 0;
            for (long i = 1; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    if (IsPrime(i))
                    {
                        biggestPrime = i;
                    }
                }
            }
            return biggestPrime;
        }

        private static bool IsPrime(long num)
        {
            long counter = 0;
            for (long i = 1; i < Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    counter++;
                }
                if (counter > 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static int GetLargestPrimeInt(int num)
        {
            return Enumerable.Range(1, num).Select(individual => Enumerable.Range(1, (int)Math.Sqrt(individual)).Where(_ => _ % 2 != 0 || _ == 2).Aggregate(0, (accumulator, next) => individual % next == 0 ? accumulator += next : accumulator)).ToList().LastIndexOf(1) + 1;
        }
    }
}
