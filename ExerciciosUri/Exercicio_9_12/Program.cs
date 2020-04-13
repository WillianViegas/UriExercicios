using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //	1012	Área

            double A;
            double B;
            double C;

            string[] dados = Console.ReadLine().Split(' ');
            A = Convert.ToDouble(dados[0]);
            B = Convert.ToDouble(dados[1]);
            C = Convert.ToDouble(dados[2]);

            double trianguloRetangulo = A * C / 2.0;
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2.0;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: {0:0.000}", trianguloRetangulo);
            Console.WriteLine("CIRCULO: {0:0.000}", circulo);
            Console.WriteLine("TRAPEZIO: {0:0.000}", trapezio);
            Console.WriteLine("QUADRADO: {0:0.000}", quadrado);
            Console.WriteLine("RETANGULO: {0:0.000}", retangulo);

            Console.ReadLine();
        }
    }
}
