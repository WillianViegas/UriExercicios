using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_51
{
    class Program
    {
        static void Main(string[] args)
        {
            //1097 - Sequencia IJ 3

            int i = 0;
            int j = 7;
            while (i <= 9)
            {
                if (i % 2 != 0)
                {
                    for (int x = 1; x <= 3; x++)
                    {
                        Console.Write($"I={i} ");
                        Console.WriteLine($"J={j}");
                        j--;
                    }
                    j += 5;
                }

                i++;
            }


            Console.ReadLine();
        }
    }
}
