using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //1013	O Maior

            string[] numeros = Console.ReadLine().Split(' ');

            int A = Convert.ToInt32(numeros[0]);
            int B = Convert.ToInt32(numeros[1]);
            int C = Convert.ToInt32(numeros[2]);

            int maiorprimeiro = (A + B + Math.Abs(A - B)) / 2;

            if (C > maiorprimeiro)
            {
                Console.WriteLine(C + " eh o maior");
            }
            else
            {
                Console.WriteLine(maiorprimeiro + " eh o maior");
            }
            Console.ReadLine();
        }
    }
}
