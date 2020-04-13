using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //	1019	Conversão de Tempo

            int tempo = Convert.ToInt32(Console.ReadLine());

            int horas = tempo / 3600;
            int min = tempo % 3600 / 60;
            int seg = tempo % 3600 % 60;

            Console.WriteLine(horas + ":" + min + ":" + seg);
            Console.ReadLine();
        }
    }
}
