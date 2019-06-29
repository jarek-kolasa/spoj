using System;
using System.Text;

namespace spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());

            for (int i = 0; i < tests; i++)
            {
                string[] inputArrayString = Console.ReadLine().Substring(2).Split(' ');

                for (int j = inputArrayString.Length - 1; j >= 0; j--)
                {
                    Console.Write(inputArrayString[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
