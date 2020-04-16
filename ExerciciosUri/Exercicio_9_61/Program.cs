using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_61
{
    class Program
    {
        static void Main(string[] args)
        {

            //1133 - Resto da Divisão

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            List<int> valor = new List<int>();

            if (x >= y)
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        valor.Add(i);
                    }
                }
            }
            else
            {
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        valor.Add(i);
                    }
                }
            }

            valor.Sort();

            foreach (int val in valor)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
