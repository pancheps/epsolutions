using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Problemas
{
    internal class Problema4
    {
        public static int GetLargestPalindrome3x3()
        {
            var palindrome = 1;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int res = i * j;
                    if (IsPalindrome(res) && res > palindrome)
                    {
                        palindrome = res;
                        Console.WriteLine($"Palindrome: {palindrome}");
                    }
                    Console.WriteLine(res);
                }
            }
            return palindrome;
        }

        private static bool IsPalindrome(int num)
        {
            string str = num.ToString();
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return str == new string(charArray);
        }
    }
}
