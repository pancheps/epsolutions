using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema9
    {
        public static int GetPythagoreanTripletsProduct()
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int j = i + 1; j < 1000; j++)
                {
                    var squaredSquares = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                    int k = j;
                    if (Math.Floor(squaredSquares) == Math.Ceiling(squaredSquares))
                    {
                        k = (int)squaredSquares;
                    }
                    if (k > j && i + j + k == 1000)
                    {
                        return i * j * k;
                    }
                }
            }
            return 1;
        }
    }
}
