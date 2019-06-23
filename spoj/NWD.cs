using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class NWD
    {
        int[] divisors;

        public NWD(int testQuantity, string[] numbersArrStr)
        {
            divisors = new int[testQuantity];

            for (int i = 0; i < testQuantity; i++)
            {
                int a = int.Parse(numbersArrStr[i].Split(' ')[0]);
                int b = int.Parse(numbersArrStr[i].Split(' ')[1]);
                divisors[i] = GreatestCommonDivisor(a, b);
                Console.WriteLine(GreatestCommonDivisor(a, b));
            }
        }

        public int GreatestCommonDivisor(int a, int b)
        {
            if (b!=0)
            {
                return GreatestCommonDivisor(b, a%b);
            }
            return a;
        }

        public int[] GetDeivsors()
        {
            return divisors;
        }
    }
}
