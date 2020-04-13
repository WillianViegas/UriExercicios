using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1014    Consumo

            int distancia = Convert.ToInt32(Console.ReadLine());
            double fuel = Convert.ToDouble(Console.ReadLine());

            double mediaConsumida = Math.Round(distancia / fuel, 3);

            Console.WriteLine(mediaConsumida + " km/l");
            Console.ReadLine();

        }
    }
}
