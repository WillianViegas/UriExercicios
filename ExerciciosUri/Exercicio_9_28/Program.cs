using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //1043 - Triângulo

            string[] valores = Console.ReadLine().Split(' ');
            double A = Convert.ToDouble(valores[0]);
            double B = Convert.ToDouble(valores[1]);
            double C = Convert.ToDouble(valores[2]);

            if (A < B + C && A > Math.Abs(B - C))
            {
                Console.WriteLine("Perimetro = {0:0.0}", (A + B + C));
            }
            else
            {
                Console.WriteLine("Area = {0:0.0}", (C * (A + B) / 2));
            }

            Console.ReadLine();
        }
    }
}
