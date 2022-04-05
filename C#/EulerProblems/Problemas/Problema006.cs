using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema006
    {
        public static int GetSquaresSumMinusSquaredSum(int count)
        {
            var range = Enumerable.Range(1, count);
            return range.Sum() * range.Sum() - range.Select(x => x * x).Sum();
        }
    }
}
