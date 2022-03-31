using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema1
    {
        public static int GetMultiplesSum(int num)
        {
            return Enumerable.Range(1, num - 1).Where(_ => _ % 3 == 0 || _ % 5 == 0).Sum();
        }
    }
}
