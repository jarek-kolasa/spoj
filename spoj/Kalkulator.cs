using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class Kalkulator
    {
        public void Calculate(string inputText)
        {

            string[] stringArr = inputText.Split(' ');
            int a = int.Parse(stringArr[1]);
            int b = int.Parse(stringArr[2]);

            if (stringArr[0].Equals("+"))
            {
                Console.WriteLine(a + b);
            }
            else if (stringArr[0].Equals("-"))
            {
                Console.WriteLine(a - b);
            }
            else if (stringArr[0].Equals("*"))
            {
                Console.WriteLine(a * b);
            }
            else if (stringArr[0].Equals("/"))
            {
                Console.WriteLine(a / b);
            }
            else if (stringArr[0].Equals("%"))
            {
                Console.WriteLine(a % b);
            }
        }
    }
}
