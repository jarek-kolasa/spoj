using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class LiczbyPierwsze
    {
        string[] answer;

        public LiczbyPierwsze(int tests, int[] numbers)
        {
            answer = new string[tests];

            for (int i = 0; i < tests; i++)
            {
                if (isPrime(numbers[i]))
                {
                    Console.WriteLine("TAK");
                    answer[i] = "TAK";
                }
                else
                {
                    Console.WriteLine("NIE");
                    answer[i] = "NIE";
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

        public string[] GetAnswer()
        {
            return answer;
        }
    }
}
