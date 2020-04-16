using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_40
{
    class Program
    {
        static void Main(string[] args)
        {
            //1067 - Números Ímpares

            int val = Convert.ToInt32(Console.ReadLine());
            int contador = 0;

            while (contador <= val)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }

            Console.ReadLine();
        }
    }
}
