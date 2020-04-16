using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_58
{
    class Program
    {
        static void Main(string[] args)
        {
            //1118 - Várias Notas Com Validação

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

                    if (cont == 2)
                    {
                        Console.WriteLine("media = {0:0.00}", (media / cont));

                        media = 0;

                        Console.WriteLine("novo calculo (1-sim 2-nao)");

                        int novoCalc = Convert.ToInt32(Console.ReadLine());

                        while (novoCalc != 1 && novoCalc != 2)
                        {
                            Console.WriteLine("novo calculo (1-sim 2-nao)");
                            novoCalc = Convert.ToInt32(Console.ReadLine());
                        }

                        if (novoCalc == 1)
                        {
                            cont = 0;
                        }
                    }

                }

            }

            Console.ReadLine();
        }
    }
}
