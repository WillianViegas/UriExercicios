using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_62
{
    class Program
    {
        static void Main(string[] args)
        {
            //1142 - PUM

            int n = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            int cont = 3;
            for (int i = 1; i <= n; i++)
            {
                while (x <= i + cont)
                {

                    if (x == i + cont)
                    {
                        Console.WriteLine("PUM");
                        x++;
                        break;
                    }

                    Console.Write(x + " ");

                    x++;

                }
                cont += 3;
            }

            Console.ReadLine();
        }
    }
}
