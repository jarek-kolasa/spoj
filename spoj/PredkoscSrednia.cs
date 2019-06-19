using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class PredkoscSrednia
    {
            int tests, v1, v2;
            string[] inputArr;

        public PredkoscSrednia(string input)
        {
            inputArr = input.Split(' ');
            tests = inputArr.Length;

            v1 = int.Parse(inputArr[0]);
            v2 = int.Parse(inputArr[1]);
        }

    public int GetAverageSpeed()
        {
            return (2 * v1 * v2) / (v1 + v2);
        }
    }
}
