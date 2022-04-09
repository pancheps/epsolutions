using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema044
    {
        public static long GetMinimumPentagonalDifference()
        {
            long difference = long.MaxValue;
            long newDifference = difference;
            var pentagonals = Enumerable.Range(1, 2).Select(_ => GetPentagonalNumberFrom(_)).ToList();
            while (true)
            {
                for (int i = pentagonals.Count; i > 1; i--)
                {
                    long sum = pentagonals.Last() + pentagonals.ElementAt((Index)(i - 2));
                    long diff = Math.Abs(pentagonals.Last() - pentagonals.ElementAt((Index)(i - 2)));
                    if (IsPentagonalNumber(sum) && 
                        pentagonals.Contains(diff))
                    {
                        if (Math.Abs(pentagonals.Last() - pentagonals.ElementAt((Index)(i - 2))) < difference)
                        {
                            return Math.Abs(pentagonals.Last() - pentagonals.ElementAt((Index)(i - 2)));
                        }
                    }
                }
                pentagonals.Add(GetPentagonalNumberFrom(pentagonals.Count + 1));
            }
        }

        private static long GetPentagonalNumberFrom(long n)
        {
            return n * (3 * n - 1) / 2;
        }

        private static bool IsPentagonalNumber(long n)
        {
            var sol = (1 + Math.Sqrt(1 + 24 * n)) / 6;
            return Math.Floor(sol) == Math.Ceiling(sol);
        }
    }
}
