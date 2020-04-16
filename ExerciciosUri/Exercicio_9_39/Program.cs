using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_39
{
    class Program
    {
        static void Main(string[] args)
        {
            //1066 - Pares, Ímpares, Positivos e Negativos

            int positivos = 0;
            int negativos = 0;
            int pares = 0;
            int impares = 0;
            int contador = 0;

            while (contador < 5)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    positivos++;
                }
                else if (n < 0)
                {
                    negativos++;
                }

                if (n % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                contador++;
            }

            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");

            Console.ReadLine();
        }
    }
}
