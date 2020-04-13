using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1004	Produto Simples

                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());

                int prod = A * B;

                Console.WriteLine("PROD = " + prod);
                Console.ReadLine();
        }
    }
}
