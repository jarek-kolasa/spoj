using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class DwieCyfrySilni
    {
        public string[] DwieCyfrySilniSpoj(int tests, int[] numbers)
        {
            string[] resuts = new string[tests];

            for (int i = 0; i < tests; i++)
            {

                if (numbers[i] >= 10 || numbers[i] < 1)
                {
                    resuts[i] = "0 0";
                }
                else
                {
                    int returnValue = 1;
                    int tens, digits;

                    for (int j = 2; j <= numbers[i]; j++)
                    {
                        returnValue *= j;
                    }

                    digits = returnValue % 10;
                    tens = (returnValue % 100) / 10;

                    resuts[i] =  tens + " " + digits;
                }
            }

            return resuts;
        }
    }
}
