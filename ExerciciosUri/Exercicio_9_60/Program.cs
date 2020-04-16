using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_60
{
    class Program
    {
        static void Main(string[] args)
        {
            //1132 - Múltiplos de 13

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (x >= y)
            {
                for (int i = y; i <= x; i++)
                {
                    if ((i % 13) != 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if ((i % 13) != 0)
                    {
                        sum += i;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
