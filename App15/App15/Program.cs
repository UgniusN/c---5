using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vardai = { "Beyonce (m)", "David Bowie (v)", "Elvis Costello (v)", "Maddona (m)", "Elton John (v)", "Charles Aznavour (v)" };
            String[] vyrai = new String[20];
            String[] moterys = new String[30];
            int vyrusk = 0;
            int moterusk = 0;
            foreach (string vardas in vardai)
            {
                if (vardas[vardas.Length - 2] == 'm')
                {
                    moterys[moterusk] = vardas;
                    moterusk++;
                }
                if (vardas[vardas.Length - 2] == 'v')
                {
                    vyrai[vyrusk] = vardas;
                    vyrusk++;
                }
            }
            Console.WriteLine("Moterys: ");
            for (int i = 0; i < moterusk; i++)
                Console.Write("{0} ,", moterys[i]);
            Console.WriteLine(); ;
            Console.WriteLine("Vyrai: ");
            for (int i = 0; i < vyrusk; i++)
                Console.Write("{0} ,", vyrai[i]);
            Console.Read();
        }
    }
}
