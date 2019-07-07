using System;
using System.Text;

namespace spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            NowaDzialka dzialka = new NowaDzialka();

            for (int i = 0; i < tests; i++)
            {
                int dim = int.Parse(Console.ReadLine());
                Console.WriteLine(dzialka.GetArea(dim));
            }
        }
    }
}
