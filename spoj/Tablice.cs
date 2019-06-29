using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class Tablice
    {
        public string CalculateTablice(string inputString)
        {
            string[] inputArrayString = inputString.Split(' ');
            int[] array = new int[inputArrayString.Length-1];
            int[] newArray = new int[inputArrayString.Length - 1];
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < inputArrayString.Length-1; i++)
            {
                array[i] = int.Parse(inputArrayString[i + 1]);
            }

            for (int i = 0, j= array.Length-1; i < array.Length ; i++, j--)
            {
                newArray[i] = array[j];
                builder.Append(newArray[i]).Append(" ");
            }

            return builder.ToString().Trim();
        }
    }
}
