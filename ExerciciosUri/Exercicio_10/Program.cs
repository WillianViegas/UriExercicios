using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1010	Cálculo Simples

            int codigoprod1;
            int quantidadeprod1;
            double precoprod1;

            string[] linha1 = Console.ReadLine().Split(' ');
            codigoprod1 = Convert.ToInt32(linha1[0]);
            quantidadeprod1 = Convert.ToInt32(linha1[1]);
            precoprod1 = Convert.ToDouble(linha1[2]);

            int codigoprod2;
            int quantidadeprod2;
            double precoprod2;

            string[] linha2 = Console.ReadLine().Split(' ');
            codigoprod2 = Convert.ToInt32(linha2[0]);
            quantidadeprod2 = Convert.ToInt32(linha2[1]);
            precoprod2 = Convert.ToDouble(linha2[2]);

            double totalprod1 = quantidadeprod1 * precoprod1;
            double totalprod2 = quantidadeprod2 * precoprod2;

            double valorTotal = totalprod1 + totalprod2;

            Console.WriteLine("VALOR A PAGAR: R$ {0:f2}", valorTotal);

            Console.ReadLine();

        }
    }
}
