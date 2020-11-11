using System;


namespace spoj
{
    public class LiczbyPierwsze
    {
        public LiczbyPierwsze()
        {
            int n = int.Parse(Console.ReadLine());

            int number;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (isPrime(number))
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
            }

        }

        public bool isPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
