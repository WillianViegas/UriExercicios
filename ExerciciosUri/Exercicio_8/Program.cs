using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1008	Salário

            int numFuncionario = Convert.ToInt32(Console.ReadLine());
            int horaFuncionario = Convert.ToInt32(Console.ReadLine());
            decimal salarioFuncionario = Convert.ToDecimal(Console.ReadLine());

            decimal salarioTotal = horaFuncionario * salarioFuncionario;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioTotal);
            Console.ReadLine();
        }
    }
}
