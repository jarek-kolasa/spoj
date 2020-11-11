using System;

namespace spoj
{
    class ProsteDodawanie
    {
        public ProsteDodawanie()
        {
            int t, n;

            t = int.Parse(Console.ReadLine());

            int[] tests = new int[t];

            for (int i = 1; i <= t; i++)
            {
                n = int.Parse(Console.ReadLine());

                string texttemp = Console.ReadLine();

                string [] arr = (texttemp.Split(' '));

                int sum = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    sum += int.Parse(arr[j]);
                }

                tests[i-1] = sum;
            }

            for (int i = 0; i < tests.Length; i++)
            {
            Console.WriteLine(tests[i].ToString());
            }
        }
    }
}
