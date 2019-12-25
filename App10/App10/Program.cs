using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symboliai = { 'a', 'b', 'c', 'e' };
            foreach(char symbPrint in symboliai)
            {
                Console.Write("{0} ",symbPrint);
            }
            Console.WriteLine();
            for (int i=3; i>=0; i--)
            {
                Console.Write("{0} ", symboliai[i]);
            }

            Console.Read();
        }
    }
}
