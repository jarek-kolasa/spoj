using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class Suma
    {
        public Suma()
        {
            string input;
            int sum = 0;

            while ((input=Console.ReadLine()) != null)
            {
                sum += int.Parse(input);
                Console.WriteLine(sum);
            }
        }
    }
}
