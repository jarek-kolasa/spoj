using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class Samolot
    {
        public int GetSits(string input)
        {
            string[] inputArr = input.Split(' ');

            int rowsBuiss = int.Parse(inputArr[0]);
            int colBuiss = int.Parse(inputArr[1]);
            int rowsEconomic = int.Parse(inputArr[2]);
            int colEconomic = int.Parse(inputArr[3]);

            return rowsBuiss * colBuiss + rowsEconomic * colEconomic;
        }
    }
}
