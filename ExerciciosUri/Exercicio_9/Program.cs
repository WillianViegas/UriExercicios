using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1009	Salário com Bônus

            string nomeFunc = Console.ReadLine();
            decimal salarioFunc = Convert.ToDecimal(Console.ReadLine());
            decimal vendasFunc = Convert.ToDecimal(Console.ReadLine());

            decimal parteFunc = ((vendasFunc * 15) / 100) + salarioFunc;
            Console.WriteLine("TOTAL = R$ {0:0.00}", parteFunc);
            Console.ReadLine();
        }
    }
}
