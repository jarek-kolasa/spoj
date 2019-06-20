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

            for (int i = 0; i < tests; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 10)
                {
                    Console.WriteLine("0 0");
                } else
                {
                long returnValue = 1;
                long tens, digits;
               
                    for (int j = 2; j <= number; j++)
                    {
                        returnValue *= j;
                    }

                digits = returnValue % 10;
                tens = (returnValue % 100) / 10;

                Console.WriteLine("{0} {1}", tens, digits);
                }
            }
        }
    }
}
