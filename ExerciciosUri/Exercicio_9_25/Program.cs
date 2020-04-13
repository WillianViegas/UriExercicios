using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //1038	Lanche

            string[] valores = Console.ReadLine().Split(' ');

            int codigo = Convert.ToInt32(valores[0]);
            int quantidade = Convert.ToInt32(valores[1]);

            double total = 0;

            switch (codigo)
            {
                case 1:
                    total = quantidade * 4.00;
                    break;

                case 2:
                    total = quantidade * 4.50;
                    break;

                case 3:
                    total = quantidade * 5.00;
                    break;

                case 4:
                    total = quantidade * 2.00;
                    break;

                case 5:
                    total = quantidade * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ {0:0.00}", total);

            Console.ReadLine();
        }
    }
}
