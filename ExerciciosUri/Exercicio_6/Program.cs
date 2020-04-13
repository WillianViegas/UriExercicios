using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1006	Média 2
           
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            double X = Math.Round((A * 2 + B * 3 + C * 5) / 10, 2);
            string Z = X.ToString("N1");
            string Y = Convert.ToString(Z).Replace(",", ".");
            Console.WriteLine("MEDIA = " + Y);
            Console.ReadLine();

        }
    }
}
