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
                string text = Console.ReadLine();
                Przedszkolanka test = new Przedszkolanka();
                Console.WriteLine(test.BringSweets(text));
            }
            
        }
    }
}
