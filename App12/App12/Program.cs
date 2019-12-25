using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[100];
            Random rand = new Random();
            for(int i=0; i<100; i++)
            {
                skaiciai[i] = rand.Next();
            }

            Console.WriteLine("MIN: {0} , MAX: {1}",skaiciai.Min() , skaiciai.Max());
            Console.Read();
        }
    }
}
