﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = { 5, 4, 2, 4, 5 };
            foreach(int element in masyvas)
            {
                Console.WriteLine(element);
            }
            Console.Read();
        }
    }
}
