using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //1018	Cédulas

            int n = Convert.ToInt32(Console.ReadLine());

            int val100 = n / 100;
            int v100 = 100 * val100;

            int val50 = (n - v100) / 50;
            int v50 = v100 + (50 * val50);

            int val20 = (n - v50) / 20;
            int v20 = v50 + (20 * val20);

            int val10 = (n - v20) / 10;
            int v10 = v20 + (10 * val10);

            int val5 = (n - v10) / 5;
            int v5 = v10 + (5 * val5);

            int val2 = (n - v5) / 2;
            int v2 = v5 + (2 * val2);

            int val1 = (n - v2) / 1;

            Console.WriteLine(n);
            Console.WriteLine(val100 + " nota(s) de R$ 100,00");
            Console.WriteLine(val50 + " nota(s) de R$ 50,00");
            Console.WriteLine(val20 + " nota(s) de R$ 20,00");
            Console.WriteLine(val10 + " nota(s) de R$ 10,00");
            Console.WriteLine(val5 + " nota(s) de R$ 5,00");
            Console.WriteLine(val2 + " nota(s) de R$ 2,00");
            Console.WriteLine(val1 + " nota(s) de R$ 1,00");

            Console.ReadLine();
        }
    }
}
