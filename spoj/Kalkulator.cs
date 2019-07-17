using System;

namespace spoj
{
    public class Kalkulator
    {
            int result;

        public void Calculate(string inputText)
        {

            string[] stringArr = inputText.Split(' ');
            int a = int.Parse(stringArr[1]);
            int b = int.Parse(stringArr[2]);

            if (stringArr[0].Equals("+"))
            {
                result = a + b;
                Console.WriteLine(a + b);
            }
            else if (stringArr[0].Equals("-"))
            {
                result = a - b;
                Console.WriteLine(a - b);
            }
            else if (stringArr[0].Equals("*"))
            {
                result = a * b;
                Console.WriteLine(a * b);
            }
            else if (stringArr[0].Equals("/"))
            {
                result = a / b;
                Console.WriteLine(a / b);
            }
            else if (stringArr[0].Equals("%"))
            {
                result = a % b;
                Console.WriteLine(a % b);
            }
        }

        public int GetResult()
        {
            return result;
        }

        public void SetResult(int newResult)
        {
            result = newResult;
        }
    }
}
