using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //	1015	Distância Entre Dois Pontos

            double x1;
            double y1;

            double x2;
            double y2;

            string[] linha1 = Console.ReadLine().Split(' ');
            x1 = Convert.ToDouble(linha1[0]);
            y1 = Convert.ToDouble(linha1[1]);

            string[] linha2 = Console.ReadLine().Split(' ');
            x2 = Convert.ToDouble(linha2[0]);
            y2 = Convert.ToDouble(linha2[1]);

            double distancia = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);

            Console.WriteLine(distancia);
            Console.ReadLine();
        }
    }
}
