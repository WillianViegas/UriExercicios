using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1005	Média 1

            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double Y = (A * 3.5 + B * 7.5) / 11;

            Console.WriteLine("MEDIA = {0:0.00000}", Y);
            Console.ReadLine();
        }
    }
}
