using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_55
{
    class Program
    {
        static void Main(string[] args)
        {
            //1115 - Quadrante

            int x = 1;
            int y = 1;

            while (x != 0 || y != 0)
            {
                string[] eixos = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(eixos[0]);
                y = Convert.ToInt32(eixos[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
            }

            Console.ReadLine();
        }
    }
}
