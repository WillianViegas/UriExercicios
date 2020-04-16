using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_44
{
    class Program
    {
        static void Main(string[] args)
        {
            //1075 - Resto 2

            int n = Convert.ToInt32(Console.ReadLine());
            int contador = 1;

            while (contador <= 10000)
            {
                if (contador % n == 2)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }

            Console.ReadLine();
        }
    }
}
