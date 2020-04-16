using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_59
{
    class Program
    {
        static void Main(string[] args)
        {
            //1131 - Grenais

            int continuar = 0;
            int cont = 0;
            int gremioVenceu = 0;
            int interVenceu = 0;
            int empate = 0;

            while (continuar != 2)
            {
                string[] grenais = Console.ReadLine().Split(' ');
                int inter = Convert.ToInt32(grenais[0]);
                int gremio = Convert.ToInt32(grenais[1]);
                cont++;

                if (gremio > inter)
                {
                    gremioVenceu++;
                }
                else if (inter > gremio)
                {
                    interVenceu++;
                }
                else
                {
                    empate++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                continuar = Convert.ToInt32(Console.ReadLine());

                while (continuar != 1 && continuar != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    continuar = Convert.ToInt32(Console.ReadLine());
                }

                if (continuar == 2)
                {
                    Console.WriteLine($"{cont} grenais");
                    Console.WriteLine($"Inter:{interVenceu}");
                    Console.WriteLine($"Gremio:{gremioVenceu}");
                    Console.WriteLine($"Empates:{empate}");

                    if (interVenceu > gremioVenceu)
                    {
                        Console.WriteLine("Inter venceu mais");

                    }
                    else
                    {
                        Console.WriteLine("Gremio venceu mais");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
