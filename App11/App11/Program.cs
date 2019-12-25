using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            String manoVardas = "Ugnius";

            foreach (char raide in manoVardas)
            {
                Console.Write("{0} ", raide);
            }

            Console.WriteLine();

            for (int i=manoVardas.Length-1; i>=0; i--)
            {
                Console.Write("{0} ", manoVardas[i]);
            }

            Console.Read();
        }
    }
}
