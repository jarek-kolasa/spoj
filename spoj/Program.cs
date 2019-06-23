using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            int a, b;

            for (int i = 0; i < tests; i++)
            {
                string numbers = Console.ReadLine();
                a = int.Parse(numbers.Split(' ')[0]);
                b = int.Parse(numbers.Split(' ')[1]);
                Console.WriteLine(GreatestCommonDivisor(a, b));
            }
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            if (b != 0)
            {
                return GreatestCommonDivisor(b, a % b);
            }
            return a;
        }
    }
}
