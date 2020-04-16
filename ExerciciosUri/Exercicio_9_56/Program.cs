using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_56
{
    class Program
    {
        static void Main(string[] args)
        {
            //1116 - Dividindo X por Y

            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 1;
            while (cont <= n)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double x = Convert.ToDouble(valores[0]);
                double y = Convert.ToDouble(valores[1]);

                double divisao = x / y;

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine("{0:0.0}", divisao);
                }

                cont++;
            }

            Console.ReadLine();
        }
    }
}
