using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //1041 - Coordenadas de um Ponto

            string[] coordenadas = Console.ReadLine().Split(' ');


            double x = Convert.ToDouble(coordenadas[0]);
            double y = Convert.ToDouble(coordenadas[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }

            if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }

            if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }


            Console.ReadLine();
        }
    }
}
