using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_54
{
    class Program
    {
        static void Main(string[] args)
        {
            //1114 - Senha Fixa


            int i = 0;

            while (i <= 2002)
            {
                int senha = Convert.ToInt32(Console.ReadLine());

                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }

                Console.WriteLine("Senha Invalida");
                i++;
            }
            Console.ReadLine();
        }
    }
}
