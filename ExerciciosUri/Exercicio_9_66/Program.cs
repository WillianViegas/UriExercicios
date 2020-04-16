using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_66
{
    class Program
    {
        static void Main(string[] args)
        {
            //1146 - Sequências Crescentes

            int valor = 1;
            int cont = 1;
            string v = "";

            while (valor != 0)
            {
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }

                while (cont <= valor)
                {
                    if (cont < valor)
                    {
                        v += (cont + " ");
                    }
                    else
                    {
                        v += cont;
                    }
                    cont++;
                }
                Console.WriteLine(v);

                cont = 1;
                v = "";
            }
            Console.ReadLine();
        }
    }
}
