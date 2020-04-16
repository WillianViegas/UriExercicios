using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_30
{
    class Program
    {
        static void Main(string[] args)
        {
            //1046 - Tempo de Jogo

            string[] horas = Console.ReadLine().Split(' ');

            int h1 = Convert.ToInt32(horas[0]);
            int h2 = Convert.ToInt32(horas[1]);
            int total = 0;

            if (h1 >= h2)
            {
                total = (24 - h1) + h2;
            }
            else
            {
                total = h2 - h1;
            }

            Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            Console.ReadLine();
        }
    }
}
