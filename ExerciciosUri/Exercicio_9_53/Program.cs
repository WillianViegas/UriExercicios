using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_53
{
    class Program
    {
        static void Main(string[] args)
        {
            //1113 - Crescente e Decrescente

            string[] valores = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(valores[0]);
            int y = Convert.ToInt32(valores[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }

                valores = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(valores[0]);
                y = Convert.ToInt32(valores[1]);
            }
            Console.ReadLine();
        }
    }
}
