using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_41
{
    class Program
    {
        static void Main(string[] args)
        {
            //1070 - Seis Números Ímpares

            int val = Convert.ToInt32(Console.ReadLine());
            int contador = val;
            int limite = 0;

            while (contador >= val && limite <= 11)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
                limite++;
            }

            Console.ReadLine();
        }
    }
}
