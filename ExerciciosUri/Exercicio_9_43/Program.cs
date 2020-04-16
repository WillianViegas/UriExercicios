using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_43
{
    class Program
    {
        static void Main(string[] args)
        {
            //1074 - Par ou Ímpar

            int n = Convert.ToInt32(Console.ReadLine());
            int contador = 1;

            while (contador <= n)
            {
                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("NULL");
                }

                if (valor % 2 == 0 && valor != 0)
                {
                    Console.Write("EVEN");

                    if (valor > 0)
                    {
                        Console.WriteLine(" POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine(" NEGATIVE");
                    }
                }
                else if (valor % 2 != 0)
                {
                    Console.Write("ODD");

                    if (valor > 0)
                    {
                        Console.WriteLine(" POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine(" NEGATIVE");
                    }
                }
                contador++;
            }

            Console.ReadLine();
        }
    }
}
