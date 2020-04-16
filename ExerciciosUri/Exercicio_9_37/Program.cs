using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_37
{
    class Program
    {
        static void Main(string[] args)
        {
            //1064 - Positivos e Média

            int contador = 0;
            int positivo = 0;
            float somapositivos = 0;
            while (contador <= 5)
            {
                float n1 = float.Parse(Console.ReadLine());

                if (n1 > 0)
                {
                    positivo++;
                    somapositivos += n1;

                }
                contador++;
            }

            somapositivos = somapositivos / positivo;
            Console.WriteLine($"{positivo} valores positivos");
            Console.WriteLine("{0:0.0}", somapositivos);

            Console.ReadLine();
        }
    }
}
