using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema8
    {
        public static long Largest13Product(string number, int taken)
        {
            long result = 0;
            number = number.Replace("\r\n", string.Empty);
            for (int i = 0; i < number.Length - taken; i++)
            {
                var currentMult = number.Substring(i, taken).ToList().Aggregate(1L, (current, next) => long.Parse(current.ToString()) * long.Parse(next.ToString()));
                result = currentMult > result ? currentMult : result;
            }
            return result;
        }
    }
}
