using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_64
{
    class Program
    {
        static void Main(string[] args)
        {
            //1040 - Média 3

            string[] notas = Console.ReadLine().Split(' ');

            double n1 = Convert.ToDouble(notas[0]);
            double n2 = Convert.ToDouble(notas[1]);
            double n3 = Convert.ToDouble(notas[2]);
            double n4 = Convert.ToDouble(notas[3]);

            double media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + n4) / 10.0;
            double mediaRnd = Math.Round(media, 1);

            Console.WriteLine("Media: {0:0.0}", mediaRnd);

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                double notaExame = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0:0.0}", notaExame);

                double mediaExame = (media + notaExame) / 2.0;
                double mediaExameRnd = Math.Round(mediaExame, 1);

                if (mediaExame >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: {0:0.0}", mediaExameRnd);
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.ReadLine();
        }
    }
}
