using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //1048 - Aumento de Salário

            double salario = Convert.ToDouble(Console.ReadLine());
            double reajuste = 0;
            double percentual = 0;

            if (salario >= 0 && salario <= 400.00)
            {
                percentual = 15;
                reajuste = (salario * percentual) / 100;

            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12;
                reajuste = (salario * percentual) / 100;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10;
                reajuste = (salario * percentual) / 100;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = (salario * percentual) / 100;
            }
            else
            {
                percentual = 4;
                reajuste = (salario * percentual) / 100;
            }

            salario += reajuste;

            Console.WriteLine("Novo salario: {0:0.00}", salario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine($"Em percentual: {percentual} %");
            Console.ReadLine();
        }
    }
}
