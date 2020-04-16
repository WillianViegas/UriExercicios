using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_63
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1143 - Quadrado e ao Cubo

            int n = Convert.ToInt32(Console.ReadLine());
            double val = 0;

            for (int i = 1; i <= n; i++)
            {
                val = Math.Pow(i, 1);
                Console.Write(val + " ");

                val = Math.Pow(i, 2);
                Console.Write(val + " ");

                val = Math.Pow(i, 3);
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
