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
            int[] skaiciai = { 4, 2, 5 };
            int[] skaiciaiDu = { 9, 1, 5 };
            int[] skaiciaiTrys = new int[6];
            for(int i=0; i<skaiciai.Length; i++)
            {
                skaiciaiTrys[i] = skaiciai[i];
            }
            for(int i=0; i<3; i++)
            {
                skaiciaiTrys[i+skaiciai.Length] = skaiciaiDu[i];
            }

            for(int i=0; i<6; i++)
            {
                Console.WriteLine(skaiciaiTrys[i]);
            }
            Console.Read();
        }
    }
}
