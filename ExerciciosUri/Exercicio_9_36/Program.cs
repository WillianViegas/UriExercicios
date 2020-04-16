using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_36
{
    class Program
    {
        static void Main(string[] args)
        {
            //1060 - Números Positivos

            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            float n4 = float.Parse(Console.ReadLine());
            float n5 = float.Parse(Console.ReadLine());
            float n6 = float.Parse(Console.ReadLine());

            float positivo = 0;

            if (n1 > 0)
            {
                positivo += 1;
            }
            if (n2 > 0)
            {
                positivo += 1;
            }
            if (n3 > 0)
            {
                positivo += 1;
            }
            if (n4 > 0)
            {
                positivo += 1;
            }
            if (n5 > 0)
            {
                positivo += 1;
            }
            if (n6 > 0)
            {
                positivo += 1;
            }

            Console.WriteLine($"{positivo} valores positivos");

            Console.ReadLine();
        }
    }
}
