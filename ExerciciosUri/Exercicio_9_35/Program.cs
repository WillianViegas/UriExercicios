using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_35
{
    class Program
    {
        static void Main(string[] args)
        {
            //1059 - Números Pares

            int i;
            for (i = 1; i <= 100; i++)
            {
                int resto = i % 2;

                if (resto == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
