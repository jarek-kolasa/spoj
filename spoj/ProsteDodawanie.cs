using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    class ProsteDodawanie
    {
        public ProsteDodawanie()
        {
            int tests = int.Parse(Console.ReadLine());
            int[] results = new int[tests];

            for (int i = 0; i < tests; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                int[] textArray = new int[numbers];
                string valuesString = Console.ReadLine();
                string[] stringArray = valuesString.Split(' ');
                textArray = Array.ConvertAll<string, int>(stringArray, int.Parse);
                Array.ForEach(textArray, delegate (int k) { results[i] += k; });
            }

            for (int i = 0; i < tests; i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}
