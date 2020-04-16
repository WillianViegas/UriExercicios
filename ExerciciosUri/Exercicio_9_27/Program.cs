using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //1042 - Sort Simples

            string[] entrada = Console.ReadLine().Split(' ');
            int[] valores = new int[3];
            valores[0] = Convert.ToInt32(entrada[0]);
            valores[1] = Convert.ToInt32(entrada[1]);
            valores[2] = Convert.ToInt32(entrada[2]);
            Array.Sort(valores);

            Console.WriteLine(valores[0]);
            Console.WriteLine(valores[1]);
            Console.WriteLine(valores[2]);

            Console.WriteLine("");

            Console.WriteLine(entrada[0]);
            Console.WriteLine(entrada[1]);
            Console.WriteLine(entrada[2]);

            Console.ReadLine();
        }
    }
}
