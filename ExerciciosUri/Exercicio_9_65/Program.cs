using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_65
{
    class Program
    {
        static void Main(string[] args)
        {
            //1045 - Tipos de Triângulos

            List<string> valores = Console.ReadLine().Split(' ').ToList();
            List<double> quadrado = new List<double>();

            valores.Sort();
            valores.Reverse();

            float A = float.Parse(valores[0]);
            float B = float.Parse(valores[1]);
            float C = float.Parse(valores[2]);

            double a = Math.Pow(A, 2);
            double b = Math.Pow(B, 2);
            double c = Math.Pow(C, 2);

            quadrado.Add(a);
            quadrado.Add(b);
            quadrado.Add(c);

            quadrado.Sort();
            quadrado.Reverse();

            a = quadrado[0];
            b = quadrado[1];
            c = quadrado[2];


            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (a == b + c)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (a < b + c)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                else if (a > b + c)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            Console.ReadLine();
        }
    }
}
