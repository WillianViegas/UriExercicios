using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_50
{
    class Program
    {
        static void Main(string[] args)
        {
            //1096 - Sequencia IJ 2

            int i = 1;
            int j = 7;

            while (i <= 9)
            {
                for (int k = 1; k <= 3; k++)
                {
                    Console.WriteLine($"I={i} J={j}");
                    j--;
                }


                j = 7;
                i += 2;
            }

            Console.ReadLine();
        }
    }
}
