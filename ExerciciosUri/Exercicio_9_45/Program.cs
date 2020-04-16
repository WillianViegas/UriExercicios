using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_45
{
    class Program
    {
        static void Main(string[] args)
        {
            //1071 - Soma de Impares Consecutivos I

            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int contador = 0;
            int soma = 0;

            if (n1 < n2)
            {
                contador = n1 + 1;

                while (contador < n2)
                {
                    if (contador % 2 != 0)
                    {
                        soma += contador;
                    }
                    contador++;
                }
            }
            else
            {
                contador = n2 + 1;
                while (contador < n1)
                {
                    if (contador % 2 != 0)
                    {
                        soma += contador;
                    }
                    contador++;
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
