using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_47
{
    class Program
    {
        static void Main(string[] args)
        {
            //1079 - Médias Ponderadas

            double n = Convert.ToDouble(Console.ReadLine());
            int contador = 1;
            while (contador <= n)
            {
                string[] x = Console.ReadLine().Split(' ');

                double n1 = Convert.ToDouble(x[0]);
                double n2 = Convert.ToDouble(x[1]);
                double n3 = Convert.ToDouble(x[2]);
                double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

                Console.WriteLine("{0:0.0}", media);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
