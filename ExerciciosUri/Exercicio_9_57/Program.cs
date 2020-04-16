using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_57
{
    class Program
    {
        static void Main(string[] args)
        {
            //1117 - Validação de Nota
            
            int cont = 0;
            double media = 0;

            while (cont < 2)
            {
                double x = Convert.ToDouble(Console.ReadLine());

                if (x < 0 || x > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    media += x;
                    cont++;
                }

            }

            Console.WriteLine("media = " + media / cont);
            Console.ReadLine();
        }
    }
}
