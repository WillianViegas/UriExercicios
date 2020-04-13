using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //1020	Idade em Dias


            int tempo = Convert.ToInt32(Console.ReadLine());

            int ano = tempo / 365;
            int mes = tempo % 365 / 30;
            int dias = tempo % 365 % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            Console.ReadLine();
        }
    }
}
