using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //1017	Gasto de Combustível

            int time = Convert.ToInt32(Console.ReadLine());
            int speed = Convert.ToInt32(Console.ReadLine());

            double litros = (time * speed) / 12.0;
            string lit = litros.ToString("N3");

            Console.WriteLine(lit);
            Console.ReadLine();
        }
    }
}
