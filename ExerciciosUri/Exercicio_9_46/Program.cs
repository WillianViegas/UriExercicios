using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_46
{
    class Program
    {
        static void Main(string[] args)
        {
            //1078 - Tabuada

            int n1 = Convert.ToInt32(Console.ReadLine());
            int contador = 1;
            while (contador <= 10)
            {
                int x = contador * n1;
                Console.WriteLine($"{contador} x {n1} = {x}");

                contador++;
            }

            Console.ReadLine();
        }
    }
}
