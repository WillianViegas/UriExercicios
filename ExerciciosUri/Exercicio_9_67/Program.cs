using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_67
{
    class Program
    {
        static void Main(string[] args)
        {
            //1154 - Idades

            int valor = 0;
            int cont = 0;
            double soma = 0;

            while (valor >= 0)
            {
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor < 0)
                {
                    break;
                }

                soma += valor;

                cont++;
            }

            soma /= cont;
            Console.WriteLine("{0:0.00}", soma);
            Console.ReadLine();
        }
    }
}
