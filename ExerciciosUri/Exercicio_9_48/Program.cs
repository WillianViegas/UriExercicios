using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_48
{
    class Program
    {
        static void Main(string[] args)
        {
            //1094 - Experiências

            int n = Convert.ToInt32(Console.ReadLine());
            int contador = 1;
            int total = 0;
            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            while (contador <= n)
            {
                string[] quantia = Console.ReadLine().Split(' ');
                int valor = Convert.ToInt32(quantia[0]);
                string tipo = quantia[1];

                total += valor;

                if (tipo.Equals("C"))
                {
                    coelhos += valor;

                }

                if (tipo.Equals("R"))
                {
                    ratos += valor;

                }

                if (tipo.Equals("S"))
                {
                    sapos += valor;
                }

                contador++;
            }

            double percCoelhos = (coelhos * 100.0) / total;
            double percRatos = (ratos * 100.0) / total;
            double percSapos = (sapos * 100.0) / total;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");

            Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2") + " %");

            Console.ReadLine();
        }
    }
}
