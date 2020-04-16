using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_38
{
    class Program
    {
        static void Main(string[] args)
        {
            //1065 - Pares entre Cinco Números

            int contador = 0;
            int positivo = 0;

            while (contador <= 4)
            {
                float n1 = float.Parse(Console.ReadLine());

                if (n1 % 2 == 0)
                {
                    positivo++;

                }
                contador++;
            }

            Console.WriteLine($"{positivo} valores pares");

            Console.ReadLine();
        }
    }
}
