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
            int[] skaiciai = new int[5];
            String a;

            Console.WriteLine("Iveskite penkis kintamuosius");
            for(int i=0; i<5; i++)
            {
                a = Console.ReadLine();
                skaiciai[i] = Convert.ToInt32(a);
            }

            int[] skaiciuKopija = skaiciai;

            foreach(int skaicius in skaiciuKopija)
            {
                Console.Write("{0} ", skaicius);
            }

            Console.Read();
        }
    }
}
