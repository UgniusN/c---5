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
            char[] symboliai = { 'b', 'z', 'e', 'r' };
            foreach(char symbPrint in symboliai)
            {
                Console.Write("{0} ",symbPrint);
            }
            Console.WriteLine();
            for (int i=symboliai.Length-1; i>=0; i--)
            {
                Console.Write("{0} ", symboliai[i]);
            }

            Array.Sort(symboliai);
            foreach (char symbPrint in symboliai)
            {
                Console.Write("{0} ", symbPrint);
            }
            Console.Read();
        }
    }
}
