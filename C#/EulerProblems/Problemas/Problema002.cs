
namespace EulerProblems.Problemas
{
    internal class Problema2
    {
        public static int GetFibonacciEvenSum(int num)
        {
            var numbers = new List<int>();
            int item = default;
            while (item < 4e6)
            {
                item = numbers.Count switch
                {
                    0 => 1,
                    1 => 2,
                    _ => numbers[numbers.Count - 1] + numbers[numbers.Count - 2]
                };
                numbers.Add(item);
            }
            return numbers.Where(_ => _ % 2 == 0).Sum();
        }
    }
}
