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
            int number;

            for (int i = 0; i < tests; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (isPrime(number))
                {
                    Console.WriteLine("TAK");
                } else
                {
                Console.WriteLine("NIE");
                }
            }
        }

        private static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
