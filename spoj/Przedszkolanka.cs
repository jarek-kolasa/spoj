using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class Przedszkolanka
    {
        public int BringSweets(string input)
        {
            string[] inputArr = input.Split(' ');
            int value1 = int.Parse(inputArr[0]);
            int value2 = int.Parse(inputArr[1]);

            int nwd = Nwd(value1, value2);

            return (value1*value2)/nwd;
        }

        private int Nwd(int a, int b)
        {
            if (b != 0)
            {
                return Nwd(b, a%b);
            }
            return a;
        }
    }
}
