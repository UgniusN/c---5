using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=10; i++)
            {
                for(int vidSkaic = 1; vidSkaic<=10; vidSkaic++)
                {
                    Console.Write("{0} * {1} = {2} ",i,vidSkaic,i*vidSkaic);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
