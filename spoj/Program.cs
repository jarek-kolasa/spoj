using System;
using System.Text;

namespace spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Kalkulator kalkulator = new Kalkulator();

            while ((input = Console.ReadLine()) != null)
            {
                kalkulator.Calculate(input);
            }
        }
    }
}
