using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_49
{
    class Program
    {
        static void Main(string[] args)
        {
            //1095 - Sequencia IJ 1

            int i = 1;
            int j = 60;

            while (j >= 0)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 5;
            }

            Console.ReadLine();
        }
    }
}
