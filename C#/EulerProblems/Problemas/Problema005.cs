using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema005
    {
        public static int GetSmallestEvenlyDivisible(int n)
        {
            List<int> numberList = Enumerable.Range(1, n).ToList();
            List<int> evenDividers = new(numberList);
            int mult = 1;
            int div = 2;
            while (numberList.Count != numberList.Sum())
            {
                numberList = numberList.Select(_ => _ = _ % div == 0 ? _ / div : _).ToList();
                if (numberList.Sum() == evenDividers.Sum())
                {
                    div++;
                }
                else
                {
                    mult *= div;
                    evenDividers = new(numberList);
                }
            }
            return mult;
        }
    }
}
