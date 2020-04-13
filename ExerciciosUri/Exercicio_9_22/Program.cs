using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //1035	Teste de Seleção 1

            int A, B, C, D;

            string[] linha = (Console.ReadLine()).Split(' '); ;

            A = Convert.ToInt32(linha[0]);
            B = Convert.ToInt32(linha[1]);
            C = Convert.ToInt32(linha[2]);
            D = Convert.ToInt32(linha[3]);

            int somaCD = C + D;
            int somaAB = A + B;


            if (B > C && D > A && somaCD > somaAB && C > 0 && D > 0 && A > 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.ReadLine();
        }
    }
}
