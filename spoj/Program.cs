﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests, v1, v2;
            string input;
            string[] inputArr;

            tests = int.Parse(Console.ReadLine());
            
            input = Console.ReadLine();
            inputArr = input.Split(' ');
            v1 = int.Parse(inputArr[0]);
            v2 = int.Parse(inputArr[1]);
            Console.WriteLine((2*v1*v2)/(v1 + v2));
        }
    }
}
