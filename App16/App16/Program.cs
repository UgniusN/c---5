using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16
{
    class Program
    {
        static void Main(string[] args)
        {
            string results = "Manchester United 1 Chelsea 0, Arsenal 1 Manchester United 1, Manchester United 3 Fulham 1, Liverpool 2 Manchester United 1, Swansea 2 Manchester United 4";
            int[] komandosPavPozicija = new int[5];
            int[] komandosTaskai = new int[5];
            int[] komandosPriesuTaskai = new int[5];
            int laimejoKartu = 0;
            int praloseKartu = 0;
            int praleistaIvarciu = 0;
            int imustaIvarciu = 0;
            String komanda = "Manchester United";
            int komandosPavIlgis = komanda.Length;
            List<String> matches = new List<string>(results.Split(','));
            foreach (string matchas in matches)
            {
                Console.WriteLine(matchas);
            }

            Console.WriteLine("Suzaista zaidimu: {0},", matches.Count); // parodo kiek zaidimu buvo suzaista

            for (int i = 0; i < matches.Count; i++)
            {
                komandosPavPozicija[i] = matches[i].IndexOf(komanda);
                if (komandosPavPozicija[i] > 3)
                {
                    komandosTaskai[i] = Convert.ToInt32(matches[i][matches[i].Length - 1].ToString());
                    komandosPriesuTaskai[i] = int.Parse(matches[i][komandosPavPozicija[i] - 2].ToString());
                }
                else
                {
                    if(matches[i][0] == ' ')
                    {
                        komandosTaskai[i] = int.Parse(matches[i][komandosPavIlgis + 2].ToString());
                    }
                    else
                    {
                        komandosTaskai[i] = int.Parse(matches[i][komandosPavPozicija[i]+komandosPavIlgis+1].ToString());
                    }
                    komandosPriesuTaskai[i] = int.Parse(matches[i][matches[i].Length - 1].ToString());
                }
                if (komandosTaskai[i] > komandosPriesuTaskai[i])
                {
                    laimejoKartu++;
                }
                if (komandosTaskai[i] < komandosPriesuTaskai[i])
                {
                    praloseKartu++;
                }
                imustaIvarciu += komandosTaskai[i];
                praleistaIvarciu += komandosPriesuTaskai[i];
            }
            Console.WriteLine("Laimejo kartu: {0}", laimejoKartu);
            Console.WriteLine("Pralose kartu: {0}", praloseKartu);
            Console.WriteLine("Ivarciu padare: {0}", imustaIvarciu);
            Console.WriteLine("Ivarciu praleido: {0}", praleistaIvarciu);
            Console.Read();
        }
    }
}
