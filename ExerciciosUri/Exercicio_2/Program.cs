using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1002	Área do Círculo

            double r = Convert.ToDouble(Console.ReadLine());

            double A = 3.14159 * Math.Pow(r, 2);

            Console.WriteLine("A={0:0.0000}", A);
            Console.ReadLine();

        }
    }
}
