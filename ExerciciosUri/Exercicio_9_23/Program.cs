using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //	1036	Fórmula de Bhaskara

            double A, B, C;

            string[] numbers = (Console.ReadLine()).Split(' ');
            A = Convert.ToDouble(numbers[0]);
            B = Convert.ToDouble(numbers[1]);
            C = Convert.ToDouble(numbers[2]);

            double delta = (B * B) - (4 * A * C);
            double raiz = Math.Sqrt(delta);
            if (raiz <= 0 || delta <= 0 || raiz == B)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double x1 = ((-B) + raiz) / (2 * A);
                double x2 = ((-B) - raiz) / (2 * A);

                Console.WriteLine("R1 = {0:0.00000}", x1);
                Console.WriteLine("R2 = {0:0.00000}", x2);
            }

            Console.ReadLine();
        }
    }
}
