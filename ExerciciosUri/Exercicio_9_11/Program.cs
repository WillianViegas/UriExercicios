using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1011	Esfera

            double r = Convert.ToDouble(Console.ReadLine());

            double sphere = 4.0 / 3 * 3.14159 * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = {0:0.000}", sphere);
            Console.ReadLine();

        }
    }
}
