using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_52
{
    class Program
    {
        static void Main(string[] args)
        {
            //1134 - Tipo de Combustível

            int n = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (n != 4)
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {
                    alcool++;
                }

                if (n == 2)
                {
                    gasolina++;
                }

                if (n == 3)
                {
                    diesel++;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);


            Console.ReadLine();
        }
    }
}
