using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_29
{
    class Program
    {
        static void Main(string[] args)
        {
            //1044 - Múltiplos

            string[] n = Console.ReadLine().Split(' ');
            int A = Convert.ToInt32(n[0]);
            int B = Convert.ToInt32(n[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");

            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadLine();
        }
    }
}
