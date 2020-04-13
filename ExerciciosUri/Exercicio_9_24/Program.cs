﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //1037	Intervalo

            double n = Convert.ToDouble(Console.ReadLine());

            if (n < 0 || n > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }

            if (n >= 0 && n <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }

            if (n > 25 && n <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }

            if (n > 50 && n <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }

            if (n > 75 && n <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            Console.ReadLine();
        }
    }
}
