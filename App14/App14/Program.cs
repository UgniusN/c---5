using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vardaiPradinis = { "Ugnius", "Rimas", "Andrius", "Tomas", "Gvidas", "Daniele", "Robertas", "Domantas", "Antanas", "Jonas" };
            String[] vardaiAntras = new String[20];

            int skaicius = 0;
            int vardoPozicija = 0;
            foreach(string vardas in vardaiPradinis)
            {
                if (skaicius == 4 || skaicius == 6)
                {
                    skaicius++;
                    continue;
                }
                vardaiAntras[vardoPozicija] = vardaiPradinis[skaicius];
                skaicius++;
                vardoPozicija++;
                Console.WriteLine("{0} {1} {2}",skaicius,vardoPozicija,vardas);
            }

            Console.Read();
        }
    }
}
