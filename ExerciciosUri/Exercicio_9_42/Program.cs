using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_42
{
    class Program
    {
        static void Main(string[] args)
        {
            //1073 - Quadrado de Pares

            int n1 = Convert.ToInt32(Console.ReadLine());
            int contador = 1;

            while (contador <= n1)
            {
                if (contador % 2 == 0)
                {
                    int recebe = contador;
                    double elevado = contador * contador;
                    Console.WriteLine($"{contador}^2 = {elevado}");
                }

                contador++;
            }
            Console.ReadLine();
        }
    }
}
