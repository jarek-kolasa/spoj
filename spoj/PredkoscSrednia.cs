using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class PredkoscSrednia
    {
            int v1, v2;
            string[] inputArr;

        public PredkoscSrednia(int input)
        {

            for (int i = 0; i < input; i++)
            {
                inputArr = Console.ReadLine().Split(' ');

                v1 = int.Parse(inputArr[0]);
                v2 = int.Parse(inputArr[1]);

                Console.WriteLine(GetAverageSpeed());
            }
           
        }

    public int GetAverageSpeed()
        {
            return (2 * v1 * v2) / (v1 + v2);
        }
    }
}
